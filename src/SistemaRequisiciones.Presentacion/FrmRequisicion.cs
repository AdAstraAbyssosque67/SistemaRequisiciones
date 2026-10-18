using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaRequisiciones.Entidades;
using SistemaRequisiciones.Negocio.Builder;
using SistemaRequisiciones.Negocio.Estados;
using SistemaRequisiciones.Negocio.Servicios;

namespace SistemaRequisiciones.Presentacion
{
    // Captura, edición y seguimiento de una requisición. Este formulario no calcula montos
    // ni valida transiciones: todo eso lo hacen el Builder y los servicios de negocio.
    public partial class FrmRequisicion : Form
    {
        private readonly ServicioRequisiciones servicioRequisiciones = new ServicioRequisiciones();
        private readonly int idRequisicionInicial;

        private Requisicion requisicion;       // null mientras la requisición es nueva
        private RequisicionBuilder borrador;   // null cuando la requisición ya no se puede editar
        private List<Solicitante> solicitantes = new List<Solicitante>();
        private bool cargando;
        private bool hayCambiosSinGuardar;

        public FrmRequisicion()
        {
            InitializeComponent();
        }

        public FrmRequisicion(int idRequisicion) : this()
        {
            idRequisicionInicial = idRequisicion;
        }

        // ---------- Carga inicial ----------

        private void FrmRequisicion_Load(object sender, EventArgs e)
        {
            cargando = true;
            try
            {
                CargarListas();
                if (idRequisicionInicial > 0)
                {
                    AbrirRequisicionExistente(idRequisicionInicial);
                }
                else
                {
                    IniciarRequisicionNueva();
                }
            }
            catch (Exception ex)
            {
                Mensajes.MostrarError(this, ex);
                Close();
                return;
            }
            finally
            {
                cargando = false;
            }
            ActualizarVista();
        }

        private void CargarListas()
        {
            solicitantes = servicioRequisiciones.ListarSolicitantes();
            cmbSolicitante.DataSource = solicitantes;
            cmbDepartamento.DataSource = servicioRequisiciones.ListarDepartamentos();
            cmbArticulo.DataSource = servicioRequisiciones.ListarArticulosActivos();
            lblPolitica.Text = "Política: " + servicioRequisiciones.NombrePoliticaImpuesto;
        }

        private void IniciarRequisicionNueva()
        {
            requisicion = null;
            borrador = servicioRequisiciones.NuevoBorrador();
            hayCambiosSinGuardar = false;
            txtJustificacion.Clear();
            ProponerDepartamento();
        }

        private void AbrirRequisicionExistente(int idRequisicion)
        {
            requisicion = servicioRequisiciones.ObtenerPorId(idRequisicion);
            cmbSolicitante.SelectedValue = requisicion.IdSolicitante;
            cmbDepartamento.SelectedValue = requisicion.IdDepartamento;
            txtJustificacion.Text = requisicion.Justificacion;
            hayCambiosSinGuardar = false;

            // Solo las requisiciones en estado Creada se pueden editar.
            bool sePuedeEditar = EstadoRequisicion.Desde(requisicion.EstadoActual).PermiteModificar;
            borrador = sePuedeEditar ? servicioRequisiciones.BorradorDesde(requisicion) : null;
        }

        // Vuelve a leer la requisición de la base de datos (por ejemplo, tras un conflicto de estado).
        private void RecargarRequisicion()
        {
            cargando = true;
            try
            {
                AbrirRequisicionExistente(requisicion.IdRequisicion);
            }
            catch (Exception ex)
            {
                Mensajes.MostrarError(this, ex);
            }
            finally
            {
                cargando = false;
            }
            ActualizarVista();
        }

        // ---------- Presentación del estado actual ----------

        private EstadoRequisicion EstadoVigente
        {
            get { return requisicion == null ? null : EstadoRequisicion.Desde(requisicion.EstadoActual); }
        }

        private void ActualizarVista()
        {
            ActualizarEncabezado();
            MostrarDetalles();
            MostrarMontos();
            ActualizarBotones();
        }

        private void ActualizarEncabezado()
        {
            if (requisicion == null)
            {
                lblTitulo.Text = "Nueva requisición";
                lblCodigo.Text = "Código: se asigna al guardar";
                txtFecha.Text = "Se asigna al guardar";
                lblEstado.Text = "Nueva";
                lblEstado.BackColor = PaletaEstados.Nueva;
                return;
            }

            lblTitulo.Text = "Requisición " + requisicion.Codigo;
            lblCodigo.Text = "Código: " + requisicion.Codigo;
            txtFecha.Text = requisicion.Fecha.ToString("dd/MM/yyyy HH:mm");
            lblEstado.Text = EstadoVigente.Nombre;
            lblEstado.BackColor = PaletaEstados.Fondo(requisicion.EstadoActual);
        }

        private void MostrarDetalles()
        {
            IReadOnlyList<DetalleRequisicion> detalles = borrador != null ? borrador.Detalles : requisicion.Detalles;

            dgvDetalle.Rows.Clear();
            foreach (DetalleRequisicion detalle in detalles)
            {
                int fila = dgvDetalle.Rows.Add(detalle.CodigoArticulo, detalle.NombreArticulo,
                                               detalle.Cantidad, detalle.PrecioUnitario, detalle.Importe);
                dgvDetalle.Rows[fila].Tag = detalle.IdArticulo;
            }
        }

        // Los montos siempre vienen de la capa de negocio; los cuadros son de solo lectura.
        private void MostrarMontos()
        {
            decimal subtotal;
            decimal impuestos;
            decimal total;

            if (borrador != null)
            {
                MontosRequisicion montos = borrador.MontosActuales;
                subtotal = montos.Subtotal;
                impuestos = montos.Impuestos;
                total = montos.Total;
            }
            else
            {
                subtotal = requisicion.Subtotal;
                impuestos = requisicion.Impuestos;
                total = requisicion.Total;
            }

            txtSubtotal.Text = subtotal.ToString("N2");
            txtImpuestos.Text = impuestos.ToString("N2");
            txtTotal.Text = total.ToString("N2");
        }

        // Habilita solo las acciones que corresponden al estado actual. Es una ayuda visual:
        // las reglas reales se verifican de nuevo en la capa de negocio y en SQL Server.
        private void ActualizarBotones()
        {
            bool editable = borrador != null;
            HabilitarCaptura(editable);

            EstadoRequisicion estado = EstadoVigente;
            bool existe = estado != null;

            btnGuardar.Enabled = editable;
            btnEnviarRevision.Enabled = existe && !hayCambiosSinGuardar && estado.PuedeIrA(CodigoEstado.EnRevision);
            btnAprobar.Enabled = existe && estado.PuedeIrA(CodigoEstado.Aprobada);
            btnRechazar.Enabled = existe && estado.PuedeIrA(CodigoEstado.Rechazada);
            btnCancelarRequisicion.Enabled = existe && estado.PuedeIrA(CodigoEstado.Cancelada);
            btnGenerarReporte.Enabled = existe && estado.PermiteGenerarReporte;
        }

        private void HabilitarCaptura(bool habilitar)
        {
            cmbSolicitante.Enabled = habilitar;
            cmbDepartamento.Enabled = habilitar;
            txtJustificacion.ReadOnly = !habilitar;
            cmbArticulo.Enabled = habilitar;
            nudCantidad.Enabled = habilitar;
            nudPrecio.Enabled = habilitar;
            btnAgregarArticulo.Enabled = habilitar;
            btnQuitarArticulo.Enabled = habilitar;
        }

        private void MarcarCambio()
        {
            hayCambiosSinGuardar = true;
            ActualizarBotones();
        }

        // ---------- Captura ----------

        private static int ObtenerIdSeleccionado(ComboBox lista)
        {
            return lista.SelectedValue is int ? (int)lista.SelectedValue : 0;
        }

        // Al elegir un solicitante se propone su departamento, que el usuario puede cambiar.
        private void ProponerDepartamento()
        {
            Solicitante solicitante = cmbSolicitante.SelectedItem as Solicitante;
            if (solicitante != null)
            {
                cmbDepartamento.SelectedValue = solicitante.IdDepartamento;
            }
        }

        private void cmbSolicitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando || borrador == null)
            {
                return;
            }
            ProponerDepartamento();
            MarcarCambio();
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cargando && borrador != null)
            {
                MarcarCambio();
            }
        }

        private void txtJustificacion_TextChanged(object sender, EventArgs e)
        {
            if (!cargando && borrador != null)
            {
                MarcarCambio();
            }
        }

        // Al elegir un artículo se propone su precio de referencia, que se puede ajustar.
        private void cmbArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Articulo articulo = cmbArticulo.SelectedItem as Articulo;
            if (articulo != null && articulo.PrecioReferencia >= nudPrecio.Minimum && articulo.PrecioReferencia <= nudPrecio.Maximum)
            {
                nudPrecio.Value = articulo.PrecioReferencia;
            }
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                // El Builder valida cantidad, precio y duplicados, y calcula el importe.
                borrador.AgregarArticulo(cmbArticulo.SelectedItem as Articulo, (int)nudCantidad.Value, nudPrecio.Value);
                nudCantidad.Value = 1;
                MarcarCambio();
                MostrarDetalles();
                MostrarMontos();
            }
            catch (Exception ex)
            {
                Mensajes.MostrarError(this, ex);
            }
        }

        private void btnQuitarArticulo_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow == null)
            {
                Mensajes.Advertir(this, "Seleccione en la lista el artículo que desea quitar.");
                return;
            }

            borrador.QuitarArticulo((int)dgvDetalle.CurrentRow.Tag);
            MarcarCambio();
            MostrarDetalles();
            MostrarMontos();
        }

        // ---------- Guardar y salir ----------

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                borrador.ConSolicitante(ObtenerIdSeleccionado(cmbSolicitante))
                        .ConDepartamento(ObtenerIdSeleccionado(cmbDepartamento))
                        .ConJustificacion(txtJustificacion.Text);

                bool eraNueva = requisicion == null;
                Requisicion guardada = servicioRequisiciones.Guardar(borrador);

                requisicion = guardada;
                borrador = servicioRequisiciones.BorradorDesde(guardada);
                hayCambiosSinGuardar = false;
                ActualizarVista();

                Mensajes.Informar(this, eraNueva
                    ? "La requisición " + guardada.Codigo + " se creó correctamente."
                    : "Los cambios de la requisición " + guardada.Codigo + " se guardaron correctamente.");
            }
            catch (Exception ex)
            {
                Mensajes.MostrarError(this, ex);
            }
        }

        private void btnCancelarCaptura_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRequisicion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hayCambiosSinGuardar && !Mensajes.Confirmar(this, "Hay cambios sin guardar. ¿Desea cerrar de todos modos?"))
            {
                e.Cancel = true;
            }
        }

        // ---------- Cambios de estado ----------

        private void btnEnviarRevision_Click(object sender, EventArgs e)
        {
            EjecutarCambioEstado("¿Enviar la requisición a revisión? Después ya no se podrá modificar.",
                                 servicioRequisiciones.EnviarARevision, "La requisición se envió a revisión.");
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            EjecutarCambioEstado("¿Aprobar la requisición?", servicioRequisiciones.Aprobar, "La requisición fue aprobada.");
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            EjecutarCambioEstado("¿Rechazar la requisición?", servicioRequisiciones.Rechazar, "La requisición fue rechazada.");
        }

        private void btnCancelarRequisicion_Click(object sender, EventArgs e)
        {
            EjecutarCambioEstado("¿Cancelar la requisición? Esta acción no se puede deshacer.",
                                 servicioRequisiciones.Cancelar, "La requisición fue cancelada.");
        }

        // La capa de negocio valida la transición; aquí solo se confirma, se muestra el resultado
        // y se sincroniza el formulario con lo que quedó guardado.
        private void EjecutarCambioEstado(string pregunta, Func<int, Requisicion> accion, string mensajeExito)
        {
            if (requisicion == null || !Mensajes.Confirmar(this, pregunta))
            {
                return;
            }

            try
            {
                requisicion = accion(requisicion.IdRequisicion);

                if (!EstadoVigente.PermiteModificar)
                {
                    borrador = null;
                }
                hayCambiosSinGuardar = false;
                ActualizarVista();
                Mensajes.Informar(this, mensajeExito);
            }
            catch (Exception ex)
            {
                Mensajes.MostrarError(this, ex);
                RecargarRequisicion();
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            AperturaReporte.Mostrar(this, requisicion.IdRequisicion);
        }
    }
}

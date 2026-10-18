using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SistemaRequisiciones.Entidades;
using SistemaRequisiciones.Negocio.Estados;
using SistemaRequisiciones.Negocio.Servicios;

namespace SistemaRequisiciones.Presentacion
{
    // Búsqueda de requisiciones por código, solicitante, fechas y estado.
    public partial class FrmConsultaRequisiciones : Form
    {
        private readonly ServicioRequisiciones servicioRequisiciones = new ServicioRequisiciones();
        private readonly CodigoEstado? estadoInicial;
        private List<Requisicion> resultados = new List<Requisicion>();

        public FrmConsultaRequisiciones() : this(null)
        {
        }

        // Si se indica un estado, la consulta se abre filtrada por él.
        public FrmConsultaRequisiciones(CodigoEstado? estadoInicial)
        {
            InitializeComponent();
            this.estadoInicial = estadoInicial;
        }

        private void FrmConsultaRequisiciones_Load(object sender, EventArgs e)
        {
            try
            {
                CargarFiltros();
            }
            catch (Exception ex)
            {
                Mensajes.MostrarError(this, ex);
                return;
            }

            if (estadoInicial.HasValue)
            {
                SeleccionarPorValor(cmbEstado, estadoInicial.Value);
            }
            Buscar();
        }

        private void CargarFiltros()
        {
            List<ElementoLista> solicitantes = new List<ElementoLista> { new ElementoLista("(Todos)", null) };
            solicitantes.AddRange(servicioRequisiciones.ListarSolicitantes()
                                  .Select(s => new ElementoLista(s.Nombre, s.IdSolicitante)));
            cmbSolicitante.DataSource = solicitantes;

            List<ElementoLista> estados = new List<ElementoLista> { new ElementoLista("(Todos)", null) };
            foreach (CodigoEstado codigo in Enum.GetValues(typeof(CodigoEstado)))
            {
                estados.Add(new ElementoLista(EstadoRequisicion.Desde(codigo).Nombre, codigo));
            }
            cmbEstado.DataSource = estados;
        }

        private static void SeleccionarPorValor(ComboBox lista, object valor)
        {
            for (int i = 0; i < lista.Items.Count; i++)
            {
                ElementoLista elemento = lista.Items[i] as ElementoLista;
                if (elemento != null && Equals(elemento.Valor, valor))
                {
                    lista.SelectedIndex = i;
                    return;
                }
            }
        }

        // ---------- Búsqueda ----------

        private FiltroRequisiciones CrearFiltro()
        {
            return new FiltroRequisiciones
            {
                Codigo = txtCodigo.Text,
                IdSolicitante = cmbSolicitante.SelectedValue is int ? (int?)(int)cmbSolicitante.SelectedValue : null,
                FechaDesde = dtpDesde.Checked ? (DateTime?)dtpDesde.Value : null,
                FechaHasta = dtpHasta.Checked ? (DateTime?)dtpHasta.Value : null,
                Estado = cmbEstado.SelectedValue is CodigoEstado ? (CodigoEstado?)(CodigoEstado)cmbEstado.SelectedValue : null
            };
        }

        private void Buscar()
        {
            if (dtpDesde.Checked && dtpHasta.Checked && dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                Mensajes.Advertir(this, "La fecha inicial no puede ser posterior a la fecha final.");
                return;
            }

            try
            {
                resultados = servicioRequisiciones.Consultar(CrearFiltro());
            }
            catch (Exception ex)
            {
                Mensajes.MostrarError(this, ex);
                return;
            }
            MostrarResultados();
        }

        private void MostrarResultados()
        {
            dgvResultados.Rows.Clear();
            foreach (Requisicion requisicion in resultados)
            {
                int fila = dgvResultados.Rows.Add(
                    requisicion.Codigo,
                    requisicion.Fecha,
                    requisicion.NombreSolicitante,
                    requisicion.NombreDepartamento,
                    EstadoRequisicion.Desde(requisicion.EstadoActual).Nombre,
                    requisicion.Subtotal,
                    requisicion.Impuestos,
                    requisicion.Total);

                dgvResultados.Rows[fila].Tag = requisicion.IdRequisicion;
                dgvResultados.Rows[fila].Cells[colEstado.Index].Style.ForeColor = PaletaEstados.Fondo(requisicion.EstadoActual);
            }

            lblConteo.Text = resultados.Count == 1 ? "1 requisición encontrada" : resultados.Count + " requisiciones encontradas";
            ActualizarBotones();
        }

        private Requisicion ObtenerSeleccionada()
        {
            if (dgvResultados.CurrentRow == null || dgvResultados.CurrentRow.Tag == null)
            {
                return null;
            }
            int idRequisicion = (int)dgvResultados.CurrentRow.Tag;
            return resultados.FirstOrDefault(r => r.IdRequisicion == idRequisicion);
        }

        // Solo se habilita lo que la requisición seleccionada permite.
        private void ActualizarBotones()
        {
            Requisicion seleccionada = ObtenerSeleccionada();
            btnAbrir.Enabled = seleccionada != null;
            btnGenerarReporte.Enabled = seleccionada != null
                && EstadoRequisicion.Desde(seleccionada.EstadoActual).PermiteGenerarReporte;
        }

        // ---------- Acciones ----------

        private void AbrirRequisicion(int idRequisicion)
        {
            using (FrmRequisicion formulario = idRequisicion > 0 ? new FrmRequisicion(idRequisicion) : new FrmRequisicion())
            {
                formulario.ShowDialog(this);
            }
            Buscar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            cmbSolicitante.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            dtpDesde.Checked = false;
            dtpHasta.Checked = false;
            Buscar();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Requisicion seleccionada = ObtenerSeleccionada();
            if (seleccionada != null)
            {
                AbrirRequisicion(seleccionada.IdRequisicion);
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            AbrirRequisicion(0);
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            Requisicion seleccionada = ObtenerSeleccionada();
            if (seleccionada != null)
            {
                AperturaReporte.Mostrar(this, seleccionada.IdRequisicion);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnAbrir_Click(sender, e);
            }
        }

        private void dgvResultados_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarBotones();
        }
    }
}

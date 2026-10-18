using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaRequisiciones.Entidades;
using SistemaRequisiciones.Negocio.Servicios;

namespace SistemaRequisiciones.Presentacion
{
    // Catálogo de artículos: listar, agregar y modificar.
    public partial class FrmArticulos : Form
    {
        private readonly ServicioArticulos servicioArticulos = new ServicioArticulos();
        private List<Articulo> articulos = new List<Articulo>();
        private int idArticuloEnEdicion;   // 0 cuando se está registrando un artículo nuevo
        private bool cargando;

        public FrmArticulos()
        {
            InitializeComponent();
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            CargarArticulos(null);
        }

        // ---------- Lista ----------

        // Recarga la cuadrícula; si se indica un identificador, deja ese artículo seleccionado.
        private void CargarArticulos(int? idASeleccionar)
        {
            cargando = true;
            try
            {
                articulos = servicioArticulos.Listar(chkSoloActivos.Checked);

                dgvArticulos.Rows.Clear();
                foreach (Articulo articulo in articulos)
                {
                    int fila = dgvArticulos.Rows.Add(articulo.Codigo, articulo.Nombre,
                                                     articulo.PrecioReferencia, articulo.Activo ? "Sí" : "No");
                    dgvArticulos.Rows[fila].Tag = articulo.IdArticulo;
                }
            }
            catch (Exception ex)
            {
                Mensajes.MostrarError(this, ex);
            }
            finally
            {
                cargando = false;
            }

            Articulo seleccionado = idASeleccionar.HasValue ? articulos.Find(a => a.IdArticulo == idASeleccionar.Value) : null;
            if (seleccionado != null)
            {
                SeleccionarFila(seleccionado.IdArticulo);
                MostrarArticulo(seleccionado);
            }
            else
            {
                PrepararArticuloNuevo();
            }
        }

        private void SeleccionarFila(int idArticulo)
        {
            foreach (DataGridViewRow fila in dgvArticulos.Rows)
            {
                if ((int)fila.Tag == idArticulo)
                {
                    dgvArticulos.CurrentCell = fila.Cells[0];
                    fila.Selected = true;
                    return;
                }
            }
        }

        private Articulo ObtenerSeleccionado()
        {
            if (dgvArticulos.CurrentRow == null || dgvArticulos.CurrentRow.Tag == null)
            {
                return null;
            }
            int idArticulo = (int)dgvArticulos.CurrentRow.Tag;
            return articulos.Find(a => a.IdArticulo == idArticulo);
        }

        // ---------- Edición ----------

        private void MostrarArticulo(Articulo articulo)
        {
            idArticuloEnEdicion = articulo.IdArticulo;
            lblTituloEdicion.Text = "Modificar artículo";
            txtCodigo.Text = articulo.Codigo;
            txtNombre.Text = articulo.Nombre;
            nudPrecio.Value = Math.Min(Math.Max(articulo.PrecioReferencia, nudPrecio.Minimum), nudPrecio.Maximum);
            chkActivo.Checked = articulo.Activo;
            chkActivo.Enabled = true;
        }

        private void PrepararArticuloNuevo()
        {
            idArticuloEnEdicion = 0;
            lblTituloEdicion.Text = "Nuevo artículo";
            txtCodigo.Clear();
            txtNombre.Clear();
            nudPrecio.Value = nudPrecio.Minimum;
            chkActivo.Checked = true;
            chkActivo.Enabled = false;   // un artículo nuevo siempre queda activo
            dgvArticulos.CurrentCell = null;
            dgvArticulos.ClearSelection();
            txtCodigo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idGuardado = idArticuloEnEdicion;
                if (idArticuloEnEdicion == 0)
                {
                    idGuardado = servicioArticulos.Registrar(txtCodigo.Text, txtNombre.Text, nudPrecio.Value);
                    Mensajes.Informar(this, "El artículo se registró correctamente.");
                }
                else
                {
                    servicioArticulos.Modificar(idArticuloEnEdicion, txtCodigo.Text, txtNombre.Text,
                                                nudPrecio.Value, chkActivo.Checked);
                    Mensajes.Informar(this, "El artículo se actualizó correctamente.");
                }
                CargarArticulos(idGuardado);
            }
            catch (Exception ex)
            {
                Mensajes.MostrarError(this, ex);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PrepararArticuloNuevo();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (cargando)
            {
                return;
            }
            Articulo seleccionado = ObtenerSeleccionado();
            if (seleccionado != null)
            {
                MostrarArticulo(seleccionado);
            }
        }

        private void chkSoloActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (!cargando)
            {
                CargarArticulos(idArticuloEnEdicion > 0 ? (int?)idArticuloEnEdicion : null);
            }
        }
    }
}

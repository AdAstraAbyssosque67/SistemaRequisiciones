using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SistemaRequisiciones.Entidades;
using SistemaRequisiciones.Negocio.Estados;
using SistemaRequisiciones.Negocio.Servicios;

namespace SistemaRequisiciones.Presentacion
{
    // Pantalla de inicio: accesos rápidos, recordatorios, indicadores y requisiciones recientes.
    public partial class FrmPrincipal : Form
    {
        private const int CantidadRecientes = 8;

        private readonly ServicioRequisiciones servicioRequisiciones = new ServicioRequisiciones();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ActualizarPanel();
        }

        // ---------- Datos de la pantalla ----------

        private void ActualizarPanel()
        {
            try
            {
                List<Requisicion> todas = servicioRequisiciones.Consultar(null);
                ResumenRequisiciones resumen = servicioRequisiciones.CalcularResumen(todas);

                MostrarRecordatorios(resumen);
                MostrarIndicadores(resumen);
                MostrarResumenPorEstado(resumen);
                MostrarRecientes(todas);
            }
            catch (Exception ex)
            {
                Mensajes.MostrarError(this, ex);
            }
        }

        private void MostrarRecordatorios(ResumenRequisiciones resumen)
        {
            lblNumeroPendientes.Text = resumen.CantidadEn(CodigoEstado.EnRevision).ToString("N0");
            lblNumeroCreadas.Text = resumen.CantidadEn(CodigoEstado.Creada).ToString("N0");
        }

        private void MostrarIndicadores(ResumenRequisiciones resumen)
        {
            lblKpiTotalValor.Text = resumen.TotalRequisiciones.ToString("N0");
            lblKpiPendientesValor.Text = resumen.CantidadEn(CodigoEstado.EnRevision).ToString("N0");
            lblKpiMontoValor.Text = resumen.MontoAprobado.ToString("N2");
        }

        private void MostrarResumenPorEstado(ResumenRequisiciones resumen)
        {
            dgvResumen.Rows.Clear();
            foreach (ResumenEstado estado in resumen.PorEstado)
            {
                int fila = dgvResumen.Rows.Add(estado.Nombre, estado.Cantidad, estado.MontoTotal);
                dgvResumen.Rows[fila].Cells[colResumenEstado.Index].Style.ForeColor = PaletaEstados.Fondo(estado.Codigo);
            }
        }

        private void MostrarRecientes(List<Requisicion> todas)
        {
            dgvRecientes.Rows.Clear();
            foreach (Requisicion requisicion in todas.Take(CantidadRecientes))
            {
                int fila = dgvRecientes.Rows.Add(
                    requisicion.Codigo,
                    requisicion.Fecha,
                    requisicion.NombreSolicitante,
                    EstadoRequisicion.Desde(requisicion.EstadoActual).Nombre,
                    requisicion.Total);

                dgvRecientes.Rows[fila].Tag = requisicion.IdRequisicion;
                dgvRecientes.Rows[fila].Cells[colRecEstado.Index].Style.ForeColor = PaletaEstados.Fondo(requisicion.EstadoActual);
            }
        }

        // ---------- Navegación ----------

        private void AbrirRequisicion(int idRequisicion)
        {
            using (FrmRequisicion formulario = idRequisicion > 0 ? new FrmRequisicion(idRequisicion) : new FrmRequisicion())
            {
                formulario.ShowDialog(this);
            }
            ActualizarPanel();
        }

        private void AbrirConsulta(CodigoEstado? estadoInicial)
        {
            using (FrmConsultaRequisiciones formulario = new FrmConsultaRequisiciones(estadoInicial))
            {
                formulario.ShowDialog(this);
            }
            ActualizarPanel();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            ActualizarPanel();
        }

        private void NuevaRequisicion_Click(object sender, EventArgs e)
        {
            AbrirRequisicion(0);
        }

        private void Consulta_Click(object sender, EventArgs e)
        {
            AbrirConsulta(null);
        }

        private void Articulos_Click(object sender, EventArgs e)
        {
            using (FrmArticulos formulario = new FrmArticulos())
            {
                formulario.ShowDialog(this);
            }
        }

        // Los reportes solo existen para requisiciones aprobadas, así que se abre la consulta ya filtrada.
        private void Reportes_Click(object sender, EventArgs e)
        {
            AbrirConsulta(CodigoEstado.Aprobada);
        }

        private void linkPendientes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirConsulta(CodigoEstado.EnRevision);
        }

        private void linkCreadas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirConsulta(CodigoEstado.Creada);
        }

        private void dgvRecientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            AbrirRequisicion((int)dgvRecientes.Rows[e.RowIndex].Tag);
        }
    }
}

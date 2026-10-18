using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SistemaRequisiciones.Negocio.Servicios;

namespace SistemaRequisiciones.Presentacion
{
    // Muestra el reporte final de una requisición aprobada con ReportViewer.
    // Recibe solo el identificador; los datos los autoriza y entrega la capa de negocio.
    public partial class FrmReporteRequisicion : Form
    {
        private const string RecursoReporte = "SistemaRequisiciones.Presentacion.Reportes.RequisicionAprobada.rdlc";

        private readonly int idRequisicion;
        private DatosReporte datos;

        public FrmReporteRequisicion()
        {
            InitializeComponent();
        }

        public FrmReporteRequisicion(int idRequisicion) : this()
        {
            this.idRequisicion = idRequisicion;
        }

        // Pide los datos a la capa de negocio, que comprueba que la requisición esté Aprobada
        // y los lee de las vistas de SQL Server. Si no se cumple, lanza una excepción y el
        // formulario no llega a mostrarse.
        public void CargarDatos()
        {
            datos = new ServicioReportes().ObtenerDatosReporte(idRequisicion);
            lblCodigo.Text = Convert.ToString(datos.Cabecera.Rows[0]["CodigoRequisicion"]);
        }

        private void FrmReporteRequisicion_Load(object sender, EventArgs e)
        {
            if (datos == null)
            {
                Close();
                return;
            }

            try
            {
                // Los nombres de los orígenes de datos deben coincidir con los DataSet del archivo .rdlc.
                reportViewer.LocalReport.ReportEmbeddedResource = RecursoReporte;
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Cabecera", datos.Cabecera));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Detalle", datos.Detalle));

                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                Mensajes.MostrarError(this, ex);
                Close();
            }
        }
    }
}

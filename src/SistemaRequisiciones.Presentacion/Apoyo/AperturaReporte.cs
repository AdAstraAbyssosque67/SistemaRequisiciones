using System;
using System.Windows.Forms;

namespace SistemaRequisiciones.Presentacion
{
    // Punto único desde el que las pantallas piden el reporte final.
    internal static class AperturaReporte
    {
        // Si la requisición no está aprobada, o hay un error al leer las vistas,
        // se muestra el motivo y el formulario del reporte no se abre.
        public static void Mostrar(IWin32Window propietario, int idRequisicion)
        {
            try
            {
                using (FrmReporteRequisicion formulario = new FrmReporteRequisicion(idRequisicion))
                {
                    formulario.CargarDatos();
                    formulario.ShowDialog(propietario);
                }
            }
            catch (Exception ex)
            {
                Mensajes.MostrarError(propietario, ex);
            }
        }
    }
}

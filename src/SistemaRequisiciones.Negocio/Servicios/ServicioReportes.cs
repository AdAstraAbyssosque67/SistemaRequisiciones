using SistemaRequisiciones.Datos;
using SistemaRequisiciones.Entidades;
using SistemaRequisiciones.Negocio.Estados;
using SistemaRequisiciones.Negocio.Excepciones;

namespace SistemaRequisiciones.Negocio.Servicios
{
    // Autoriza y prepara los datos del reporte final.
    public class ServicioReportes
    {
        private readonly RequisicionDatos requisicionDatos = new RequisicionDatos();
        private readonly ReporteDatos reporteDatos = new ReporteDatos();

        // Solo entrega datos si la requisición está Aprobada. Además, las vistas de reporte
        // filtran por estado en SQL Server, así que hay dos controles independientes.
        public DatosReporte ObtenerDatosReporte(int idRequisicion)
        {
            Requisicion requisicion = ManejadorErroresDatos.Ejecutar(() => requisicionDatos.ObtenerPorId(idRequisicion));
            if (requisicion == null)
            {
                throw new ReglaNegocioException("La requisición solicitada no existe.");
            }

            EstadoRequisicion.Desde(requisicion.EstadoActual).ValidarQueSePuedeGenerarReporte();

            DatosReporte datos = ManejadorErroresDatos.Ejecutar(() => new DatosReporte(
                reporteDatos.ObtenerCabecera(idRequisicion),
                reporteDatos.ObtenerDetalle(idRequisicion)));

            if (datos.Cabecera.Rows.Count == 0)
            {
                throw new ReglaNegocioException("No se encontraron datos para generar el reporte de esta requisición.");
            }
            return datos;
        }
    }
}

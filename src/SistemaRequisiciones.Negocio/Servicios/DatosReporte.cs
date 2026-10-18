using System.Data;

namespace SistemaRequisiciones.Negocio.Servicios
{
    // Tablas que alimentan el reporte final, leídas de las vistas de SQL Server.
    public class DatosReporte
    {
        public DatosReporte(DataTable cabecera, DataTable detalle)
        {
            Cabecera = cabecera;
            Detalle = detalle;
        }

        public DataTable Cabecera { get; }
        public DataTable Detalle { get; }
    }
}

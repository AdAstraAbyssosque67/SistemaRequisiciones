using System.Data;

namespace SistemaRequisiciones.Datos
{
    // Datos del reporte final. Se leen exclusivamente de las vistas de reporte,
    // que solo devuelven requisiciones aprobadas.
    public class ReporteDatos
    {
        public DataTable ObtenerCabecera(int idRequisicion)
        {
            DataTable tabla = AccesoDatos.ConsultarTabla(
                "SELECT IdRequisicion, CodigoRequisicion, Fecha, Solicitante, Departamento, " +
                "Justificacion, Estado, Subtotal, Impuestos, Total " +
                "FROM dbo.vw_ReporteRequisicionCabecera WHERE IdRequisicion = @IdRequisicion",
                AccesoDatos.Entero("@IdRequisicion", idRequisicion));
            tabla.TableName = "Cabecera";
            return tabla;
        }

        public DataTable ObtenerDetalle(int idRequisicion)
        {
            DataTable tabla = AccesoDatos.ConsultarTabla(
                "SELECT IdRequisicion, CodigoRequisicion, CodigoArticulo, NombreArticulo, " +
                "Cantidad, PrecioUnitario, Importe " +
                "FROM dbo.vw_ReporteRequisicionDetalle WHERE IdRequisicion = @IdRequisicion " +
                "ORDER BY CodigoArticulo",
                AccesoDatos.Entero("@IdRequisicion", idRequisicion));
            tabla.TableName = "Detalle";
            return tabla;
        }
    }
}

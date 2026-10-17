using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using SistemaRequisiciones.Entidades;

namespace SistemaRequisiciones.Datos
{
    // Acceso a datos de las requisiciones. Toda escritura usa procedimientos almacenados;
    // las lecturas consultan vistas con parámetros.
    public class RequisicionDatos
    {
        private const string ConsultaCabecera =
            "SELECT IdRequisicion, CodigoRequisicion, Fecha, IdSolicitante, Solicitante, " +
            "IdDepartamento, Departamento, Justificacion, IdEstado, Subtotal, Impuestos, Total " +
            "FROM dbo.vw_ConsultaRequisiciones";

        private const string ConsultaDetalle =
            "SELECT IdArticulo, CodigoArticulo, NombreArticulo, Cantidad, PrecioUnitario, Importe " +
            "FROM dbo.vw_ConsultaDetalleRequisicion " +
            "WHERE IdRequisicion = @IdRequisicion ORDER BY IdDetalle";

        // Guarda la cabecera y los detalles en una sola transacción (dentro del procedimiento).
        // Si falla, se lanza ExcepcionDatos y la requisición no recibe id ni código.
        public void Crear(Requisicion requisicion)
        {
            SqlParameter idGenerado = AccesoDatos.Salida("@IdRequisicion", SqlDbType.Int, 0);
            SqlParameter codigoGenerado = AccesoDatos.Salida("@Codigo", SqlDbType.NVarChar, 20);

            AccesoDatos.EjecutarProcedimiento("dbo.usp_CrearRequisicion",
                AccesoDatos.Entero("@IdSolicitante", requisicion.IdSolicitante),
                AccesoDatos.Entero("@IdDepartamento", requisicion.IdDepartamento),
                AccesoDatos.Texto("@Justificacion", 500, requisicion.Justificacion),
                AccesoDatos.Monto("@Subtotal", requisicion.Subtotal),
                AccesoDatos.Monto("@Impuestos", requisicion.Impuestos),
                AccesoDatos.Monto("@Total", requisicion.Total),
                CrearParametroDetalles(requisicion.Detalles),
                idGenerado,
                codigoGenerado);

            requisicion.IdRequisicion = (int)idGenerado.Value;
            requisicion.Codigo = (string)codigoGenerado.Value;
        }

        // Reemplaza los datos de una requisición que sigue en estado Creada.
        public void Actualizar(Requisicion requisicion)
        {
            AccesoDatos.EjecutarProcedimiento("dbo.usp_ActualizarRequisicion",
                AccesoDatos.Entero("@IdRequisicion", requisicion.IdRequisicion),
                AccesoDatos.Entero("@IdSolicitante", requisicion.IdSolicitante),
                AccesoDatos.Entero("@IdDepartamento", requisicion.IdDepartamento),
                AccesoDatos.Texto("@Justificacion", 500, requisicion.Justificacion),
                AccesoDatos.Monto("@Subtotal", requisicion.Subtotal),
                AccesoDatos.Monto("@Impuestos", requisicion.Impuestos),
                AccesoDatos.Monto("@Total", requisicion.Total),
                CrearParametroDetalles(requisicion.Detalles));
        }

        // Solo guarda el cambio; la validación de la transición se hace en negocio y en SQL Server.
        public void CambiarEstado(int idRequisicion, CodigoEstado nuevoEstado)
        {
            SqlParameter estado = new SqlParameter("@IdEstadoNuevo", SqlDbType.TinyInt) { Value = (byte)nuevoEstado };

            AccesoDatos.EjecutarProcedimiento("dbo.usp_CambiarEstadoRequisicion",
                AccesoDatos.Entero("@IdRequisicion", idRequisicion),
                estado);
        }

        // Devuelve la requisición con sus detalles, o null si no existe.
        public Requisicion ObtenerPorId(int idRequisicion)
        {
            DataTable cabecera = AccesoDatos.ConsultarTabla(
                ConsultaCabecera + " WHERE IdRequisicion = @IdRequisicion",
                AccesoDatos.Entero("@IdRequisicion", idRequisicion));

            if (cabecera.Rows.Count == 0)
            {
                return null;
            }

            DataTable filasDetalle = AccesoDatos.ConsultarTabla(
                ConsultaDetalle,
                AccesoDatos.Entero("@IdRequisicion", idRequisicion));

            return MapearRequisicion(cabecera.Rows[0], MapearDetalles(filasDetalle));
        }

        // Lista requisiciones (sin detalles) aplicando solo los filtros indicados.
        public List<Requisicion> Consultar(FiltroRequisiciones filtro)
        {
            StringBuilder consulta = new StringBuilder(ConsultaCabecera + " WHERE 1 = 1");
            List<SqlParameter> parametros = new List<SqlParameter>();

            if (filtro != null)
            {
                AgregarFiltros(filtro, consulta, parametros);
            }
            consulta.Append(" ORDER BY Fecha DESC, IdRequisicion DESC");

            DataTable tabla = AccesoDatos.ConsultarTabla(consulta.ToString(), parametros.ToArray());

            List<Requisicion> requisiciones = new List<Requisicion>();
            foreach (DataRow fila in tabla.Rows)
            {
                requisiciones.Add(MapearRequisicion(fila, new List<DetalleRequisicion>()));
            }
            return requisiciones;
        }

        // Solo se agregan fragmentos fijos de SQL; los valores del usuario siempre van como parámetros.
        private static void AgregarFiltros(FiltroRequisiciones filtro, StringBuilder consulta, List<SqlParameter> parametros)
        {
            if (!string.IsNullOrWhiteSpace(filtro.Codigo))
            {
                consulta.Append(" AND CodigoRequisicion LIKE @Codigo");
                parametros.Add(AccesoDatos.Texto("@Codigo", 22, "%" + filtro.Codigo.Trim() + "%"));
            }
            if (filtro.IdSolicitante.HasValue)
            {
                consulta.Append(" AND IdSolicitante = @IdSolicitante");
                parametros.Add(AccesoDatos.Entero("@IdSolicitante", filtro.IdSolicitante.Value));
            }
            if (filtro.FechaDesde.HasValue)
            {
                consulta.Append(" AND Fecha >= @FechaDesde");
                parametros.Add(new SqlParameter("@FechaDesde", SqlDbType.DateTime2) { Value = filtro.FechaDesde.Value.Date });
            }
            if (filtro.FechaHasta.HasValue)
            {
                // Se incluye todo el día final.
                consulta.Append(" AND Fecha < @FechaHasta");
                parametros.Add(new SqlParameter("@FechaHasta", SqlDbType.DateTime2) { Value = filtro.FechaHasta.Value.Date.AddDays(1) });
            }
            if (filtro.Estado.HasValue)
            {
                consulta.Append(" AND IdEstado = @IdEstado");
                parametros.Add(new SqlParameter("@IdEstado", SqlDbType.TinyInt) { Value = (byte)filtro.Estado.Value });
            }
        }

        // Prepara los detalles como parámetro de tabla (tipo dbo.TipoDetalleRequisicion).
        private static SqlParameter CrearParametroDetalles(IEnumerable<DetalleRequisicion> detalles)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("IdArticulo", typeof(int));
            tabla.Columns.Add("Cantidad", typeof(int));
            tabla.Columns.Add("PrecioUnitario", typeof(decimal));

            foreach (DetalleRequisicion detalle in detalles)
            {
                tabla.Rows.Add(detalle.IdArticulo, detalle.Cantidad, detalle.PrecioUnitario);
            }

            SqlParameter parametro = new SqlParameter("@Detalles", SqlDbType.Structured);
            parametro.TypeName = "dbo.TipoDetalleRequisicion";
            parametro.Value = tabla;
            return parametro;
        }

        private static List<DetalleRequisicion> MapearDetalles(DataTable tabla)
        {
            List<DetalleRequisicion> detalles = new List<DetalleRequisicion>();
            foreach (DataRow fila in tabla.Rows)
            {
                detalles.Add(new DetalleRequisicion(
                    Convert.ToInt32(fila["IdArticulo"]),
                    Convert.ToString(fila["CodigoArticulo"]),
                    Convert.ToString(fila["NombreArticulo"]),
                    Convert.ToInt32(fila["Cantidad"]),
                    Convert.ToDecimal(fila["PrecioUnitario"]),
                    Convert.ToDecimal(fila["Importe"])));
            }
            return detalles;
        }

        private static Requisicion MapearRequisicion(DataRow fila, IEnumerable<DetalleRequisicion> detalles)
        {
            return new Requisicion(
                Convert.ToInt32(fila["IdRequisicion"]),
                Convert.ToString(fila["CodigoRequisicion"]),
                Convert.ToDateTime(fila["Fecha"]),
                Convert.ToInt32(fila["IdSolicitante"]),
                Convert.ToString(fila["Solicitante"]),
                Convert.ToInt32(fila["IdDepartamento"]),
                Convert.ToString(fila["Departamento"]),
                Convert.ToString(fila["Justificacion"]),
                (CodigoEstado)Convert.ToByte(fila["IdEstado"]),
                Convert.ToDecimal(fila["Subtotal"]),
                Convert.ToDecimal(fila["Impuestos"]),
                Convert.ToDecimal(fila["Total"]),
                detalles);
        }
    }
}

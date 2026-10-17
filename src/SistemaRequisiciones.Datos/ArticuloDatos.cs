using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SistemaRequisiciones.Entidades;

namespace SistemaRequisiciones.Datos
{
    // Acceso al catálogo de artículos.
    public class ArticuloDatos
    {
        private const string ConsultaBase =
            "SELECT IdArticulo, Codigo, Nombre, PrecioReferencia, Activo FROM dbo.Articulos";

        public List<Articulo> Listar(bool soloActivos)
        {
            string consulta = ConsultaBase + (soloActivos ? " WHERE Activo = 1" : string.Empty) + " ORDER BY Codigo";
            DataTable tabla = AccesoDatos.ConsultarTabla(consulta);

            List<Articulo> articulos = new List<Articulo>();
            foreach (DataRow fila in tabla.Rows)
            {
                articulos.Add(MapearArticulo(fila));
            }
            return articulos;
        }

        // Devuelve el artículo o null si no existe.
        public Articulo ObtenerPorId(int idArticulo)
        {
            DataTable tabla = AccesoDatos.ConsultarTabla(
                ConsultaBase + " WHERE IdArticulo = @IdArticulo",
                AccesoDatos.Entero("@IdArticulo", idArticulo));

            return tabla.Rows.Count == 0 ? null : MapearArticulo(tabla.Rows[0]);
        }

        // Registra un artículo nuevo y devuelve el identificador asignado.
        public int Registrar(Articulo articulo)
        {
            SqlParameter idGenerado = AccesoDatos.Salida("@IdArticulo", SqlDbType.Int, 0);

            AccesoDatos.EjecutarProcedimiento("dbo.usp_RegistrarArticulo",
                AccesoDatos.Texto("@Codigo", 20, articulo.Codigo),
                AccesoDatos.Texto("@Nombre", 150, articulo.Nombre),
                AccesoDatos.Monto("@PrecioReferencia", articulo.PrecioReferencia),
                idGenerado);

            return (int)idGenerado.Value;
        }

        public void Modificar(Articulo articulo)
        {
            AccesoDatos.EjecutarProcedimiento("dbo.usp_ModificarArticulo",
                AccesoDatos.Entero("@IdArticulo", articulo.IdArticulo),
                AccesoDatos.Texto("@Codigo", 20, articulo.Codigo),
                AccesoDatos.Texto("@Nombre", 150, articulo.Nombre),
                AccesoDatos.Monto("@PrecioReferencia", articulo.PrecioReferencia),
                AccesoDatos.Logico("@Activo", articulo.Activo));
        }

        private static Articulo MapearArticulo(DataRow fila)
        {
            return new Articulo(
                Convert.ToInt32(fila["IdArticulo"]),
                Convert.ToString(fila["Codigo"]),
                Convert.ToString(fila["Nombre"]),
                Convert.ToDecimal(fila["PrecioReferencia"]),
                Convert.ToBoolean(fila["Activo"]));
        }
    }
}

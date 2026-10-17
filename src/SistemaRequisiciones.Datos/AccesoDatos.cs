using System;
using System.Data;
using System.Data.SqlClient;
using SistemaRequisiciones.Entidades;

namespace SistemaRequisiciones.Datos
{
    // Operaciones comunes de acceso a SQL Server. Cada llamada abre su propia conexión
    // y la cierra con using; ADO.NET reutiliza las conexiones con su pool.
    internal static class AccesoDatos
    {
        private static SqlConnection CrearConexion()
        {
            return new SqlConnection(ConfiguracionAplicacion.Instancia.CadenaConexion);
        }

        // Ejecuta un procedimiento almacenado. Quien llama conserva los parámetros,
        // así puede leer los de salida cuando termina.
        public static void EjecutarProcedimiento(string nombreProcedimiento, params SqlParameter[] parametros)
        {
            try
            {
                using (SqlConnection conexion = CrearConexion())
                using (SqlCommand comando = new SqlCommand(nombreProcedimiento, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddRange(parametros);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw ConvertirExcepcion(ex);
            }
        }

        // Ejecuta una consulta de lectura con parámetros y devuelve sus filas.
        public static DataTable ConsultarTabla(string consulta, params SqlParameter[] parametros)
        {
            try
            {
                using (SqlConnection conexion = CrearConexion())
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    comando.Parameters.AddRange(parametros);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
            catch (SqlException ex)
            {
                throw ConvertirExcepcion(ex);
            }
        }

        public static SqlParameter Entero(string nombre, int valor)
        {
            return new SqlParameter(nombre, SqlDbType.Int) { Value = valor };
        }

        public static SqlParameter Texto(string nombre, int tamano, string valor)
        {
            return new SqlParameter(nombre, SqlDbType.NVarChar, tamano) { Value = (object)valor ?? DBNull.Value };
        }

        // Los montos se envían con la misma precisión que tienen las columnas DECIMAL(18,2).
        public static SqlParameter Monto(string nombre, decimal valor)
        {
            return new SqlParameter(nombre, SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = valor };
        }

        public static SqlParameter Logico(string nombre, bool valor)
        {
            return new SqlParameter(nombre, SqlDbType.Bit) { Value = valor };
        }

        public static SqlParameter Salida(string nombre, SqlDbType tipo, int tamano)
        {
            SqlParameter parametro = new SqlParameter(nombre, tipo, tamano);
            parametro.Direction = ParameterDirection.Output;
            return parametro;
        }

        // Los errores desde 50000 los lanza THROW dentro de los procedimientos, con mensajes
        // pensados para el usuario. Cualquier otro error se informa de forma genérica y el
        // detalle técnico queda en la excepción interna.
        private static ExcepcionDatos ConvertirExcepcion(SqlException ex)
        {
            if (ex.Number >= 50000)
            {
                return new ExcepcionDatos(ex.Message, true, ex);
            }
            return new ExcepcionDatos(
                "No se pudo completar la operación en la base de datos. Verifique la conexión e inténtelo de nuevo.",
                false, ex);
        }
    }
}

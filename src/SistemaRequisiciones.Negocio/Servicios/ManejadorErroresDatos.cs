using System;
using SistemaRequisiciones.Datos;
using SistemaRequisiciones.Negocio.Excepciones;

namespace SistemaRequisiciones.Negocio.Servicios
{
    // Traduce los errores de la capa de datos a excepciones de negocio, para que la capa
    // de presentación solo conozca excepciones de esta capa.
    internal static class ManejadorErroresDatos
    {
        public static T Ejecutar<T>(Func<T> operacion)
        {
            try
            {
                return operacion();
            }
            catch (ExcepcionDatos ex)
            {
                if (ex.EsErrorDeNegocio)
                {
                    throw new ReglaNegocioException(ex.Message);
                }
                throw new OperacionFallidaException(ex.Message, ex);
            }
        }

        public static void Ejecutar(Action operacion)
        {
            Ejecutar<object>(() =>
            {
                operacion();
                return null;
            });
        }
    }
}

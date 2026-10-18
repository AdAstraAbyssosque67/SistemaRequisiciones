using System;

namespace SistemaRequisiciones.Negocio.Excepciones
{
    // Error técnico (conexión, base de datos no disponible, etc.). El mensaje es apto
    // para el usuario y el detalle técnico queda en la excepción interna.
    public class OperacionFallidaException : Exception
    {
        public OperacionFallidaException(string mensaje, Exception causa) : base(mensaje, causa)
        {
        }
    }
}

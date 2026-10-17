using System;

namespace SistemaRequisiciones.Negocio.Excepciones
{
    // Se lanza cuando se incumple una regla de negocio. El mensaje está pensado
    // para mostrarse tal cual al usuario.
    public class ReglaNegocioException : Exception
    {
        public ReglaNegocioException(string mensaje) : base(mensaje)
        {
        }
    }
}

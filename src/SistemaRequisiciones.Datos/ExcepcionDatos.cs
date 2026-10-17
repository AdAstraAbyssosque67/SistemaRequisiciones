using System;

namespace SistemaRequisiciones.Datos
{
    // Error controlado de la capa de datos. Si EsErrorDeNegocio es verdadero, el mensaje
    // viene de una regla validada por SQL Server y se puede mostrar al usuario.
    public class ExcepcionDatos : Exception
    {
        public ExcepcionDatos(string mensaje, bool esErrorDeNegocio, Exception causa)
            : base(mensaje, causa)
        {
            EsErrorDeNegocio = esErrorDeNegocio;
        }

        public bool EsErrorDeNegocio { get; }
    }
}

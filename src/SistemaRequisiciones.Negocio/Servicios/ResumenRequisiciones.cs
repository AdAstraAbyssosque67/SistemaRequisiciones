using System.Collections.Generic;
using System.Linq;
using SistemaRequisiciones.Entidades;

namespace SistemaRequisiciones.Negocio.Servicios
{
    // Cantidad y monto de las requisiciones que están en un mismo estado.
    public class ResumenEstado
    {
        public ResumenEstado(CodigoEstado codigo, string nombre, int cantidad, decimal montoTotal)
        {
            Codigo = codigo;
            Nombre = nombre;
            Cantidad = cantidad;
            MontoTotal = montoTotal;
        }

        public CodigoEstado Codigo { get; }
        public string Nombre { get; }
        public int Cantidad { get; }
        public decimal MontoTotal { get; }
    }

    // Indicadores que muestra la pantalla de inicio.
    public class ResumenRequisiciones
    {
        public ResumenRequisiciones(IReadOnlyList<ResumenEstado> porEstado)
        {
            PorEstado = porEstado;
        }

        public IReadOnlyList<ResumenEstado> PorEstado { get; }

        public int TotalRequisiciones
        {
            get { return PorEstado.Sum(e => e.Cantidad); }
        }

        public int CantidadEn(CodigoEstado codigo)
        {
            return PorEstado.Where(e => e.Codigo == codigo).Sum(e => e.Cantidad);
        }

        public decimal MontoAprobado
        {
            get { return PorEstado.Where(e => e.Codigo == CodigoEstado.Aprobada).Sum(e => e.MontoTotal); }
        }
    }
}

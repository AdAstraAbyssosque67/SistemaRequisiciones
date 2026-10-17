using System;
using System.Collections.Generic;
using System.Linq;
using SistemaRequisiciones.Negocio.Estrategias;

namespace SistemaRequisiciones.Negocio.Servicios
{
    // Centraliza el cálculo de importes, subtotal, impuestos y total.
    // El impuesto lo decide la estrategia recibida, así que cambiar de política
    // no obliga a modificar esta clase.
    public class ServicioCalculoMontos
    {
        private readonly IEstrategiaImpuesto estrategiaImpuesto;

        public ServicioCalculoMontos(IEstrategiaImpuesto estrategiaImpuesto)
        {
            if (estrategiaImpuesto == null)
            {
                throw new ArgumentNullException("estrategiaImpuesto");
            }
            this.estrategiaImpuesto = estrategiaImpuesto;
        }

        public string NombrePoliticaImpuesto
        {
            get { return estrategiaImpuesto.Nombre; }
        }

        // Importe de un artículo: cantidad por precio unitario.
        public decimal CalcularImporte(int cantidad, decimal precioUnitario)
        {
            return Math.Round(cantidad * precioUnitario, 2, MidpointRounding.AwayFromZero);
        }

        // Subtotal es la suma de los importes; el total es el subtotal más los impuestos.
        public MontosRequisicion CalcularMontos(IEnumerable<decimal> importes)
        {
            decimal subtotal = importes.Sum();
            decimal impuestos = estrategiaImpuesto.CalcularImpuesto(subtotal);
            return new MontosRequisicion(subtotal, impuestos, subtotal + impuestos);
        }
    }
}

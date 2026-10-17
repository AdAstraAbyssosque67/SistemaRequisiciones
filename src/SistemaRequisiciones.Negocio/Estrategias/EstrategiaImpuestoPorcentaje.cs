using System;
using System.Globalization;

namespace SistemaRequisiciones.Negocio.Estrategias
{
    // Aplica una tasa porcentual fija sobre el subtotal. La tasa se recibe como fracción (0.18 = 18 %).
    public class EstrategiaImpuestoPorcentaje : IEstrategiaImpuesto
    {
        private readonly decimal tasa;

        public EstrategiaImpuestoPorcentaje(decimal tasa)
        {
            if (tasa < 0m || tasa > 1m)
            {
                throw new ArgumentOutOfRangeException("tasa", "La tasa debe estar entre 0 y 1.");
            }
            this.tasa = tasa;
        }

        public string Nombre
        {
            get { return "Impuesto del " + (tasa * 100m).ToString("0.##", CultureInfo.CurrentCulture) + " %"; }
        }

        public decimal CalcularImpuesto(decimal subtotal)
        {
            return Math.Round(subtotal * tasa, 2, MidpointRounding.AwayFromZero);
        }
    }
}

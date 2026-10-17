namespace SistemaRequisiciones.Negocio.Estrategias
{
    // Política sin impuestos. Sirve para demostrar que la política se puede sustituir
    // sin tocar el cálculo de la requisición.
    public class EstrategiaImpuestoExento : IEstrategiaImpuesto
    {
        public string Nombre
        {
            get { return "Exento de impuestos"; }
        }

        public decimal CalcularImpuesto(decimal subtotal)
        {
            return 0m;
        }
    }
}

namespace SistemaRequisiciones.Negocio.Estrategias
{
    // Política tributaria intercambiable (patrón Strategy).
    public interface IEstrategiaImpuesto
    {
        string Nombre { get; }

        // Devuelve el impuesto que corresponde a un subtotal.
        decimal CalcularImpuesto(decimal subtotal);
    }
}

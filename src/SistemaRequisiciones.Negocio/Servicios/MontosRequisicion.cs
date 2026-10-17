namespace SistemaRequisiciones.Negocio.Servicios
{
    // Resultado del cálculo de una requisición.
    public class MontosRequisicion
    {
        public MontosRequisicion(decimal subtotal, decimal impuestos, decimal total)
        {
            Subtotal = subtotal;
            Impuestos = impuestos;
            Total = total;
        }

        public decimal Subtotal { get; }
        public decimal Impuestos { get; }
        public decimal Total { get; }
    }
}

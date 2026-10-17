namespace SistemaRequisiciones.Entidades
{
    // Línea de una requisición. Solo las capas Datos y Negocio pueden crearla.
    public class DetalleRequisicion
    {
        internal DetalleRequisicion(int idArticulo, string codigoArticulo, string nombreArticulo,
                                    int cantidad, decimal precioUnitario, decimal importe)
        {
            IdArticulo = idArticulo;
            CodigoArticulo = codigoArticulo;
            NombreArticulo = nombreArticulo;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Importe = importe;
        }

        public int IdArticulo { get; }
        public string CodigoArticulo { get; }
        public string NombreArticulo { get; }
        public int Cantidad { get; }
        public decimal PrecioUnitario { get; }
        public decimal Importe { get; }
    }
}

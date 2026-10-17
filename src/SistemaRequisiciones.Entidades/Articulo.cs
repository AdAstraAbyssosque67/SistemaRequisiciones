namespace SistemaRequisiciones.Entidades
{
    // Artículo del catálogo. Es inmutable: para cambiar un dato se crea otro objeto.
    public class Articulo
    {
        public Articulo(int idArticulo, string codigo, string nombre, decimal precioReferencia, bool activo)
        {
            IdArticulo = idArticulo;
            Codigo = codigo;
            Nombre = nombre;
            PrecioReferencia = precioReferencia;
            Activo = activo;
        }

        public int IdArticulo { get; }
        public string Codigo { get; }
        public string Nombre { get; }
        public decimal PrecioReferencia { get; }
        public bool Activo { get; }

        // Texto que se muestra en las listas desplegables.
        public string Descripcion => Codigo + " - " + Nombre;
    }
}

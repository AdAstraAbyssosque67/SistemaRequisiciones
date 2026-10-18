namespace SistemaRequisiciones.Presentacion
{
    // Elemento de una lista desplegable con texto visible y un valor asociado
    // (se usa en los filtros, donde la primera opción es "Todos" y su valor es null).
    internal class ElementoLista
    {
        public ElementoLista(string texto, object valor)
        {
            Texto = texto;
            Valor = valor;
        }

        public string Texto { get; }
        public object Valor { get; }
    }
}

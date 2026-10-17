namespace SistemaRequisiciones.Entidades
{
    public class Departamento
    {
        public Departamento(int idDepartamento, string nombre)
        {
            IdDepartamento = idDepartamento;
            Nombre = nombre;
        }

        public int IdDepartamento { get; }
        public string Nombre { get; }
    }
}

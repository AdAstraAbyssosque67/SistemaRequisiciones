namespace SistemaRequisiciones.Entidades
{
    public class Solicitante
    {
        public Solicitante(int idSolicitante, string nombre, int idDepartamento)
        {
            IdSolicitante = idSolicitante;
            Nombre = nombre;
            IdDepartamento = idDepartamento;
        }

        public int IdSolicitante { get; }
        public string Nombre { get; }

        // Departamento al que pertenece; se propone al elegir el solicitante.
        public int IdDepartamento { get; }
    }
}

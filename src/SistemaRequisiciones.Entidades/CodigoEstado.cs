namespace SistemaRequisiciones.Entidades
{
    // Los valores coinciden con la columna IdEstado de la tabla Estados.
    public enum CodigoEstado : byte
    {
        Creada = 1,
        EnRevision = 2,
        Aprobada = 3,
        Rechazada = 4,
        Cancelada = 5
    }
}

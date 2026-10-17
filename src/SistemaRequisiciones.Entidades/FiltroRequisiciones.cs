using System;

namespace SistemaRequisiciones.Entidades
{
    // Criterios del formulario de consulta. Los que quedan en null no se aplican.
    public class FiltroRequisiciones
    {
        public string Codigo { get; set; }
        public int? IdSolicitante { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public CodigoEstado? Estado { get; set; }
    }
}

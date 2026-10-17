using SistemaRequisiciones.Entidades;

namespace SistemaRequisiciones.Negocio.Estados
{
    public class EstadoEnRevision : EstadoRequisicion
    {
        public override CodigoEstado Codigo
        {
            get { return CodigoEstado.EnRevision; }
        }

        public override string Nombre
        {
            get { return "En Revisión"; }
        }

        public override bool PermiteModificar
        {
            get { return false; }
        }

        protected override CodigoEstado[] Destinos
        {
            get { return new CodigoEstado[] { CodigoEstado.Aprobada, CodigoEstado.Rechazada, CodigoEstado.Cancelada }; }
        }
    }
}

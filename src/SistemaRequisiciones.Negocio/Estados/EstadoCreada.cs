using SistemaRequisiciones.Entidades;

namespace SistemaRequisiciones.Negocio.Estados
{
    public class EstadoCreada : EstadoRequisicion
    {
        public override CodigoEstado Codigo
        {
            get { return CodigoEstado.Creada; }
        }

        public override string Nombre
        {
            get { return "Creada"; }
        }

        public override bool PermiteModificar
        {
            get { return true; }
        }

        protected override CodigoEstado[] Destinos
        {
            get { return new CodigoEstado[] { CodigoEstado.EnRevision, CodigoEstado.Cancelada }; }
        }
    }
}

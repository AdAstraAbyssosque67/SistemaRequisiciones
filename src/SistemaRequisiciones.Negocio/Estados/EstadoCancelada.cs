using SistemaRequisiciones.Entidades;

namespace SistemaRequisiciones.Negocio.Estados
{
    public class EstadoCancelada : EstadoRequisicion
    {
        public override CodigoEstado Codigo
        {
            get { return CodigoEstado.Cancelada; }
        }

        public override string Nombre
        {
            get { return "Cancelada"; }
        }

        public override bool PermiteModificar
        {
            get { return false; }
        }

        protected override CodigoEstado[] Destinos
        {
            get { return new CodigoEstado[0]; }
        }
    }
}

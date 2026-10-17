using SistemaRequisiciones.Entidades;

namespace SistemaRequisiciones.Negocio.Estados
{
    public class EstadoRechazada : EstadoRequisicion
    {
        public override CodigoEstado Codigo
        {
            get { return CodigoEstado.Rechazada; }
        }

        public override string Nombre
        {
            get { return "Rechazada"; }
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

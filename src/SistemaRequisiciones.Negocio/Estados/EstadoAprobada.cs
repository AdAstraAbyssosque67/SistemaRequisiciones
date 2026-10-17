using SistemaRequisiciones.Entidades;

namespace SistemaRequisiciones.Negocio.Estados
{
    public class EstadoAprobada : EstadoRequisicion
    {
        public override CodigoEstado Codigo
        {
            get { return CodigoEstado.Aprobada; }
        }

        public override string Nombre
        {
            get { return "Aprobada"; }
        }

        public override bool PermiteModificar
        {
            get { return false; }
        }

        public override bool PermiteGenerarReporte
        {
            get { return true; }
        }

        protected override CodigoEstado[] Destinos
        {
            get { return new CodigoEstado[0]; }
        }
    }
}

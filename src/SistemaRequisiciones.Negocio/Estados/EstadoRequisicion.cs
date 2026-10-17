using System;
using System.Linq;
using SistemaRequisiciones.Entidades;
using SistemaRequisiciones.Negocio.Excepciones;

namespace SistemaRequisiciones.Negocio.Estados
{
    // Estado base (patrón State). Cada estado concreto declara a qué estados puede pasar
    // y si permite modificar la requisición; las reglas de transición se aplican aquí,
    // en un solo lugar, y no en los formularios.
    public abstract class EstadoRequisicion
    {
        public abstract CodigoEstado Codigo { get; }
        public abstract string Nombre { get; }
        public abstract bool PermiteModificar { get; }

        // Solo la requisición aprobada puede generar el reporte final.
        public virtual bool PermiteGenerarReporte
        {
            get { return false; }
        }

        // Estados a los que se puede pasar desde este estado.
        protected abstract CodigoEstado[] Destinos { get; }

        public bool PuedeIrA(CodigoEstado destino)
        {
            return Destinos.Contains(destino);
        }

        public EstadoRequisicion EnviarARevision()
        {
            return CambiarA(CodigoEstado.EnRevision, "enviar a revisión");
        }

        public EstadoRequisicion Aprobar()
        {
            return CambiarA(CodigoEstado.Aprobada, "aprobar");
        }

        public EstadoRequisicion Rechazar()
        {
            return CambiarA(CodigoEstado.Rechazada, "rechazar");
        }

        public EstadoRequisicion Cancelar()
        {
            return CambiarA(CodigoEstado.Cancelada, "cancelar");
        }

        public void ValidarQueSePuedeModificar()
        {
            if (!PermiteModificar)
            {
                throw new ReglaNegocioException(
                    "No se puede modificar una requisición en estado " + Nombre + ".");
            }
        }

        public void ValidarQueSePuedeGenerarReporte()
        {
            if (!PermiteGenerarReporte)
            {
                throw new ReglaNegocioException(
                    "El reporte final solo se puede generar para requisiciones aprobadas. Estado actual: " + Nombre + ".");
            }
        }

        // Convierte el código guardado en la base de datos en el objeto de estado correspondiente.
        public static EstadoRequisicion Desde(CodigoEstado codigo)
        {
            switch (codigo)
            {
                case CodigoEstado.Creada: return new EstadoCreada();
                case CodigoEstado.EnRevision: return new EstadoEnRevision();
                case CodigoEstado.Aprobada: return new EstadoAprobada();
                case CodigoEstado.Rechazada: return new EstadoRechazada();
                case CodigoEstado.Cancelada: return new EstadoCancelada();
                default:
                    throw new ArgumentOutOfRangeException("codigo", "El estado indicado no existe.");
            }
        }

        // Verifica que la transición esté permitida y devuelve el nuevo estado.
        private EstadoRequisicion CambiarA(CodigoEstado destino, string accion)
        {
            if (!PuedeIrA(destino))
            {
                throw new ReglaNegocioException(ConstruirMensajeTransicion(accion));
            }
            return Desde(destino);
        }

        private string ConstruirMensajeTransicion(string accion)
        {
            string mensaje = "No se puede " + accion + " una requisición en estado " + Nombre + ". ";
            if (Destinos.Length == 0)
            {
                return mensaje + "Es un estado final y la requisición ya no puede cambiar.";
            }
            string permitidos = string.Join(", ", Destinos.Select(d => Desde(d).Nombre));
            return mensaje + "Desde este estado solo se puede pasar a: " + permitidos + ".";
        }
    }
}

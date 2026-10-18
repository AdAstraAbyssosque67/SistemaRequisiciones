using System.Drawing;
using SistemaRequisiciones.Entidades;

namespace SistemaRequisiciones.Presentacion
{
    // Color asociado a cada estado, para que se reconozcan igual en todas las pantallas.
    internal static class PaletaEstados
    {
        public static readonly Color Nueva = Color.FromArgb(150, 158, 170);

        public static Color Fondo(CodigoEstado estado)
        {
            switch (estado)
            {
                case CodigoEstado.Creada: return Color.FromArgb(88, 130, 190);
                case CodigoEstado.EnRevision: return Color.FromArgb(214, 140, 20);
                case CodigoEstado.Aprobada: return Color.FromArgb(62, 150, 86);
                case CodigoEstado.Rechazada: return Color.FromArgb(190, 70, 70);
                default: return Color.FromArgb(120, 128, 140);
            }
        }
    }
}

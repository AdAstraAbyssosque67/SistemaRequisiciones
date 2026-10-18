using System;
using System.Windows.Forms;
using SistemaRequisiciones.Negocio.Excepciones;

namespace SistemaRequisiciones.Presentacion
{
    // Cuadros de mensaje con el mismo título y estilo en toda la aplicación.
    internal static class Mensajes
    {
        private const string Titulo = "Sistema de Requisiciones";

        public static void Informar(IWin32Window propietario, string mensaje)
        {
            MessageBox.Show(propietario, mensaje, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Advertir(IWin32Window propietario, string mensaje)
        {
            MessageBox.Show(propietario, mensaje, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Pregunta de sí o no; la respuesta predeterminada es No.
        public static bool Confirmar(IWin32Window propietario, string mensaje)
        {
            DialogResult respuesta = MessageBox.Show(propietario, mensaje, Titulo,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            return respuesta == DialogResult.Yes;
        }

        // Las reglas de negocio se muestran como advertencia; los errores técnicos, como error.
        public static void MostrarError(IWin32Window propietario, Exception ex)
        {
            if (ex is ReglaNegocioException)
            {
                Advertir(propietario, ex.Message);
            }
            else if (ex is OperacionFallidaException)
            {
                MessageBox.Show(propietario, ex.Message, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(propietario, "Ocurrió un error inesperado: " + ex.Message,
                                Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

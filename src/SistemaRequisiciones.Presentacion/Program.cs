using System;
using System.Configuration;
using System.Windows.Forms;
using SistemaRequisiciones.Entidades;

namespace SistemaRequisiciones.Presentacion
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!ConfiguracionEsValida())
            {
                return;
            }
            Application.Run(new FrmPrincipal());
        }

        // Lee la configuración al iniciar para avisar de errores en App.config antes de abrir ventanas.
        private static bool ConfiguracionEsValida()
        {
            try
            {
                return ConfiguracionAplicacion.Instancia.TasaImpuesto >= 0m;
            }
            catch (ConfigurationErrorsException ex)
            {
                MessageBox.Show("No se pudo leer la configuración de la aplicación (App.config):\n\n" + ex.Message,
                                "Sistema de Requisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

using System;
using System.Configuration;
using System.Globalization;

namespace SistemaRequisiciones.Entidades
{
    // Singleton que lee una sola vez la configuración de App.config (cadena de conexión
    // y tasa de impuesto) y la comparte con las capas de datos y negocio.
    // No guarda ninguna SqlConnection: cada operación abre y cierra la suya.
    public sealed class ConfiguracionAplicacion
    {
        private const string NombreCadenaConexion = "SistemaRequisiciones";
        private const string ClaveTasaImpuesto = "TasaImpuesto";

        // Lazy garantiza una única instancia incluso si varios hilos la piden a la vez.
        private static readonly Lazy<ConfiguracionAplicacion> instanciaUnica =
            new Lazy<ConfiguracionAplicacion>(() => new ConfiguracionAplicacion());

        private ConfiguracionAplicacion()
        {
            CadenaConexion = LeerCadenaConexion();
            TasaImpuesto = LeerTasaImpuesto();
        }

        public static ConfiguracionAplicacion Instancia => instanciaUnica.Value;

        public string CadenaConexion { get; }

        // Tasa como fracción: 0.18 equivale a 18 %.
        public decimal TasaImpuesto { get; }

        private static string LeerCadenaConexion()
        {
            ConnectionStringSettings valor = ConfigurationManager.ConnectionStrings[NombreCadenaConexion];
            if (valor == null || string.IsNullOrWhiteSpace(valor.ConnectionString))
            {
                throw new ConfigurationErrorsException(
                    "No se encontró la cadena de conexión '" + NombreCadenaConexion + "' en App.config.");
            }
            return valor.ConnectionString;
        }

        private static decimal LeerTasaImpuesto()
        {
            string texto = ConfigurationManager.AppSettings[ClaveTasaImpuesto];
            decimal tasa;
            bool valida = decimal.TryParse(texto, NumberStyles.Number, CultureInfo.InvariantCulture, out tasa);
            if (!valida || tasa < 0m || tasa > 1m)
            {
                throw new ConfigurationErrorsException(
                    "La clave '" + ClaveTasaImpuesto + "' de App.config debe ser un número entre 0 y 1 (por ejemplo 0.18).");
            }
            return tasa;
        }
    }
}

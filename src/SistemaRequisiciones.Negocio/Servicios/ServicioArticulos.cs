using System.Collections.Generic;
using SistemaRequisiciones.Datos;
using SistemaRequisiciones.Entidades;
using SistemaRequisiciones.Negocio.Excepciones;

namespace SistemaRequisiciones.Negocio.Servicios
{
    // Reglas del catálogo de artículos.
    public class ServicioArticulos
    {
        private const int LongitudMaximaCodigo = 20;
        private const int LongitudMaximaNombre = 150;

        private readonly ArticuloDatos articuloDatos = new ArticuloDatos();

        public List<Articulo> Listar(bool soloActivos)
        {
            return ManejadorErroresDatos.Ejecutar(() => articuloDatos.Listar(soloActivos));
        }

        // Registra un artículo nuevo (queda activo) y devuelve su identificador.
        public int Registrar(string codigo, string nombre, decimal precioReferencia)
        {
            Articulo articulo = CrearArticuloValido(0, codigo, nombre, precioReferencia, true);
            return ManejadorErroresDatos.Ejecutar(() => articuloDatos.Registrar(articulo));
        }

        public void Modificar(int idArticulo, string codigo, string nombre, decimal precioReferencia, bool activo)
        {
            if (idArticulo <= 0)
            {
                throw new ReglaNegocioException("Debe seleccionar el artículo que desea modificar.");
            }
            Articulo articulo = CrearArticuloValido(idArticulo, codigo, nombre, precioReferencia, activo);
            ManejadorErroresDatos.Ejecutar(() => articuloDatos.Modificar(articulo));
        }

        private static Articulo CrearArticuloValido(int idArticulo, string codigo, string nombre,
                                                    decimal precioReferencia, bool activo)
        {
            string codigoLimpio = (codigo ?? string.Empty).Trim();
            string nombreLimpio = (nombre ?? string.Empty).Trim();

            if (codigoLimpio.Length == 0)
            {
                throw new ReglaNegocioException("El código del artículo es obligatorio.");
            }
            if (codigoLimpio.Length > LongitudMaximaCodigo)
            {
                throw new ReglaNegocioException("El código no puede superar los " + LongitudMaximaCodigo + " caracteres.");
            }
            if (nombreLimpio.Length == 0)
            {
                throw new ReglaNegocioException("El nombre del artículo es obligatorio.");
            }
            if (nombreLimpio.Length > LongitudMaximaNombre)
            {
                throw new ReglaNegocioException("El nombre no puede superar los " + LongitudMaximaNombre + " caracteres.");
            }
            if (precioReferencia <= 0m)
            {
                throw new ReglaNegocioException("El precio de referencia debe ser mayor que cero.");
            }
            if (precioReferencia != System.Math.Round(precioReferencia, 2))
            {
                throw new ReglaNegocioException("El precio de referencia admite como máximo dos decimales.");
            }
            return new Articulo(idArticulo, codigoLimpio, nombreLimpio, precioReferencia, activo);
        }
    }
}

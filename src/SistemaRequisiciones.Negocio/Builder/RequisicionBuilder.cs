using System;
using System.Collections.Generic;
using System.Linq;
using SistemaRequisiciones.Entidades;
using SistemaRequisiciones.Negocio.Excepciones;
using SistemaRequisiciones.Negocio.Servicios;

namespace SistemaRequisiciones.Negocio.Builder
{
    // Construye una requisición paso a paso (patrón Builder). Es la única forma de
    // obtener un objeto Requisicion nuevo: Construir() no devuelve nada si faltan
    // datos obligatorios o si no hay al menos un artículo válido.
    public class RequisicionBuilder
    {
        private const int LongitudMaximaJustificacion = 500;

        private readonly ServicioCalculoMontos calculoMontos;
        private readonly List<DetalleRequisicion> detalles = new List<DetalleRequisicion>();

        private int idRequisicion;
        private int idSolicitante;
        private int idDepartamento;
        private string justificacion;

        public RequisicionBuilder(ServicioCalculoMontos calculoMontos)
        {
            if (calculoMontos == null)
            {
                throw new ArgumentNullException("calculoMontos");
            }
            this.calculoMontos = calculoMontos;
        }

        // Artículos agregados hasta el momento; el formulario los muestra en su cuadrícula.
        public IReadOnlyList<DetalleRequisicion> Detalles
        {
            get { return detalles.AsReadOnly(); }
        }

        // Montos de lo agregado hasta el momento, para mostrarlos mientras se captura.
        public MontosRequisicion MontosActuales
        {
            get { return calculoMontos.CalcularMontos(detalles.Select(d => d.Importe)); }
        }

        // Indica que se está reconstruyendo una requisición existente (para actualizarla).
        public RequisicionBuilder ParaModificar(int idRequisicion)
        {
            if (idRequisicion <= 0)
            {
                throw new ReglaNegocioException("La requisición que se desea modificar no es válida.");
            }
            this.idRequisicion = idRequisicion;
            return this;
        }

        public RequisicionBuilder ConSolicitante(int idSolicitante)
        {
            this.idSolicitante = idSolicitante;
            return this;
        }

        public RequisicionBuilder ConDepartamento(int idDepartamento)
        {
            this.idDepartamento = idDepartamento;
            return this;
        }

        public RequisicionBuilder ConJustificacion(string justificacion)
        {
            this.justificacion = justificacion;
            return this;
        }

        public RequisicionBuilder AgregarArticulo(Articulo articulo, int cantidad, decimal precioUnitario)
        {
            ValidarArticulo(articulo, cantidad, precioUnitario);

            decimal importe = calculoMontos.CalcularImporte(cantidad, precioUnitario);
            detalles.Add(new DetalleRequisicion(articulo.IdArticulo, articulo.Codigo, articulo.Nombre,
                                                cantidad, precioUnitario, importe));
            return this;
        }

        public RequisicionBuilder QuitarArticulo(int idArticulo)
        {
            detalles.RemoveAll(d => d.IdArticulo == idArticulo);
            return this;
        }

        // Valida todo y devuelve la requisición lista para guardarse.
        public Requisicion Construir()
        {
            ValidarDatosGenerales();

            MontosRequisicion montos = MontosActuales;
            return new Requisicion(idRequisicion, null, DateTime.Now,
                                   idSolicitante, null, idDepartamento, null,
                                   justificacion.Trim(), CodigoEstado.Creada,
                                   montos.Subtotal, montos.Impuestos, montos.Total, detalles);
        }

        private void ValidarArticulo(Articulo articulo, int cantidad, decimal precioUnitario)
        {
            if (articulo == null)
            {
                throw new ReglaNegocioException("Debe seleccionar un artículo del catálogo.");
            }
            if (!articulo.Activo)
            {
                throw new ReglaNegocioException("El artículo " + articulo.Codigo + " está inactivo y no se puede solicitar.");
            }
            if (cantidad <= 0)
            {
                throw new ReglaNegocioException("La cantidad debe ser mayor que cero.");
            }
            if (precioUnitario <= 0m)
            {
                throw new ReglaNegocioException("El precio unitario debe ser mayor que cero.");
            }
            if (precioUnitario != Math.Round(precioUnitario, 2))
            {
                throw new ReglaNegocioException("El precio unitario admite como máximo dos decimales.");
            }
            // Los duplicados se detectan por el identificador del artículo, no por su descripción.
            if (detalles.Any(d => d.IdArticulo == articulo.IdArticulo))
            {
                throw new ReglaNegocioException("El artículo " + articulo.Codigo + " ya fue agregado a la requisición.");
            }
        }

        private void ValidarDatosGenerales()
        {
            if (idSolicitante <= 0)
            {
                throw new ReglaNegocioException("Debe seleccionar un solicitante.");
            }
            if (idDepartamento <= 0)
            {
                throw new ReglaNegocioException("Debe seleccionar un departamento.");
            }
            if (string.IsNullOrWhiteSpace(justificacion))
            {
                throw new ReglaNegocioException("La justificación de la compra es obligatoria.");
            }
            if (justificacion.Trim().Length > LongitudMaximaJustificacion)
            {
                throw new ReglaNegocioException("La justificación no puede superar los " + LongitudMaximaJustificacion + " caracteres.");
            }
            if (detalles.Count == 0)
            {
                throw new ReglaNegocioException("La requisición debe tener al menos un artículo válido.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SistemaRequisiciones.Entidades
{
    // Requisición de compra. El constructor es interno: la única forma de crear una
    // requisición nueva es RequisicionBuilder, y la capa de Presentación no puede
    // modificar sus montos ni su estado.
    public class Requisicion
    {
        private readonly ReadOnlyCollection<DetalleRequisicion> detalles;

        internal Requisicion(int idRequisicion, string codigo, DateTime fecha,
                             int idSolicitante, string nombreSolicitante,
                             int idDepartamento, string nombreDepartamento,
                             string justificacion, CodigoEstado estadoActual,
                             decimal subtotal, decimal impuestos, decimal total,
                             IEnumerable<DetalleRequisicion> detalles)
        {
            IdRequisicion = idRequisicion;
            Codigo = codigo;
            Fecha = fecha;
            IdSolicitante = idSolicitante;
            NombreSolicitante = nombreSolicitante;
            IdDepartamento = idDepartamento;
            NombreDepartamento = nombreDepartamento;
            Justificacion = justificacion;
            EstadoActual = estadoActual;
            Subtotal = subtotal;
            Impuestos = impuestos;
            Total = total;
            this.detalles = new List<DetalleRequisicion>(detalles).AsReadOnly();
        }

        // Los asigna la capa de datos al guardar y la capa de negocio al cambiar de estado.
        public int IdRequisicion { get; internal set; }
        public string Codigo { get; internal set; }
        public DateTime Fecha { get; internal set; }
        public CodigoEstado EstadoActual { get; internal set; }

        public int IdSolicitante { get; }
        public string NombreSolicitante { get; }
        public int IdDepartamento { get; }
        public string NombreDepartamento { get; }
        public string Justificacion { get; }
        public decimal Subtotal { get; }
        public decimal Impuestos { get; }
        public decimal Total { get; }

        public IReadOnlyList<DetalleRequisicion> Detalles => detalles;
    }
}

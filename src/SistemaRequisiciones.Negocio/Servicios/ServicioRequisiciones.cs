using System;
using System.Collections.Generic;
using System.Linq;
using SistemaRequisiciones.Datos;
using SistemaRequisiciones.Entidades;
using SistemaRequisiciones.Negocio.Builder;
using SistemaRequisiciones.Negocio.Estados;
using SistemaRequisiciones.Negocio.Estrategias;
using SistemaRequisiciones.Negocio.Excepciones;

namespace SistemaRequisiciones.Negocio.Servicios
{
    // Coordina el ciclo de vida de las requisiciones: creación con Builder, edición,
    // consulta y cambios de estado con State. Los formularios solo hablan con esta clase.
    public class ServicioRequisiciones
    {
        private readonly RequisicionDatos requisicionDatos = new RequisicionDatos();
        private readonly ArticuloDatos articuloDatos = new ArticuloDatos();
        private readonly CatalogoDatos catalogoDatos = new CatalogoDatos();
        private readonly ServicioCalculoMontos calculoMontos;

        // Política de impuestos inicial: porcentaje configurado en App.config.
        // Para usar otra política basta con pasar otra estrategia al constructor.
        public ServicioRequisiciones()
            : this(new ServicioCalculoMontos(
                new EstrategiaImpuestoPorcentaje(ConfiguracionAplicacion.Instancia.TasaImpuesto)))
        {
        }

        public ServicioRequisiciones(ServicioCalculoMontos calculoMontos)
        {
            if (calculoMontos == null)
            {
                throw new ArgumentNullException("calculoMontos");
            }
            this.calculoMontos = calculoMontos;
        }

        public string NombrePoliticaImpuesto
        {
            get { return calculoMontos.NombrePoliticaImpuesto; }
        }

        // ---------- Datos de apoyo para la captura ----------

        public List<Solicitante> ListarSolicitantes()
        {
            return ManejadorErroresDatos.Ejecutar(() => catalogoDatos.ListarSolicitantes());
        }

        public List<Departamento> ListarDepartamentos()
        {
            return ManejadorErroresDatos.Ejecutar(() => catalogoDatos.ListarDepartamentos());
        }

        public List<Articulo> ListarArticulosActivos()
        {
            return ManejadorErroresDatos.Ejecutar(() => articuloDatos.Listar(true));
        }

        // ---------- Creación y edición (siempre mediante Builder) ----------

        // Borrador vacío para capturar una requisición nueva.
        public RequisicionBuilder NuevoBorrador()
        {
            return new RequisicionBuilder(calculoMontos);
        }

        // Borrador con los datos de una requisición existente, para editarla.
        // Solo se permite mientras la requisición siga en estado Creada.
        public RequisicionBuilder BorradorDesde(Requisicion requisicion)
        {
            if (requisicion == null)
            {
                throw new ArgumentNullException("requisicion");
            }
            EstadoRequisicion.Desde(requisicion.EstadoActual).ValidarQueSePuedeModificar();

            List<Articulo> catalogo = ManejadorErroresDatos.Ejecutar(() => articuloDatos.Listar(false));

            RequisicionBuilder borrador = NuevoBorrador()
                .ParaModificar(requisicion.IdRequisicion)
                .ConSolicitante(requisicion.IdSolicitante)
                .ConDepartamento(requisicion.IdDepartamento)
                .ConJustificacion(requisicion.Justificacion);

            foreach (DetalleRequisicion detalle in requisicion.Detalles)
            {
                Articulo articulo = catalogo.FirstOrDefault(a => a.IdArticulo == detalle.IdArticulo);
                borrador.AgregarArticulo(articulo, detalle.Cantidad, detalle.PrecioUnitario);
            }
            return borrador;
        }

        // Valida el borrador con el Builder y lo guarda. Devuelve la requisición
        // tal como quedó en la base de datos (con su código y fecha).
        public Requisicion Guardar(RequisicionBuilder borrador)
        {
            if (borrador == null)
            {
                throw new ArgumentNullException("borrador");
            }

            Requisicion requisicion = borrador.Construir();
            int idRequisicion = ManejadorErroresDatos.Ejecutar(() => GuardarEnBaseDeDatos(requisicion));
            return ObtenerPorId(idRequisicion);
        }

        private int GuardarEnBaseDeDatos(Requisicion requisicion)
        {
            if (requisicion.IdRequisicion == 0)
            {
                requisicionDatos.Crear(requisicion);
                return requisicion.IdRequisicion;
            }

            // Se vuelve a leer el estado real, por si la requisición cambió desde que se abrió.
            Requisicion existente = requisicionDatos.ObtenerPorId(requisicion.IdRequisicion);
            if (existente == null)
            {
                throw new ReglaNegocioException("La requisición que se intenta modificar no existe.");
            }
            EstadoRequisicion.Desde(existente.EstadoActual).ValidarQueSePuedeModificar();

            requisicionDatos.Actualizar(requisicion);
            return requisicion.IdRequisicion;
        }

        // ---------- Consultas ----------

        public Requisicion ObtenerPorId(int idRequisicion)
        {
            Requisicion requisicion = ManejadorErroresDatos.Ejecutar(() => requisicionDatos.ObtenerPorId(idRequisicion));
            if (requisicion == null)
            {
                throw new ReglaNegocioException("La requisición solicitada no existe.");
            }
            return requisicion;
        }

        public List<Requisicion> Consultar(FiltroRequisiciones filtro)
        {
            return ManejadorErroresDatos.Ejecutar(() => requisicionDatos.Consultar(filtro));
        }

        // Cuenta las requisiciones y suma sus montos por estado.
        public ResumenRequisiciones CalcularResumen(IEnumerable<Requisicion> requisiciones)
        {
            List<Requisicion> lista = requisiciones.ToList();
            List<ResumenEstado> porEstado = new List<ResumenEstado>();

            foreach (CodigoEstado codigo in Enum.GetValues(typeof(CodigoEstado)))
            {
                List<Requisicion> delEstado = lista.Where(r => r.EstadoActual == codigo).ToList();
                porEstado.Add(new ResumenEstado(codigo, EstadoRequisicion.Desde(codigo).Nombre,
                                                delEstado.Count, delEstado.Sum(r => r.Total)));
            }
            return new ResumenRequisiciones(porEstado);
        }

        // ---------- Cambios de estado (patrón State) ----------

        public Requisicion EnviarARevision(int idRequisicion)
        {
            return EjecutarTransicion(idRequisicion, estado => estado.EnviarARevision());
        }

        public Requisicion Aprobar(int idRequisicion)
        {
            return EjecutarTransicion(idRequisicion, estado => estado.Aprobar());
        }

        public Requisicion Rechazar(int idRequisicion)
        {
            return EjecutarTransicion(idRequisicion, estado => estado.Rechazar());
        }

        public Requisicion Cancelar(int idRequisicion)
        {
            return EjecutarTransicion(idRequisicion, estado => estado.Cancelar());
        }

        // Verifica que la requisición permita la transición solicitada y la guarda.
        private Requisicion EjecutarTransicion(int idRequisicion,
                                               Func<EstadoRequisicion, EstadoRequisicion> transicion)
        {
            // Se lee el estado vigente en la base de datos, no el que muestre el formulario.
            Requisicion requisicion = ObtenerPorId(idRequisicion);
            EstadoRequisicion estadoActual = EstadoRequisicion.Desde(requisicion.EstadoActual);

            // Si la transición no está permitida, el estado lanza ReglaNegocioException.
            EstadoRequisicion estadoNuevo = transicion(estadoActual);

            ManejadorErroresDatos.Ejecutar(() => requisicionDatos.CambiarEstado(idRequisicion, estadoNuevo.Codigo));

            // El objeto cambia de estado solo después de que SQL Server confirmó el cambio.
            requisicion.EstadoActual = estadoNuevo.Codigo;
            return requisicion;
        }
    }
}

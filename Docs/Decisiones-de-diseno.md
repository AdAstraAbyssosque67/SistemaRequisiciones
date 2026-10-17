# Decisiones de diseño

## Supuestos

| Tema | Decisión |
|---|---|
| Versiones | .NET Framework 4.8, Visual Studio 2022, SQL Server 2016 SP1 o superior |
| Impuesto inicial | 18 % sobre el subtotal, configurable en `App.config`; es un valor de ejemplo que debe confirmarse |
| Solicitantes y departamentos | Cada solicitante pertenece a un departamento; la requisición guarda ambos. Se cargan como datos iniciales, sin formulario de mantenimiento |
| Catálogo de artículos | Código único, nombre, precio de referencia y estado activo. Con formulario para listar, agregar y modificar |
| Precio unitario | Se propone desde el catálogo, se puede ajustar y debe ser mayor que cero. El detalle conserva el precio usado |
| Código de requisición | `REQ-AAAA-NNNNN`, generado en el procedimiento `usp_CrearRequisicion` |
| Montos | Se guardan subtotal, impuestos y total. SQL Server verifica que coincidan con los detalles |
| Edición | Solo en estado Creada |
| Autenticación | No incluida |

## Transiciones de estado

| Estado actual | Puede pasar a | Editable |
|---|---|---|
| Creada | En Revisión, Cancelada | Sí |
| En Revisión | Aprobada, Rechazada, Cancelada | No |
| Aprobada | (ninguno) | No |
| Rechazada | (ninguno) | No |
| Cancelada | (ninguno) | No |

Las transiciones se validan en C# (patrón State) y en SQL Server (tabla `TransicionesEstado`).

## Referencias entre proyectos

- Entidades no referencia a ningún proyecto.
- Datos referencia a Entidades.
- Negocio referencia a Datos y Entidades.
- Presentacion referencia a Negocio y Entidades (nunca a Datos).

## Base de datos

- Procedimientos: `usp_CrearRequisicion`, `usp_ActualizarRequisicion`, `usp_CambiarEstadoRequisicion`, `usp_RegistrarArticulo`, `usp_ModificarArticulo` y el auxiliar `usp_ValidarDatosRequisicion`.
- Se usa el prefijo `usp_` (y no `sp_`) porque `sp_` está reservado a procedimientos del sistema.
- Vistas de reporte: `vw_ReporteRequisicionCabecera` y `vw_ReporteRequisicionDetalle`. Solo devuelven requisiciones Aprobadas.
- Vistas de consulta: `vw_ConsultaRequisiciones` y `vw_ConsultaDetalleRequisicion`.
- Los detalles se envían a los procedimientos con el tipo de tabla `dbo.TipoDetalleRequisicion`.

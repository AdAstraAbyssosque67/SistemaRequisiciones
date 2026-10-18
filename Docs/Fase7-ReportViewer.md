# Fase 7: ReportViewer

## Dependencias

- Paquete NuGet `Microsoft.ReportingServices.ReportViewerControl.Winforms` (serie 150.x), declarado en `SistemaRequisiciones.Presentacion.csproj` con `Version="150.*"`. Visual Studio lo restaura al compilar (necesita internet la primera vez).
- Opcional: la extensión **Microsoft RDLC Report Designer** (Extensiones > Administrar extensiones) para editar el reporte de forma visual. Sin ella, el `.rdlc` se abre como XML y la aplicación funciona igual.

## Piezas

| Archivo | Función |
|---|---|
| `Reportes/RequisicionAprobada.rdlc` | Diseño del reporte (recurso incrustado). Dos orígenes de datos: `Cabecera` y `Detalle`. |
| `FrmReporteRequisicion` | Formulario con el control ReportViewer. Recibe el identificador de la requisición. |
| `Apoyo/AperturaReporte.cs` | Único punto desde el que se abre el reporte; muestra el motivo si no se puede. |
| `ServicioReportes` (Negocio) | Comprueba que la requisición esté Aprobada y entrega los datos. |
| `ReporteDatos` (Datos) | Lee `vw_ReporteRequisicionCabecera` y `vw_ReporteRequisicionDetalle`. |

## Flujo

1. El usuario pulsa **Generar reporte** (solo habilitado para requisiciones aprobadas).
2. `AperturaReporte.Mostrar` crea `FrmReporteRequisicion(id)` y llama a `CargarDatos()`.
3. `ServicioReportes.ObtenerDatosReporte(id)` lee el estado real en la base de datos y lanza `ReglaNegocioException` si no es Aprobada. El formulario ni siquiera se muestra.
4. `ReporteDatos` consulta las dos vistas filtrando con `WHERE IdRequisicion = @IdRequisicion`. Las vistas solo devuelven requisiciones aprobadas, así que hay un segundo control en SQL Server.
5. En el evento Load, el formulario enlaza las tablas `Cabecera` y `Detalle` a los DataSet del `.rdlc` y llama a `RefreshReport()`.

## Contenido del reporte

Código, fecha, solicitante, departamento, justificación, estado, artículos (código, nombre, cantidad, precio unitario, importe), subtotal, impuestos y total.

## Si algo falla

| Síntoma | Causa probable |
|---|---|
| No se restaura el paquete | Sin internet o fuente de NuGet desactivada. Instálalo desde Herramientas > Administrador de paquetes NuGet. |
| "No se pudo cargar el recurso del informe" | El `.rdlc` no está incrustado. Verifica que su **Acción de compilación** sea *Recurso incrustado* y que el nombre sea `SistemaRequisiciones.Presentacion.Reportes.RequisicionAprobada.rdlc`. |
| El reporte sale vacío | Los nombres de los orígenes de datos no coinciden con `Cabecera` y `Detalle`, o la requisición no está aprobada. |

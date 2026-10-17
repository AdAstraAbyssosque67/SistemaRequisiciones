/* =====================================================================
   Verificación y pruebas de la base de datos SistemaRequisiciones.
   Ejecutar después de 01_CrearBaseDeDatos.sql.
   Cada bloque (separado por GO) se puede ejecutar por separado.
   Las pruebas de los bloques 3 y 4 crean datos de prueba en la base.
   ===================================================================== */

USE SistemaRequisiciones;
GO

/* ---------------------------------------------------------------------
   1. Objetos creados
   Esperado: 8 tablas, 6 procedimientos, 4 vistas y 1 tipo de tabla.
   --------------------------------------------------------------------- */
SELECT N'Tabla' AS Tipo, name AS Nombre FROM sys.tables WHERE schema_id = SCHEMA_ID(N'dbo')
UNION ALL
SELECT N'Procedimiento', name FROM sys.procedures WHERE schema_id = SCHEMA_ID(N'dbo')
UNION ALL
SELECT N'Vista', name FROM sys.views WHERE schema_id = SCHEMA_ID(N'dbo')
UNION ALL
SELECT N'Tipo de tabla', name FROM sys.table_types WHERE schema_id = SCHEMA_ID(N'dbo')
ORDER BY Tipo, Nombre;
GO

/* ---------------------------------------------------------------------
   2. Datos iniciales
   Esperado: Estados 5, Transiciones 5, Departamentos 6, Solicitantes 8, Articulos 10.
   --------------------------------------------------------------------- */
SELECT (SELECT COUNT(*) FROM dbo.Estados)             AS Estados,
       (SELECT COUNT(*) FROM dbo.TransicionesEstado)  AS Transiciones,
       (SELECT COUNT(*) FROM dbo.Departamentos)       AS Departamentos,
       (SELECT COUNT(*) FROM dbo.Solicitantes)        AS Solicitantes,
       (SELECT COUNT(*) FROM dbo.Articulos)           AS Articulos;
GO

/* ---------------------------------------------------------------------
   3. Ciclo de vida de una requisición válida
   Esperado:
     - Se crea con código REQ-AAAA-NNNNN.
     - Antes de aprobarla, la vista de reporte devuelve 0 filas.
     - Creada -> Aprobada falla (error 50022).
     - Creada -> En Revisión -> Aprobada funciona.
     - Aprobada -> Cancelada falla (error 50022).
     - Modificar una requisición aprobada falla (error 50041).
     - Después de aprobarla, las vistas de reporte devuelven datos.
   --------------------------------------------------------------------- */
DECLARE @idSolicitante  INT = (SELECT TOP 1 IdSolicitante FROM dbo.Solicitantes ORDER BY IdSolicitante);
DECLARE @idDepartamento INT = (SELECT IdDepartamento FROM dbo.Solicitantes WHERE IdSolicitante = @idSolicitante);

DECLARE @detalles dbo.TipoDetalleRequisicion;
INSERT INTO @detalles (IdArticulo, Cantidad, PrecioUnitario)
SELECT TOP 2 IdArticulo, 2, PrecioReferencia FROM dbo.Articulos ORDER BY IdArticulo;

-- Los montos se calculan igual que lo hará la capa de negocio (tasa de ejemplo: 18 %).
DECLARE @subtotal  DECIMAL(18,2) = (SELECT SUM(CAST(Cantidad * PrecioUnitario AS DECIMAL(18,2))) FROM @detalles);
DECLARE @impuestos DECIMAL(18,2) = ROUND(@subtotal * 0.18, 2);
DECLARE @total     DECIMAL(18,2) = @subtotal + @impuestos;

DECLARE @idRequisicion INT, @codigo NVARCHAR(20);

EXEC dbo.usp_CrearRequisicion
    @IdSolicitante  = @idSolicitante,
    @IdDepartamento = @idDepartamento,
    @Justificacion  = N'Prueba de ciclo de vida',
    @Subtotal       = @subtotal,
    @Impuestos      = @impuestos,
    @Total          = @total,
    @Detalles       = @detalles,
    @IdRequisicion  = @idRequisicion OUTPUT,
    @Codigo         = @codigo OUTPUT;

SELECT @idRequisicion AS IdRequisicion, @codigo AS Codigo, @subtotal AS Subtotal,
       @impuestos AS Impuestos, @total AS Total;

SELECT COUNT(*) AS FilasReporteAntesDeAprobar
FROM dbo.vw_ReporteRequisicionCabecera WHERE IdRequisicion = @idRequisicion;

-- Transición inválida: Creada -> Aprobada.
BEGIN TRY
    EXEC dbo.usp_CambiarEstadoRequisicion @IdRequisicion = @idRequisicion, @IdEstadoNuevo = 3;
END TRY
BEGIN CATCH
    SELECT ERROR_NUMBER() AS Error, ERROR_MESSAGE() AS Mensaje;
END CATCH

-- Transiciones válidas: Creada -> En Revisión -> Aprobada.
EXEC dbo.usp_CambiarEstadoRequisicion @IdRequisicion = @idRequisicion, @IdEstadoNuevo = 2;
EXEC dbo.usp_CambiarEstadoRequisicion @IdRequisicion = @idRequisicion, @IdEstadoNuevo = 3;

-- Transición inválida desde un estado final: Aprobada -> Cancelada.
BEGIN TRY
    EXEC dbo.usp_CambiarEstadoRequisicion @IdRequisicion = @idRequisicion, @IdEstadoNuevo = 5;
END TRY
BEGIN CATCH
    SELECT ERROR_NUMBER() AS Error, ERROR_MESSAGE() AS Mensaje;
END CATCH

-- Modificación de una requisición aprobada.
BEGIN TRY
    EXEC dbo.usp_ActualizarRequisicion
        @IdRequisicion  = @idRequisicion,
        @IdSolicitante  = @idSolicitante,
        @IdDepartamento = @idDepartamento,
        @Justificacion  = N'Intento de modificar una requisición aprobada',
        @Subtotal       = @subtotal,
        @Impuestos      = @impuestos,
        @Total          = @total,
        @Detalles       = @detalles;
END TRY
BEGIN CATCH
    SELECT ERROR_NUMBER() AS Error, ERROR_MESSAGE() AS Mensaje;
END CATCH

-- Ya aprobada, las vistas de reporte devuelven la requisición.
SELECT CodigoRequisicion, Fecha, Solicitante, Departamento, Justificacion, Estado, Subtotal, Impuestos, Total
FROM dbo.vw_ReporteRequisicionCabecera WHERE IdRequisicion = @idRequisicion;

SELECT CodigoArticulo, NombreArticulo, Cantidad, PrecioUnitario, Importe
FROM dbo.vw_ReporteRequisicionDetalle WHERE IdRequisicion = @idRequisicion;
GO

/* ---------------------------------------------------------------------
   4. Creaciones inválidas
   Esperado: cada intento muestra su error y no queda ningún dato parcial.
     50004 sin artículos | 50005 cantidad cero | 50006 precio cero
     50007 duplicado     | 50008 artículo inexistente
     50009 subtotal manipulado
   Al final, FilasAntes y FilasDespues deben ser iguales.
   --------------------------------------------------------------------- */
DECLARE @idSolicitante  INT = (SELECT TOP 1 IdSolicitante FROM dbo.Solicitantes ORDER BY IdSolicitante);
DECLARE @idDepartamento INT = (SELECT IdDepartamento FROM dbo.Solicitantes WHERE IdSolicitante = @idSolicitante);
DECLARE @idArticulo INT = (SELECT TOP 1 IdArticulo FROM dbo.Articulos ORDER BY IdArticulo);
DECLARE @detalles dbo.TipoDetalleRequisicion;
DECLARE @idRequisicion INT, @codigo NVARCHAR(20);

DECLARE @requisicionesAntes INT = (SELECT COUNT(*) FROM dbo.Requisiciones);
DECLARE @detallesAntes      INT = (SELECT COUNT(*) FROM dbo.DetalleRequisicion);

-- 4.1 Sin artículos.
BEGIN TRY
    EXEC dbo.usp_CrearRequisicion @IdSolicitante = @idSolicitante, @IdDepartamento = @idDepartamento,
        @Justificacion = N'Sin artículos', @Subtotal = 0, @Impuestos = 0, @Total = 0,
        @Detalles = @detalles, @IdRequisicion = @idRequisicion OUTPUT, @Codigo = @codigo OUTPUT;
END TRY
BEGIN CATCH
    SELECT N'4.1 Sin artículos' AS Prueba, ERROR_NUMBER() AS Error, ERROR_MESSAGE() AS Mensaje;
END CATCH

-- 4.2 Cantidad igual a cero.
INSERT INTO @detalles (IdArticulo, Cantidad, PrecioUnitario) VALUES (@idArticulo, 0, 100);
BEGIN TRY
    EXEC dbo.usp_CrearRequisicion @IdSolicitante = @idSolicitante, @IdDepartamento = @idDepartamento,
        @Justificacion = N'Cantidad cero', @Subtotal = 0, @Impuestos = 0, @Total = 0,
        @Detalles = @detalles, @IdRequisicion = @idRequisicion OUTPUT, @Codigo = @codigo OUTPUT;
END TRY
BEGIN CATCH
    SELECT N'4.2 Cantidad cero' AS Prueba, ERROR_NUMBER() AS Error, ERROR_MESSAGE() AS Mensaje;
END CATCH

-- 4.3 Precio unitario igual a cero.
DELETE FROM @detalles;
INSERT INTO @detalles (IdArticulo, Cantidad, PrecioUnitario) VALUES (@idArticulo, 1, 0);
BEGIN TRY
    EXEC dbo.usp_CrearRequisicion @IdSolicitante = @idSolicitante, @IdDepartamento = @idDepartamento,
        @Justificacion = N'Precio cero', @Subtotal = 0, @Impuestos = 0, @Total = 0,
        @Detalles = @detalles, @IdRequisicion = @idRequisicion OUTPUT, @Codigo = @codigo OUTPUT;
END TRY
BEGIN CATCH
    SELECT N'4.3 Precio cero' AS Prueba, ERROR_NUMBER() AS Error, ERROR_MESSAGE() AS Mensaje;
END CATCH

-- 4.4 Artículo duplicado.
DELETE FROM @detalles;
INSERT INTO @detalles (IdArticulo, Cantidad, PrecioUnitario) VALUES (@idArticulo, 1, 100), (@idArticulo, 2, 100);
BEGIN TRY
    EXEC dbo.usp_CrearRequisicion @IdSolicitante = @idSolicitante, @IdDepartamento = @idDepartamento,
        @Justificacion = N'Duplicado', @Subtotal = 300, @Impuestos = 54, @Total = 354,
        @Detalles = @detalles, @IdRequisicion = @idRequisicion OUTPUT, @Codigo = @codigo OUTPUT;
END TRY
BEGIN CATCH
    SELECT N'4.4 Duplicado' AS Prueba, ERROR_NUMBER() AS Error, ERROR_MESSAGE() AS Mensaje;
END CATCH

-- 4.5 Artículo que no existe en el catálogo.
DELETE FROM @detalles;
INSERT INTO @detalles (IdArticulo, Cantidad, PrecioUnitario) VALUES (999999, 1, 100);
BEGIN TRY
    EXEC dbo.usp_CrearRequisicion @IdSolicitante = @idSolicitante, @IdDepartamento = @idDepartamento,
        @Justificacion = N'Artículo inexistente', @Subtotal = 100, @Impuestos = 18, @Total = 118,
        @Detalles = @detalles, @IdRequisicion = @idRequisicion OUTPUT, @Codigo = @codigo OUTPUT;
END TRY
BEGIN CATCH
    SELECT N'4.5 Artículo inexistente' AS Prueba, ERROR_NUMBER() AS Error, ERROR_MESSAGE() AS Mensaje;
END CATCH

-- 4.6 Subtotal manipulado (no coincide con los detalles).
DELETE FROM @detalles;
INSERT INTO @detalles (IdArticulo, Cantidad, PrecioUnitario) VALUES (@idArticulo, 1, 100);
BEGIN TRY
    EXEC dbo.usp_CrearRequisicion @IdSolicitante = @idSolicitante, @IdDepartamento = @idDepartamento,
        @Justificacion = N'Subtotal manipulado', @Subtotal = 1, @Impuestos = 0, @Total = 1,
        @Detalles = @detalles, @IdRequisicion = @idRequisicion OUTPUT, @Codigo = @codigo OUTPUT;
END TRY
BEGIN CATCH
    SELECT N'4.6 Subtotal manipulado' AS Prueba, ERROR_NUMBER() AS Error, ERROR_MESSAGE() AS Mensaje;
END CATCH

-- Ninguna de las pruebas anteriores debe haber dejado datos.
SELECT @requisicionesAntes AS RequisicionesAntes, (SELECT COUNT(*) FROM dbo.Requisiciones) AS RequisicionesDespues,
       @detallesAntes AS DetallesAntes, (SELECT COUNT(*) FROM dbo.DetalleRequisicion) AS DetallesDespues;
GO

/* ---------------------------------------------------------------------
   5. Restricciones de las tablas (segunda línea de defensa)
   Esperado: el INSERT directo falla por las restricciones CHECK y FOREIGN KEY.
   --------------------------------------------------------------------- */
BEGIN TRY
    INSERT INTO dbo.DetalleRequisicion (IdRequisicion, IdArticulo, Cantidad, PrecioUnitario)
    VALUES (999999, 999999, 0, 0);
END TRY
BEGIN CATCH
    SELECT ERROR_NUMBER() AS Error, ERROR_MESSAGE() AS Mensaje;
END CATCH
GO

/* =====================================================================
   Sistema de Gestión de Requisiciones de Compra
   Script de base de datos para SQL Server 2016 SP1 o superior.

   Puede ejecutarse varias veces: no duplica datos y vuelve a crear
   los procedimientos y las vistas con CREATE OR ALTER.

   Códigos de error propios (THROW):
     50001-50010  Validación de datos de la requisición
     50020-50022  Cambio de estado
     50030-50034  Catálogo de artículos
     50040-50041  Actualización de requisiciones
   ===================================================================== */

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO

USE master;
GO

IF DB_ID(N'SistemaRequisiciones') IS NULL
    CREATE DATABASE SistemaRequisiciones;
GO

USE SistemaRequisiciones;
GO

/* =====================================================================
   1. TABLAS
   ===================================================================== */

IF OBJECT_ID(N'dbo.Departamentos', N'U') IS NULL
CREATE TABLE dbo.Departamentos
(
    IdDepartamento INT IDENTITY(1,1) NOT NULL,
    Nombre         NVARCHAR(100)     NOT NULL,
    CONSTRAINT PK_Departamentos PRIMARY KEY (IdDepartamento),
    CONSTRAINT UQ_Departamentos_Nombre UNIQUE (Nombre)
);
GO

IF OBJECT_ID(N'dbo.Solicitantes', N'U') IS NULL
CREATE TABLE dbo.Solicitantes
(
    IdSolicitante  INT IDENTITY(1,1) NOT NULL,
    Nombre         NVARCHAR(150)     NOT NULL,
    IdDepartamento INT               NOT NULL,
    CONSTRAINT PK_Solicitantes PRIMARY KEY (IdSolicitante),
    CONSTRAINT UQ_Solicitantes_Nombre UNIQUE (Nombre),
    CONSTRAINT FK_Solicitantes_Departamentos
        FOREIGN KEY (IdDepartamento) REFERENCES dbo.Departamentos (IdDepartamento)
);
GO

IF OBJECT_ID(N'dbo.Articulos', N'U') IS NULL
CREATE TABLE dbo.Articulos
(
    IdArticulo       INT IDENTITY(1,1) NOT NULL,
    Codigo           NVARCHAR(20)      NOT NULL,
    Nombre           NVARCHAR(150)     NOT NULL,
    PrecioReferencia DECIMAL(18,2)     NOT NULL,
    Activo           BIT               NOT NULL CONSTRAINT DF_Articulos_Activo DEFAULT (1),
    CONSTRAINT PK_Articulos PRIMARY KEY (IdArticulo),
    CONSTRAINT UQ_Articulos_Codigo UNIQUE (Codigo),
    CONSTRAINT CK_Articulos_Precio CHECK (PrecioReferencia > 0),
    CONSTRAINT CK_Articulos_Codigo CHECK (LEN(LTRIM(RTRIM(Codigo))) > 0),
    CONSTRAINT CK_Articulos_Nombre CHECK (LEN(LTRIM(RTRIM(Nombre))) > 0)
);
GO

-- Los identificadores de estado son fijos porque el código C# los usa.
IF OBJECT_ID(N'dbo.Estados', N'U') IS NULL
CREATE TABLE dbo.Estados
(
    IdEstado TINYINT      NOT NULL,
    Nombre   NVARCHAR(30) NOT NULL,
    CONSTRAINT PK_Estados PRIMARY KEY (IdEstado),
    CONSTRAINT UQ_Estados_Nombre UNIQUE (Nombre)
);
GO

-- Transiciones permitidas; SQL Server las consulta para validar cambios de estado.
IF OBJECT_ID(N'dbo.TransicionesEstado', N'U') IS NULL
CREATE TABLE dbo.TransicionesEstado
(
    IdEstadoOrigen  TINYINT NOT NULL,
    IdEstadoDestino TINYINT NOT NULL,
    CONSTRAINT PK_TransicionesEstado PRIMARY KEY (IdEstadoOrigen, IdEstadoDestino),
    CONSTRAINT FK_TransicionesEstado_Origen
        FOREIGN KEY (IdEstadoOrigen) REFERENCES dbo.Estados (IdEstado),
    CONSTRAINT FK_TransicionesEstado_Destino
        FOREIGN KEY (IdEstadoDestino) REFERENCES dbo.Estados (IdEstado),
    CONSTRAINT CK_TransicionesEstado_Distintos CHECK (IdEstadoOrigen <> IdEstadoDestino)
);
GO

-- Contador por año para generar códigos REQ-AAAA-NNNNN sin huecos.
IF OBJECT_ID(N'dbo.ContadorRequisiciones', N'U') IS NULL
CREATE TABLE dbo.ContadorRequisiciones
(
    Anio         INT NOT NULL,
    UltimoNumero INT NOT NULL,
    CONSTRAINT PK_ContadorRequisiciones PRIMARY KEY (Anio)
);
GO

IF OBJECT_ID(N'dbo.Requisiciones', N'U') IS NULL
CREATE TABLE dbo.Requisiciones
(
    IdRequisicion  INT IDENTITY(1,1) NOT NULL,
    Codigo         NVARCHAR(20)      NOT NULL,
    Fecha          DATETIME2(0)      NOT NULL CONSTRAINT DF_Requisiciones_Fecha DEFAULT (SYSDATETIME()),
    IdSolicitante  INT               NOT NULL,
    IdDepartamento INT               NOT NULL,
    Justificacion  NVARCHAR(500)     NOT NULL,
    IdEstado       TINYINT           NOT NULL CONSTRAINT DF_Requisiciones_Estado DEFAULT (1),
    Subtotal       DECIMAL(18,2)     NOT NULL,
    Impuestos      DECIMAL(18,2)     NOT NULL,
    Total          DECIMAL(18,2)     NOT NULL,
    CONSTRAINT PK_Requisiciones PRIMARY KEY (IdRequisicion),
    CONSTRAINT UQ_Requisiciones_Codigo UNIQUE (Codigo),
    CONSTRAINT FK_Requisiciones_Solicitantes
        FOREIGN KEY (IdSolicitante) REFERENCES dbo.Solicitantes (IdSolicitante),
    CONSTRAINT FK_Requisiciones_Departamentos
        FOREIGN KEY (IdDepartamento) REFERENCES dbo.Departamentos (IdDepartamento),
    CONSTRAINT FK_Requisiciones_Estados
        FOREIGN KEY (IdEstado) REFERENCES dbo.Estados (IdEstado),
    CONSTRAINT CK_Requisiciones_Justificacion CHECK (LEN(LTRIM(RTRIM(Justificacion))) > 0),
    CONSTRAINT CK_Requisiciones_Montos
        CHECK (Subtotal >= 0 AND Impuestos >= 0 AND Total = Subtotal + Impuestos)
);
GO

IF OBJECT_ID(N'dbo.DetalleRequisicion', N'U') IS NULL
CREATE TABLE dbo.DetalleRequisicion
(
    IdDetalle      INT IDENTITY(1,1) NOT NULL,
    IdRequisicion  INT               NOT NULL,
    IdArticulo     INT               NOT NULL,
    Cantidad       INT               NOT NULL,
    PrecioUnitario DECIMAL(18,2)     NOT NULL,
    -- El importe se calcula en la base de datos para que nadie pueda manipularlo.
    Importe        AS CAST(Cantidad * PrecioUnitario AS DECIMAL(18,2)) PERSISTED,
    CONSTRAINT PK_DetalleRequisicion PRIMARY KEY (IdDetalle),
    CONSTRAINT UQ_DetalleRequisicion_Articulo UNIQUE (IdRequisicion, IdArticulo),
    CONSTRAINT FK_DetalleRequisicion_Requisiciones
        FOREIGN KEY (IdRequisicion) REFERENCES dbo.Requisiciones (IdRequisicion),
    CONSTRAINT FK_DetalleRequisicion_Articulos
        FOREIGN KEY (IdArticulo) REFERENCES dbo.Articulos (IdArticulo),
    CONSTRAINT CK_DetalleRequisicion_Cantidad CHECK (Cantidad > 0),
    CONSTRAINT CK_DetalleRequisicion_Precio CHECK (PrecioUnitario > 0)
);
GO

/* =====================================================================
   2. TIPO DE TABLA PARA ENVIAR LOS DETALLES A LOS PROCEDIMIENTOS
   ===================================================================== */

IF TYPE_ID(N'dbo.TipoDetalleRequisicion') IS NULL
CREATE TYPE dbo.TipoDetalleRequisicion AS TABLE
(
    IdArticulo     INT           NOT NULL,
    Cantidad       INT           NOT NULL,
    PrecioUnitario DECIMAL(18,2) NOT NULL
);
GO

/* =====================================================================
   3. DATOS INICIALES (no se duplican al ejecutar de nuevo)
   ===================================================================== */

INSERT INTO dbo.Estados (IdEstado, Nombre)
SELECT v.IdEstado, v.Nombre
FROM (VALUES
        (1, N'Creada'),
        (2, N'En Revisión'),
        (3, N'Aprobada'),
        (4, N'Rechazada'),
        (5, N'Cancelada')
     ) AS v (IdEstado, Nombre)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Estados e WHERE e.IdEstado = v.IdEstado);
GO

INSERT INTO dbo.TransicionesEstado (IdEstadoOrigen, IdEstadoDestino)
SELECT v.IdEstadoOrigen, v.IdEstadoDestino
FROM (VALUES
        (1, 2),  -- Creada -> En Revisión
        (1, 5),  -- Creada -> Cancelada
        (2, 3),  -- En Revisión -> Aprobada
        (2, 4),  -- En Revisión -> Rechazada
        (2, 5)   -- En Revisión -> Cancelada
     ) AS v (IdEstadoOrigen, IdEstadoDestino)
WHERE NOT EXISTS (
        SELECT 1 FROM dbo.TransicionesEstado t
        WHERE t.IdEstadoOrigen = v.IdEstadoOrigen
          AND t.IdEstadoDestino = v.IdEstadoDestino);
GO

INSERT INTO dbo.Departamentos (Nombre)
SELECT v.Nombre
FROM (VALUES
        (N'Tecnología'),
        (N'Compras'),
        (N'Finanzas'),
        (N'Recursos Humanos'),
        (N'Mantenimiento'),
        (N'Administración')
     ) AS v (Nombre)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Departamentos d WHERE d.Nombre = v.Nombre);
GO

INSERT INTO dbo.Solicitantes (Nombre, IdDepartamento)
SELECT v.Nombre, d.IdDepartamento
FROM (VALUES
        (N'María Fernández',  N'Tecnología'),
        (N'Luis Peña',        N'Tecnología'),
        (N'Carmen Rodríguez', N'Compras'),
        (N'José Martínez',    N'Finanzas'),
        (N'Ana Gómez',        N'Recursos Humanos'),
        (N'Pedro Sánchez',    N'Mantenimiento'),
        (N'Laura Díaz',       N'Administración'),
        (N'Rafael Núñez',     N'Compras')
     ) AS v (Nombre, Departamento)
JOIN dbo.Departamentos d ON d.Nombre = v.Departamento
WHERE NOT EXISTS (SELECT 1 FROM dbo.Solicitantes s WHERE s.Nombre = v.Nombre);
GO

INSERT INTO dbo.Articulos (Codigo, Nombre, PrecioReferencia)
SELECT v.Codigo, v.Nombre, v.PrecioReferencia
FROM (VALUES
        (N'ART-001', N'Resma de papel carta 500 hojas',   285.00),
        (N'ART-002', N'Caja de bolígrafos azules (12)',   180.00),
        (N'ART-003', N'Tóner para impresora láser negro', 3250.00),
        (N'ART-004', N'Teclado USB',                      650.00),
        (N'ART-005', N'Ratón óptico inalámbrico',         475.00),
        (N'ART-006', N'Monitor de 24 pulgadas',           9800.00),
        (N'ART-007', N'Silla ergonómica de oficina',      7200.00),
        (N'ART-008', N'Archivador metálico de 4 gavetas', 8500.00),
        (N'ART-009', N'Cable de red Cat6 (5 m)',          220.00),
        (N'ART-010', N'Disco duro externo 1 TB',          3900.00)
     ) AS v (Codigo, Nombre, PrecioReferencia)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Articulos a WHERE a.Codigo = v.Codigo);
GO

/* =====================================================================
   4. PROCEDIMIENTOS ALMACENADOS
   ===================================================================== */

-- Comprueba los datos de una requisición. Lo usan la creación y la actualización
-- para no repetir las mismas reglas en dos lugares.
CREATE OR ALTER PROCEDURE dbo.usp_ValidarDatosRequisicion
    @IdSolicitante  INT,
    @IdDepartamento INT,
    @Justificacion  NVARCHAR(500),
    @Subtotal       DECIMAL(18,2),
    @Impuestos      DECIMAL(18,2),
    @Total          DECIMAL(18,2),
    @Detalles       dbo.TipoDetalleRequisicion READONLY
AS
BEGIN
    SET NOCOUNT ON;

    IF LTRIM(RTRIM(ISNULL(@Justificacion, N''))) = N''
        THROW 50001, N'La justificación de la compra es obligatoria.', 1;

    IF NOT EXISTS (SELECT 1 FROM dbo.Solicitantes WHERE IdSolicitante = @IdSolicitante)
        THROW 50002, N'El solicitante indicado no existe.', 1;

    IF NOT EXISTS (SELECT 1 FROM dbo.Departamentos WHERE IdDepartamento = @IdDepartamento)
        THROW 50003, N'El departamento indicado no existe.', 1;

    IF NOT EXISTS (SELECT 1 FROM @Detalles)
        THROW 50004, N'La requisición debe tener al menos un artículo.', 1;

    IF EXISTS (SELECT 1 FROM @Detalles WHERE Cantidad <= 0)
        THROW 50005, N'La cantidad de cada artículo debe ser mayor que cero.', 1;

    IF EXISTS (SELECT 1 FROM @Detalles WHERE PrecioUnitario <= 0)
        THROW 50006, N'El precio unitario de cada artículo debe ser mayor que cero.', 1;

    IF EXISTS (SELECT IdArticulo FROM @Detalles GROUP BY IdArticulo HAVING COUNT(*) > 1)
        THROW 50007, N'No se permiten artículos duplicados en la misma requisición.', 1;

    IF EXISTS (SELECT 1
               FROM @Detalles d
               LEFT JOIN dbo.Articulos a ON a.IdArticulo = d.IdArticulo
               WHERE a.IdArticulo IS NULL OR a.Activo = 0)
        THROW 50008, N'Algún artículo no existe en el catálogo o está inactivo.', 1;

    -- Los montos recibidos deben coincidir con los detalles enviados.
    IF @Subtotal <> (SELECT SUM(CAST(Cantidad * PrecioUnitario AS DECIMAL(18,2))) FROM @Detalles)
        THROW 50009, N'El subtotal no coincide con la suma de los importes de los artículos.', 1;

    IF @Impuestos < 0 OR @Total <> @Subtotal + @Impuestos
        THROW 50010, N'Los impuestos o el total no son consistentes con el subtotal.', 1;
END
GO

-- Guarda la cabecera y los detalles en una sola transacción.
CREATE OR ALTER PROCEDURE dbo.usp_CrearRequisicion
    @IdSolicitante  INT,
    @IdDepartamento INT,
    @Justificacion  NVARCHAR(500),
    @Subtotal       DECIMAL(18,2),
    @Impuestos      DECIMAL(18,2),
    @Total          DECIMAL(18,2),
    @Detalles       dbo.TipoDetalleRequisicion READONLY,
    @IdRequisicion  INT          OUTPUT,
    @Codigo         NVARCHAR(20) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @anio INT = YEAR(SYSDATETIME());
    DECLARE @numero INT;
    DECLARE @estadoCreada TINYINT = 1;

    BEGIN TRY
        EXEC dbo.usp_ValidarDatosRequisicion
            @IdSolicitante  = @IdSolicitante,
            @IdDepartamento = @IdDepartamento,
            @Justificacion  = @Justificacion,
            @Subtotal       = @Subtotal,
            @Impuestos      = @Impuestos,
            @Total          = @Total,
            @Detalles       = @Detalles;

        BEGIN TRANSACTION;

        -- Obtiene el siguiente número del año; si la transacción falla, el número no se consume.
        UPDATE dbo.ContadorRequisiciones WITH (UPDLOCK, HOLDLOCK)
        SET @numero = UltimoNumero = UltimoNumero + 1
        WHERE Anio = @anio;

        IF @@ROWCOUNT = 0
        BEGIN
            SET @numero = 1;
            INSERT INTO dbo.ContadorRequisiciones (Anio, UltimoNumero)
            VALUES (@anio, @numero);
        END

        SET @Codigo = N'REQ-' + CAST(@anio AS NVARCHAR(4)) + N'-'
                    + RIGHT(N'00000' + CAST(@numero AS NVARCHAR(10)), 5);

        INSERT INTO dbo.Requisiciones
            (Codigo, IdSolicitante, IdDepartamento, Justificacion, IdEstado, Subtotal, Impuestos, Total)
        VALUES
            (@Codigo, @IdSolicitante, @IdDepartamento, LTRIM(RTRIM(@Justificacion)),
             @estadoCreada, @Subtotal, @Impuestos, @Total);

        SET @IdRequisicion = SCOPE_IDENTITY();

        INSERT INTO dbo.DetalleRequisicion (IdRequisicion, IdArticulo, Cantidad, PrecioUnitario)
        SELECT @IdRequisicion, IdArticulo, Cantidad, PrecioUnitario
        FROM @Detalles;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

-- Reemplaza la cabecera y los detalles de una requisición que todavía está en estado Creada.
CREATE OR ALTER PROCEDURE dbo.usp_ActualizarRequisicion
    @IdRequisicion  INT,
    @IdSolicitante  INT,
    @IdDepartamento INT,
    @Justificacion  NVARCHAR(500),
    @Subtotal       DECIMAL(18,2),
    @Impuestos      DECIMAL(18,2),
    @Total          DECIMAL(18,2),
    @Detalles       dbo.TipoDetalleRequisicion READONLY
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @estadoCreada TINYINT = 1;
    DECLARE @estadoActual TINYINT;
    DECLARE @mensaje NVARCHAR(200);

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Bloquea la fila para que nadie cambie el estado mientras se actualiza.
        SELECT @estadoActual = IdEstado
        FROM dbo.Requisiciones WITH (UPDLOCK, HOLDLOCK)
        WHERE IdRequisicion = @IdRequisicion;

        IF @estadoActual IS NULL
            THROW 50040, N'La requisición indicada no existe.', 1;

        IF @estadoActual <> @estadoCreada
        BEGIN
            SET @mensaje = N'Solo se puede modificar una requisición en estado Creada. Estado actual: '
                         + (SELECT Nombre FROM dbo.Estados WHERE IdEstado = @estadoActual) + N'.';
            THROW 50041, @mensaje, 1;
        END

        EXEC dbo.usp_ValidarDatosRequisicion
            @IdSolicitante  = @IdSolicitante,
            @IdDepartamento = @IdDepartamento,
            @Justificacion  = @Justificacion,
            @Subtotal       = @Subtotal,
            @Impuestos      = @Impuestos,
            @Total          = @Total,
            @Detalles       = @Detalles;

        UPDATE dbo.Requisiciones
        SET IdSolicitante  = @IdSolicitante,
            IdDepartamento = @IdDepartamento,
            Justificacion  = LTRIM(RTRIM(@Justificacion)),
            Subtotal       = @Subtotal,
            Impuestos      = @Impuestos,
            Total          = @Total
        WHERE IdRequisicion = @IdRequisicion;

        DELETE FROM dbo.DetalleRequisicion WHERE IdRequisicion = @IdRequisicion;

        INSERT INTO dbo.DetalleRequisicion (IdRequisicion, IdArticulo, Cantidad, PrecioUnitario)
        SELECT @IdRequisicion, IdArticulo, Cantidad, PrecioUnitario
        FROM @Detalles;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

-- Cambia el estado solo si la transición existe en TransicionesEstado.
CREATE OR ALTER PROCEDURE dbo.usp_CambiarEstadoRequisicion
    @IdRequisicion INT,
    @IdEstadoNuevo TINYINT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @estadoActual TINYINT;
    DECLARE @mensaje NVARCHAR(200);

    BEGIN TRY
        BEGIN TRANSACTION;

        SELECT @estadoActual = IdEstado
        FROM dbo.Requisiciones WITH (UPDLOCK, HOLDLOCK)
        WHERE IdRequisicion = @IdRequisicion;

        IF @estadoActual IS NULL
            THROW 50020, N'La requisición indicada no existe.', 1;

        IF NOT EXISTS (SELECT 1 FROM dbo.Estados WHERE IdEstado = @IdEstadoNuevo)
            THROW 50021, N'El estado de destino no existe.', 1;

        IF NOT EXISTS (SELECT 1
                       FROM dbo.TransicionesEstado
                       WHERE IdEstadoOrigen = @estadoActual
                         AND IdEstadoDestino = @IdEstadoNuevo)
        BEGIN
            SET @mensaje = N'No se permite pasar de '
                         + (SELECT Nombre FROM dbo.Estados WHERE IdEstado = @estadoActual)
                         + N' a '
                         + (SELECT Nombre FROM dbo.Estados WHERE IdEstado = @IdEstadoNuevo) + N'.';
            THROW 50022, @mensaje, 1;
        END

        UPDATE dbo.Requisiciones
        SET IdEstado = @IdEstadoNuevo
        WHERE IdRequisicion = @IdRequisicion;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE dbo.usp_RegistrarArticulo
    @Codigo           NVARCHAR(20),
    @Nombre           NVARCHAR(150),
    @PrecioReferencia DECIMAL(18,2),
    @IdArticulo       INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    SET @Codigo = LTRIM(RTRIM(ISNULL(@Codigo, N'')));
    SET @Nombre = LTRIM(RTRIM(ISNULL(@Nombre, N'')));

    IF @Codigo = N''
        THROW 50030, N'El código del artículo es obligatorio.', 1;

    IF @Nombre = N''
        THROW 50031, N'El nombre del artículo es obligatorio.', 1;

    IF @PrecioReferencia IS NULL OR @PrecioReferencia <= 0
        THROW 50032, N'El precio de referencia debe ser mayor que cero.', 1;

    IF EXISTS (SELECT 1 FROM dbo.Articulos WHERE Codigo = @Codigo)
        THROW 50033, N'Ya existe un artículo con ese código.', 1;

    INSERT INTO dbo.Articulos (Codigo, Nombre, PrecioReferencia)
    VALUES (@Codigo, @Nombre, @PrecioReferencia);

    SET @IdArticulo = SCOPE_IDENTITY();
END
GO

CREATE OR ALTER PROCEDURE dbo.usp_ModificarArticulo
    @IdArticulo       INT,
    @Codigo           NVARCHAR(20),
    @Nombre           NVARCHAR(150),
    @PrecioReferencia DECIMAL(18,2),
    @Activo           BIT
AS
BEGIN
    SET NOCOUNT ON;

    SET @Codigo = LTRIM(RTRIM(ISNULL(@Codigo, N'')));
    SET @Nombre = LTRIM(RTRIM(ISNULL(@Nombre, N'')));

    IF NOT EXISTS (SELECT 1 FROM dbo.Articulos WHERE IdArticulo = @IdArticulo)
        THROW 50034, N'El artículo indicado no existe.', 1;

    IF @Codigo = N''
        THROW 50030, N'El código del artículo es obligatorio.', 1;

    IF @Nombre = N''
        THROW 50031, N'El nombre del artículo es obligatorio.', 1;

    IF @PrecioReferencia IS NULL OR @PrecioReferencia <= 0
        THROW 50032, N'El precio de referencia debe ser mayor que cero.', 1;

    IF EXISTS (SELECT 1 FROM dbo.Articulos WHERE Codigo = @Codigo AND IdArticulo <> @IdArticulo)
        THROW 50033, N'Ya existe otro artículo con ese código.', 1;

    UPDATE dbo.Articulos
    SET Codigo = @Codigo,
        Nombre = @Nombre,
        PrecioReferencia = @PrecioReferencia,
        Activo = @Activo
    WHERE IdArticulo = @IdArticulo;
END
GO

/* =====================================================================
   5. VISTAS
   Las dos vistas de reporte solo devuelven requisiciones Aprobadas
   (IdEstado = 3), así que ni siquiera una consulta directa a la vista
   puede obtener el reporte de una requisición que no esté aprobada.
   ===================================================================== */

CREATE OR ALTER VIEW dbo.vw_ReporteRequisicionCabecera
AS
SELECT r.IdRequisicion,
       r.Codigo        AS CodigoRequisicion,
       r.Fecha,
       s.Nombre        AS Solicitante,
       d.Nombre        AS Departamento,
       r.Justificacion,
       e.Nombre        AS Estado,
       r.Subtotal,
       r.Impuestos,
       r.Total
FROM dbo.Requisiciones r
JOIN dbo.Solicitantes  s ON s.IdSolicitante  = r.IdSolicitante
JOIN dbo.Departamentos d ON d.IdDepartamento = r.IdDepartamento
JOIN dbo.Estados       e ON e.IdEstado       = r.IdEstado
WHERE r.IdEstado = 3;
GO

CREATE OR ALTER VIEW dbo.vw_ReporteRequisicionDetalle
AS
SELECT r.IdRequisicion,
       r.Codigo          AS CodigoRequisicion,
       a.Codigo          AS CodigoArticulo,
       a.Nombre          AS NombreArticulo,
       dr.Cantidad,
       dr.PrecioUnitario,
       dr.Importe
FROM dbo.Requisiciones r
JOIN dbo.DetalleRequisicion dr ON dr.IdRequisicion = r.IdRequisicion
JOIN dbo.Articulos          a  ON a.IdArticulo     = dr.IdArticulo
WHERE r.IdEstado = 3;
GO

-- Vista para el formulario de consulta: incluye requisiciones en cualquier estado.
CREATE OR ALTER VIEW dbo.vw_ConsultaRequisiciones
AS
SELECT r.IdRequisicion,
       r.Codigo         AS CodigoRequisicion,
       r.Fecha,
       r.IdSolicitante,
       s.Nombre         AS Solicitante,
       r.IdDepartamento,
       d.Nombre         AS Departamento,
       r.Justificacion,
       r.IdEstado,
       e.Nombre         AS Estado,
       r.Subtotal,
       r.Impuestos,
       r.Total
FROM dbo.Requisiciones r
JOIN dbo.Solicitantes  s ON s.IdSolicitante  = r.IdSolicitante
JOIN dbo.Departamentos d ON d.IdDepartamento = r.IdDepartamento
JOIN dbo.Estados       e ON e.IdEstado       = r.IdEstado;
GO

-- Detalle de cualquier requisición, para abrirla desde la consulta o editarla.
CREATE OR ALTER VIEW dbo.vw_ConsultaDetalleRequisicion
AS
SELECT dr.IdDetalle,
       dr.IdRequisicion,
       dr.IdArticulo,
       a.Codigo          AS CodigoArticulo,
       a.Nombre          AS NombreArticulo,
       dr.Cantidad,
       dr.PrecioUnitario,
       dr.Importe
FROM dbo.DetalleRequisicion dr
JOIN dbo.Articulos a ON a.IdArticulo = dr.IdArticulo;
GO

PRINT N'Base de datos SistemaRequisiciones lista.';
GO

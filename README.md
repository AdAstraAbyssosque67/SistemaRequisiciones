# Sistema de Gestión de Requisiciones de Compra

Proyecto del Examen Parcial #1 de **Arquitectura de Software (ISW-114)**, Universidad Central del Este.

Aplicación de escritorio para gestionar requisiciones (solicitudes de compra) con arquitectura de N capas.

## Tecnologías

- C# y Windows Forms (.NET Framework 4.8, Visual Studio 2022)
- SQL Server 2016 SP1 o superior (Express o LocalDB sirven)
- ADO.NET con `System.Data.SqlClient`
- Microsoft ReportViewer (reporte `.rdlc`)

## Reglas técnicas del examen

- Toda escritura se hace con **procedimientos almacenados**.
- Los reportes se generan **solo desde vistas**.
- Patrones: **Singleton**, **Builder**, **Strategy** y **State**.
- El reporte final solo se genera para requisiciones en estado **Aprobada**.

## Estructura del repositorio

```
SistemaRequisiciones/
├── Database/
│   ├── 01_CrearBaseDeDatos.sql      Tablas, procedimientos, vistas y datos iniciales
│   └── 02_PruebasBaseDeDatos.sql    Verificación y pruebas de la base de datos
├── Docs/
│   └── Decisiones-de-diseno.md      Supuestos, transiciones de estado y arquitectura
└── src/                             Solución de Visual Studio (se agrega en las siguientes fases)
```

Proyectos previstos dentro de `src/`:

| Proyecto | Responsabilidad |
|---|---|
| `SistemaRequisiciones.Entidades` | Clases de datos y configuración (Singleton) |
| `SistemaRequisiciones.Datos` | Acceso a SQL Server: procedimientos y vistas |
| `SistemaRequisiciones.Negocio` | Reglas de negocio, Builder, Strategy y State |
| `SistemaRequisiciones.Presentacion` | Formularios de Windows Forms |

## Cómo crear la base de datos

1. Abre SQL Server Management Studio y conéctate a tu instancia (por ejemplo `localhost`, `.\SQLEXPRESS` o `(localdb)\MSSQLLocalDB`).
2. Abre `Database/01_CrearBaseDeDatos.sql` y ejecútalo completo (F5). Puede ejecutarse varias veces sin duplicar datos.
3. Abre `Database/02_PruebasBaseDeDatos.sql` y ejecuta cada bloque para comprobar que todo funciona. Los resultados esperados están en los comentarios de cada bloque.

> Guarda siempre los scripts con codificación UTF-8 con BOM para que SSMS muestre bien las tildes.

## Flujo de trabajo con Git

- Rama principal: `main` (siempre estable).
- Una rama por fase o funcionalidad, por ejemplo `fase-3-entidades-patrones`, y se une a `main` al terminar.
- Mensajes de commit cortos y en español, por ejemplo: `Agrega RequisicionBuilder`.
- No subir contraseñas ni cadenas de conexión con credenciales.

## Estado del proyecto

- [x] Fase 1: análisis y diseño
- [x] Fase 2: base de datos
- [ ] Fase 3: entidades y patrones
- [ ] Fase 4: capa de datos
- [ ] Fase 5: capa de negocio
- [ ] Fase 6: interfaz gráfica
- [ ] Fase 7: ReportViewer
- [ ] Fase 8: integración y pruebas
- [ ] Fase 9: documentación académica

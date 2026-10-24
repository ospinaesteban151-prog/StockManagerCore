Documentacion





## Integrante 5 (Mondragon) – Interfaz (WinForms) y Control de Errores

### Responsabilidades cumplidas

- Diseño del formulario principal (`frmPrincipal`) con navegación mediante `MenuStrip`.
- Estructura del menú implementada en **todos** los formularios del sistema:
  - **Archivo** → Salir
  - **Gestion** → Categorias / Productos
  - **Reportes** → Stock Bajo / Valorizacion del Inventario
- Cada formulario se abre de forma **independiente** y muestra la misma barra de menú.
- Botón **Salir** con cuadro de confirmación (`MessageBox` con opciones OK/Cancel) antes de cerrar la aplicación.
- Creación de la clase centralizada `Utilidades.cs` con el método:
  ```csharp
  public static void MostrarError(Exception ex)
  
##Aclaraciones
- Los clics del menú (Categorías, Productos, Stock Bajo, Valorización) aún no abren los formularios correspondientes
- En el Label que tiene "$0.00" del Form Reportes, solo asígnenle valor a ese label
- en la clase Utilidades.cs esta el Metodo para la Excepcion





## Integrante 1 (Marlon) – Base de Datos y Arquitectura Base

* Diseño y creación de la base de datos `StockManagerDB` en PostgreSQL con las tablas `Categorias` y `Productos`.
* Implementación de integridad de datos directamente en el motor SQL con `FOREIGN KEY` (ON DELETE RESTRICT) y restricciones `CHECK` (precio > 0 y stock >= 0).
* Estructuración del proyecto en capas lógicas creando las carpetas: `Modelos`, `Datos`, `Negocio` y `Database`.
* Creación de las clases molde `Categoria.cs` y `Producto.cs` en la capa de `Modelos`.
* Configuración de la cadena de conexión de forma segura mediante el archivo `appsettings.json`.
* Elaboración del script de poblado inicial (`seed_data.sql`) en la carpeta `Database` con registros de prueba.
* Creación de la clase centralizada `ConexionBD.cs` en la capa de `Datos` con el método:

public static NpgsqlConnection ObtenerConexion()


El sistema utiliza un modelo de base de datos relacional (PostgreSQL) estructurado en dos tablas principales conectadas mediante integridad referencial.

Tabla categorias
Almacena los grupos o clasificaciones del inventario.

id: Tipo serial (Llave primaria autoincrementable).

nombre: Tipo varchar(100) (Texto obligatorio y único).

descripcion: Tipo text (Texto opcional sin límite estricto).

Tabla productos
Almacena los artículos físicos/digitales de la empresa y sus cantidades.

id: Tipo serial (Llave primaria autoincrementable).

nombre: Tipo varchar(150) (Texto obligatorio).

precio: Tipo decimal(10, 2) (Obligatorio, con restricción CHECK para garantizar valores mayores a 0).

stock: Tipo int (Obligatorio, con restricción CHECK para evitar inventarios negativos).

categoriaid: Tipo int (Llave foránea que enlaza con el id de la categoría. Utiliza ON DELETE RESTRICT para impedir que se borre una categoría si tiene productos asociados).

## Aclaraciones

*Obligatorio:** Cada integrante debe abrir el archivo `appsettings.json` y cambiar la parte de `Password=tu_contraseña` por su clave real de PostgreSQL local.

* Verifiquen siempre que, en las propiedades de `appsettings.json`, la opción **Copiar en el directorio de salida** esté marcada como **Copiar si es posterior**; de lo contrario, la conexión fallará.

* Para programar el CRUD, no necesitan reescribir la conexión. Solo llamen a `var conexion = ConexionBD.ObtenerConexion();` y recuerden ejecutar `conexion.Close();` al finalizar sus consultas.




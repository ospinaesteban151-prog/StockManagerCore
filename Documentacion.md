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
- En la rama "Interfaces" esta el .gitignore (no se si sea relevante)
- en la clase Utilidades.cs esta el Metodo para la Excepcion

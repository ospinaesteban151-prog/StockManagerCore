# 📦 StockManager Core

**StockManager Core** es una solución robusta de software de escritorio (Windows Forms) desarrollada en C# y SQL. Está diseñada para la gestión integral de inventarios de pequeñas y medianas empresas, permitiendo controlar categorías, administrar existencias, aplicar estrictas reglas de negocio y generar reportes analíticos exportables mediante una interfaz visual e intuitiva.

## 🎯 Objetivo del Sistema

Proveer un entorno rápido, confiable y seguro para el control de inventario mediante Programación Orientada a Objetos (POO) y persistencia en bases de datos relacionales, garantizando la integridad de los datos a través de una interfaz gráfica amigable, sin depender de APIs web.

## ✨ Características Principales

* **Gestión de Categorías:** CRUD completo con validación contra duplicados y restricciones de eliminación de seguridad.

* **Control de Productos:** Administración detallada de inventario, asegurando stock y precios válidos, y vinculación obligatoria a categorías existentes.

* **Control de Stock Seguro:** Operaciones atómicas para entradas y salidas de mercancía garantizando que el stock nunca sea negativo.

* **Reportes Analíticos y Exportación:** Generación de alertas de stock bajo y valorización total del inventario (mediante consultas SQL avanzadas tipo `JOIN` y `GROUP BY`), con exportación automática a archivos planos (`.txt` / `.csv`).

* **Interfaz Robusta (Windows Forms):** Navegación fluida mediante ventanas y controles interactivos con manejo global de excepciones para evitar cierres inesperados por errores de usuario (ej. validación de TextBoxes).

## 🛠️ Tecnologías y Arquitectura

* **Lenguaje:** C# (.NET)
* **Interfaz Gráfica:** Windows Forms (WinForms)
* **Base de Datos:** SQL Server / PostgreSQL
* **Acceso a Datos:** ADO.NET / Entity Framework Core
* **Arquitectura:** Separación de responsabilidades en capas lógicas (Modelos, Datos, Negocio, Presentación).

## 👥 Equipo y Módulos de Desarrollo

Este proyecto fue estructurado modularmente y desarrollado por un equipo de 5 personas:

| Integrante | Rol / Módulo | Funcionalidad Principal | 
| ----- | ----- | ----- | 
| **Integrante 1** | Base de Datos & Arquitectura | Diseño del modelo relacional, llaves primarias/foráneas y conexión centralizada. | 
| **Integrante 2** | Gestión de Categorías | CRUD de categorías, validación de duplicados y restricción de borrado. | 
| **Integrante 3** | Gestión de Productos | CRUD de productos, validación de existencias y actualización de stock. | 
| **Integrante 4** | Reportes SQL Avanzados | Consultas relacionales (JOIN/agregaciones) y exportación de archivos `.txt/.csv`. | 
| **Integrante 5** | Interfaz (WinForms) & Errores | Diseño de formularios, integración visual y captura de excepciones (`try-catch`). | 

## 📋 Requerimientos del Sistema

### Requerimientos Funcionales (RF)

* **RF-01 (Categorías):** Registro, consulta, edición y baja. Bloqueo de eliminación si existen productos asociados.
* **RF-02 (Productos):** Registro, actualización y consulta vinculados obligatoriamente a una categoría válida.
* **RF-03 (Control de Stock):** Operaciones de suma/resta de existencias sin permitir valores negativos ni precios en 0.
* **RF-04 (Reportes Analíticos):** Alertas de bajo stock (≤ 5 unidades) y cálculo de la valorización total.
* **RF-05 (Exportación):** Generación física de archivos en el directorio local `Reportes/`.

### Requerimientos No Funcionales (RNF)

* **RNF-01 (Tolerancia a Fallos):** El sistema captura entradas inválidas (ej. letras por números en un campo de texto) mostrando alertas sin cerrarse (Crash-proof).
* **RNF-02 (Integridad de Datos):** Restricciones relacionales (`FOREIGN KEY`, `CHECK`) aplicadas directamente en el motor SQL.
* **RNF-03 (Mantenibilidad):** Código con alta cohesión y bajo acoplamiento gracias a la división en capas lógicas.

## 🚀 Cómo ejecutar el proyecto

1. Clona este repositorio:
   ```bash
   git clone https://github.com/tu-usuario/StockManager-Core.git
   ```
2. Configura tu cadena de conexión en el archivo de configuración (ej. `app.config` o `appsettings.json`).
3. Ejecuta el script SQL incluido en la carpeta `Database/` para inicializar las tablas y restricciones.
4. Abre la solución `.sln` en **Visual Studio**.
5. Compila y ejecuta la aplicación presionando `F5` o el botón "Iniciar".
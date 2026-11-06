Manual Técnico

Sistema de Gestión de Citas

1. Descripción general

El sistema de Gestión de Citas es una aplicación de escritorio desarrollada en lenguaje C#, utilizando Windows Forms y el entorno de desarrollo Visual Studio.

El proyecto tiene como propósito facilitar la administración de clientes y citas mediante una interfaz gráfica.

2. Tecnologías utilizadas

- Lenguaje de programación: C#.
- Interfaz gráfica: Windows Forms.
- Entorno de desarrollo: Visual Studio.
- Control de versiones: Git.
- Repositorio remoto: GitHub.
- Documentación: Markdown.

3. Estructura del proyecto

El proyecto contiene los siguientes archivos y elementos principales:

- Form1.cs: contiene la pantalla principal del sistema y permite acceder al registro de clientes.
- FormRegistroClientes.cs: contiene la lógica para registrar clientes y validar sus datos.
- Program.cs: contiene el punto de entrada de la aplicación.
- Dependencies: contiene las dependencias necesarias para el proyecto.
- docs: carpeta destinada a almacenar la documentación del sistema.

4. Funcionamiento de los formularios

4.1 Formulario principal

El formulario principal muestra el acceso al sistema y contiene un botón para ingresar al módulo de registro de clientes.

Al presionar el botón, se crea una instancia del formulario de registro y se muestra mediante el método "Show()".

4.2 Formulario de registro de clientes

Este formulario permite ingresar los siguientes datos:

- Nombre.
- Teléfono.
- Correo electrónico.

El proceso de registro utiliza el evento "btnRegistrar_Click", que ejecuta las validaciones y procesa la información ingresada.

5. Validaciones implementadas

El sistema cuenta con las siguientes validaciones:

- Verificación de campos obligatorios.
- Validación del teléfono mediante expresiones regulares, permitiendo entre 8 y 15 dígitos.
- Validación básica del formato del correo electrónico.
- Mensajes informativos mediante "MessageBox.Show()".

Cuando el registro es exitoso, se muestra un mensaje de confirmación y se limpian los campos del formulario.

6. Manejo de datos

Actualmente, los clientes registrados se almacenan temporalmente en una colección de tipo "List<string>".

La lista se encuentra declarada dentro del formulario de registro.

Nota: esta implementación mantiene los datos en memoria durante la ejecución y no utiliza todavía una base de datos ni almacenamiento permanente.

7. Control de versiones

El proyecto utiliza Git y GitHub para administrar los cambios realizados por los integrantes del equipo.

Se trabaja mediante ramas para organizar el desarrollo de funcionalidades y documentación, facilitando la integración de los aportes de cada integrante.

8. Consideraciones técnicas

- Mantener los formularios organizados.
- Utilizar nombres descriptivos para variables, métodos y controles.
- Validar la información ingresada por el usuario.
- Mantener actualizada la documentación.
- Revisar los cambios antes de integrarlos a la rama principal.

9. Conclusión

El proyecto cuenta con una estructura inicial de Windows Forms, navegación entre formularios y funcionalidad de registro de clientes con validaciones básicas.

Su desarrollo puede ampliarse mediante la integración de los módulos de citas, consultas y otras funcionalidades del sistema.
# test_de_unidad_ocultos

¿Necesitas compartir pruebas unitarias (unit test) sin que los desarrolladores de tu equipo o tus alumnos o la IA, puedan acceder al código fuente? 

En este tutorial paso a paso aprenderás cómo ocultar la implementación de tus tests de unidad en .NET / C# utilizando DLLs compiladas y una clase proxy por herencia.

Esta técnica es ideal para docentes que preparan exámenes prácticos con TDD (Test-Driven Development), pruebas técnicas de selección o proyectos con información sensible.

📌 Aprenderás:

- Por qué y cuándo conviene proteger el código de tus pruebas unitarias.
- Cómo compilar los tests en una DLL independiente.
- Creación de un proyecto Test Proxy y vinculación por herencia.
- Cómo referenciar el proyecto a evaluar y eliminar el código fuente original (de la solución y del sistema de archivos).
- Verificación y ejecución en el Test Explorer sin acceso al código.
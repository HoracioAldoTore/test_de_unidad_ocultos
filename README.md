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

**Como ocultar el código fuente de los tests unitarios, pero sin anular su ejecución.**
**Pasoa a paso.**
1-Copiar el directorio donde está el código fuente "AppParcial1 (Visible)" a "AppParcial1 (Oculto)".   
2-Generar Parcial1.Tests.dll   
3-Crear un nuevo proyecto de test, llamado "TestsProxy"   
4-Copiar los tests originales compilados "Parcial1.Tests.dll" a la raíz del proyecto TestsProxy.   
5-Agregar una referencia a "Parcial1.Tests.dll".   
6-Heredar de Parcial1.Tests.Test1 que se encuentra en la dll ("Parcial1.Tests.dll").   
7-Eliminar los test o métodos de la clase "TestsProxy.Test1"   
8-Agregar en "TestsProxy" la referencia al proyecto "AppParcial1"   
9-Remover Parcial1.Tests de la solución.   
10-Remover Parcial1.Tests del file system.

# Laboratorio3_progra1

## Analisis del Programa
###Tareas Repetitivas
Las tareas de AgregarEstudiantes, MostrarLaListadeEstudiantes, CalcularPromedio, MostrarEstudianteConCalificacionMasAlta fueron colocadas en funciones para evitar la
repeticion de las mismas tareas.

### Variables Locales vs Variables Globales
Discutir cuándo es apropiado usar variables locales y cuándo usar variables globales.
+ ¿Qué datos deben ser accesibles en todo el programa?

Los datos que se deberian de utilizar como globales serian las List 

+ ¿Qué datos solo son necesarios dentro de una función específica?

Los datos que seran necesarios son aquellos que solamente seran utilizados u operados dentro de la función con las variables Nombre, Calificacion, etc. 

## Variables Locales y Globales

+ ¿Qué datos necesitan ser compartidos entre múltiples funciones?

Los datos que deben ser accesibles por varias funciones son aquellos que representan el estado actual del programa y que deben ser accesibles cuando sean llamados por las funciones, por ejemplo las listas

+ ¿Qué datos solo son relevantes dentro de una función específica?
 
Son aquellos datos que unicamente son relevantes dentro de la funcion ya que son llamados por esta misma. La mayoria de estas siendo variables locales que son creadas y destruidas en la funcion.


## Preguntas Guia
1. ¿Qué ventajas tiene dividir el código en funciones?
    Aumenta la legibilidad del codigo al separar las tareas en bloques, permitiendo reutilizar las tareas repetitivas en el codigo principal. Ademas, mejora la depuracion
    de errores al tener que corregirlos por bloques de codigo y no en el programa principal.

2. ¿Por qué es importante limitar el uso de variables globales?
    Evita conflictos al declarar o reutilizar las variables. Tambien, pueden ocupar espacio en memoria innecesariamente, especialmente cuando la variable se utiliza temporalmente en una unica tarea especifica.

3. ¿Cómo se puede mejorar la legibilidad del código?
Documentar el código con comentarios claros, modularizar creando funciones reutilizables y usar nombres descriptivos para variables y funciones son buenas prácticas que mejoran la comprensión, mantenimiento y colaboración del código en el desarrollo del proyecto.

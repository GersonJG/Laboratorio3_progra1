using Microsoft.VisualBasic.FileIO;

List<string> estudiantes = new List<string>();
List<double> calificaciones = new List<double>();

double comprobacion(double n1)
{
    while (!double.TryParse(Console.ReadLine(), out n1))
    {
        Console.WriteLine("Por favor, ingrese un número válido.");
        Console.Write("Ingrese el numero: ");
    }
    return n1;
}

int Rango(int n1)
{
    int comprobacionint(int n1)
    {
        while (!int.TryParse(Console.ReadLine(), out n1))
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
            Console.Write("Ingrese el numero: ");
        }
        return n1;
    }

    n1 =comprobacionint(n1);
    while (n1 < 1 || n1 > 5)
    {
        Console.WriteLine("Por favor, ingrese una opcion valida.");
        Console.Write("Ingrese el numero: ");
        n1 = comprobacionint(n1);
    }
    return n1;
}
void Menu()
{
    // Esta funcion muestra el menu de opciones
    Console.WriteLine("1. Agregar estudiante");
    Console.WriteLine("2. Mostrar lista de estudiantes");
    Console.WriteLine("3. Calcular promedio de calificaciones");
    Console.WriteLine("4. Mostrar estudiante con la calificación más alta");
    Console.WriteLine("5. Salir");
    Console.Write("Seleccione una opción: ");

}

void AgregarEstudiante()
{
    //Esta funcion permite agregar un estudiante a la lista
    Console.Write("Ingrese el nombre del estudiante: ");
    string nombre = Console.ReadLine();
    Console.Write("Ingrese la calificación del estudiante: ");
    double calificacion = 0;
    calificacion = comprobacion(calificacion);
    estudiantes.Add(nombre);
    calificaciones.Add(calificacion);
    Console.WriteLine("Estudiante agregado correctamente.\n");
}

void MostrarEstudiantes()
{
    //Esta funcion muestra la lista de estudiantes
    if (estudiantes.Count == 0)
    {
        Console.WriteLine("No hay estudiantes registrados.");
    }
    else
    {
        Console.WriteLine("\nLista de estudiantes:");
        for (int i = 0; i < estudiantes.Count; i++)
        {
            Console.WriteLine($"{estudiantes[i]} - Calificación: {calificaciones[i]}");
        }
    }
}


void CalcularPromedio()
{
    //Esta funcion calcula el promedio de las calificaciones
    if (calificaciones.Count == 0)
    {
        Console.WriteLine("No hay calificaciones registradas.");
    }
    else
    {
        double suma = 0;
        foreach (double calificacion in calificaciones)
        {
            suma += calificacion;
        }
        double promedio = suma / calificaciones.Count;
        Console.WriteLine($"El promedio de calificaciones es: {promedio}");
    }
}

void MostrarEstudianteMax()
{
    //Esta funcion muestra el estudiante con la calificacion mas alta
    if (calificaciones.Count == 0)
    {
        Console.WriteLine("No hay calificaciones registradas.");
    }
    else
    {
        double maxCalificacion = calificaciones[0];
        string estudianteMax = estudiantes[0];
        for (int i = 1; i < calificaciones.Count; i++)
        {
            if (calificaciones[i] > maxCalificacion)
            {
                maxCalificacion = calificaciones[i];
                estudianteMax = estudiantes[i];
            }
        }
        Console.WriteLine($"El estudiante con la calificación más alta es: {estudianteMax} con {maxCalificacion}");
    }
}

Console.WriteLine("Bienvenido al sistema de gestión de estudiantes.");

while (true)
{
    
    Menu();
    int opcion = 0;
    opcion = Rango(opcion);
    switch (opcion)
    {
        case 1:
            AgregarEstudiante();
            break;

        case 2:
            MostrarEstudiantes();
            break;

        case 3:
            CalcularPromedio();
            break;

        case 4:
            MostrarEstudianteMax();
            break;

        case 5:
            Console.WriteLine("Saliendo del sistema...");
            return;

        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            break;
    }

}
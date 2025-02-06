namespace MonoProceso
{
    class Program
    {
        //Instancia del monoprocesador
        static readonly MonoProcesador procesador = new();

        static void Main()
        {
            bool salir = false;

            while (!salir)
            {
                //Menu para los usuarios
                Console.Clear();
                Console.WriteLine("=== Menú de Tareas ===");
                Console.WriteLine("1. Agregar una tarea");
                Console.WriteLine("2. Ejecutar tareas en cola");
                Console.WriteLine("3. Mostrar tareas en espera");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opción: ");
                string opcion = Console.ReadLine()!;

                switch (opcion)
                {
                    case "1":
                        AgregarTarea();
                        break;
                    case "2":
                        procesador.EjecutarTareas();
                        break;
                    case "3":
                        procesador.MostrarTareas();
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
        //Funcion para agregar tareas al monoprocesador
        static void AgregarTarea()
        {
            Console.Write("Nombre de la tarea: ");
            string nombre = Console.ReadLine()!;

            Console.Write("Duración de la tarea en segundos: ");
            if (int.TryParse(Console.ReadLine(), out int duracion))
            {
                Tarea nuevaTarea = new(nombre, duracion * 1000);
                procesador.AgregarTarea(nuevaTarea);
                Console.WriteLine($"Tarea '{nombre}' agregada a la cola.");
            }
            else
            {
                Console.WriteLine("Duración no válida.");
            }
        }
    }
}
namespace MonoProceso
{
    public class Tarea
    {
        public string Nombre { get; }
        public int Duracion { get; }
        //Constructor
        public Tarea(string nombre, int duracion)
        {
            Nombre = nombre;
            Duracion = duracion;
        }
        //Funcion para ejecutar las tareas
        public void Ejecutar()
        {
            Console.WriteLine($"[{Nombre}] Iniciando...");
            Task.Delay(Duracion).Wait();
            Console.WriteLine($"[{Nombre}] Completada.");
        } 
    }
}
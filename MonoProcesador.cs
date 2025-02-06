namespace MonoProceso
{
    public class MonoProcesador
    {
        //La lista de elementos que se van a ejecutar
        private Queue<Tarea> colaTareas = new Queue<Tarea>();
        //La funcion para agregar las tareas a la queue
        public void AgregarTarea(Tarea tarea)
        {
            colaTareas.Enqueue(tarea);
        }
        //La funcion para ejecutar las tareas
        public void EjecutarTareas()
        {
            if (colaTareas.Count == 0)
            {
                Console.WriteLine("No hay tareas presentes en la cola.");
                return;
            }
            while (colaTareas.Count > 0)
            {
                Tarea tarea = colaTareas.Dequeue();
                tarea.Ejecutar();
            }
        }
        //Muestra la cola antes de ejecutar, para ver las tareas y su duracion
        public void MostrarTareas()
        {
            if (colaTareas.Count == 0)
            {
                Console.WriteLine("No hay tareas en espera.");
                return;
            }

            Console.WriteLine("=== Tareas en espera ===");
            foreach (Tarea tarea in colaTareas)
            {
                Console.WriteLine($"Tarea: {tarea.Nombre}, Duración: {tarea.Duracion} milisegundos");
            }
        }    
    }
}
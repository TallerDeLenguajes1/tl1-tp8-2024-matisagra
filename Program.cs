using Distribuidora;

Console.WriteLine("Ingrese la cantidad de tareas: ");
string cantidad = Console.ReadLine();
int cant;
int.TryParse(cantidad, out cant);

List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();

// carga aleatoria
int indicePendientes = 0;

for (int i = 0; i < cant; i++)
{
    int TareaID = indicePendientes + 1;
    string Descripcion = "blabla";
    int Duracion = new Random().Next(10, 100);
    Tarea tarea = new Tarea(TareaID, Descripcion, Duracion);
    tareasPendientes.Add(tarea);
    indicePendientes++;
}

// mostrar pendientes
foreach (var tareas in tareasPendientes)
{

    Console.WriteLine(tareas.TareaID);
    Console.WriteLine(tareas.Descripcion);
    Console.WriteLine(tareas.Duracion);
}

// mover realizadas
Console.WriteLine("Ingrese el id de la tarea que desea eliminar");
string ingresar = Console.ReadLine();
int id;
int.TryParse(ingresar, out id);

Tarea buscado = tareasPendientes.Find(t => t.TareaID == id);

if (buscado != null)
{
    tareasPendientes.Remove(buscado);
    tareasRealizadas.Add(buscado);
    Console.WriteLine("Tarea Transferida");
}

//mostrar realizadas
foreach (var tareas in tareasRealizadas)
{

    Console.WriteLine(tareas.TareaID);
    Console.WriteLine(tareas.Descripcion);
    Console.WriteLine(tareas.Duracion);
}

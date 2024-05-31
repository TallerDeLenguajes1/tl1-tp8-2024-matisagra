using System.IO.Compression;
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

Console.WriteLine("QUE DESEA HACER?");
Console.WriteLine("1. MOVER TAREAS REALIZADAS");
Console.WriteLine("2. BUSCAR TAREA POR DESCRIPCION");
string op = Console.ReadLine();

string ingresar;
int buscado;
string descrip;


switch (op)
{
    case "1":
        Console.WriteLine("Ingrese el id de la tarea que desea eliminar");
        ingresar = Console.ReadLine();
        int.TryParse(ingresar, out buscado);

        for (int i = 0; i < tareasPendientes.Count; i++)
        {
            if (tareasPendientes[i].TareaID == buscado)
            {
                tareasRealizadas.Add(tareasPendientes[i]);
                tareasPendientes.RemoveAt(i);
                Console.WriteLine("Tarea Transferida");
            }
        }

        break;

    case "2":
        Console.WriteLine("Ingrese la descripcion de la tarea buscada: ");
        descrip = Console.ReadLine();

        for (int i = 0; i < tareasPendientes.Count; i++)
        {
            if (tareasPendientes[i].Descripcion == descrip)
            {
                Console.WriteLine("Tarea encontrada");
                Console.WriteLine(tareasPendientes[i].TareaID);
                Console.WriteLine(tareasPendientes[i].Duracion);

            }
        }


        break;


}


// mostrar pendientes
foreach (var tareas in tareasPendientes)
{
    Console.WriteLine("TAREAS PENDIENTES");
    Console.WriteLine(tareas.TareaID);
    Console.WriteLine(tareas.Descripcion);
    Console.WriteLine(tareas.Duracion);
}

// mover realizadas

//mostrar realizadas
foreach (var tareas in tareasRealizadas)
{
    Console.WriteLine("TAREAS REALIZADAS");
    Console.WriteLine(tareas.TareaID);
    Console.WriteLine(tareas.Descripcion);
    Console.WriteLine(tareas.Duracion);
}

//buscar por descripcion






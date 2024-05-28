using Distribuidora;

Console.WriteLine("Ingrese la cantidad de tareas: ");
string cantidad=Console.ReadLine();
int cant;
int.TryParse(cantidad, out cant);

Tarea[] tareasPendientes = new Tarea[cant];

int Pendientes=0;

for (int i = 0; i < cant; i++)
{
    int TareaID = Pendientes + 1;
    string Descripcion = "blabla";
    int Duracion =  new Random().Next(10, 100);
    tareasPendientes[i] = new Tarea(TareaID, Descripcion, Duracion);
    Pendientes++;
}

foreach (Tarea tareas in tareasPendientes)
{
    Console.WriteLine(tareas.TareaID);
     Console.WriteLine(tareas.Descripcion);
      Console.WriteLine(tareas.Duracion);
}


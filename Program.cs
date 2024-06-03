/* using System.IO.Compression;
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
Console.WriteLine("3. MOSTRAR TAREAS PENDIENTES");
Console.WriteLine("4. MOSTRAR TAREAS REALIZADAS");
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

    case "3":
        foreach (var tareas in tareasPendientes)
        {
            Console.WriteLine("TAREAS PENDIENTES");
            Console.WriteLine(tareas.TareaID);
            Console.WriteLine(tareas.Descripcion);
            Console.WriteLine(tareas.Duracion);
        }


        break;

    case "4":
        foreach (var tareas in tareasRealizadas)
        {
            Console.WriteLine("TAREAS REALIZADAS");
            Console.WriteLine(tareas.TareaID);
            Console.WriteLine(tareas.Descripcion);
            Console.WriteLine(tareas.Duracion);
        }


        break;


} */



using espacioOperacion;
using EspacioCalculadora;
using EspacioTipoOperacion;


MiCalculadora MiCalculadora = new MiCalculadora(); //creo una instancia del objeto MiCalculadora
MiCalculadora.Historial = new List<Operacion>(); //creo una lista de operaciones

int opcion = 0;
do
{
    Console.WriteLine("################################");
    Console.WriteLine("#####  MENU CALCULADORA  #######");
    Console.WriteLine("################################");
    Console.WriteLine("# 1 - SUMAR                    #");
    Console.WriteLine("# 2 - RESTAR                   #");
    Console.WriteLine("# 3 - MULTIPLICAR              #");
    Console.WriteLine("# 4 - DIVIDIR                  #");
    Console.WriteLine("# 5 - LIMPIAR                  #");
    Console.WriteLine("# 6 - HISTORIAL                #");
    Console.WriteLine("################################");
    Console.WriteLine("Ingrese una opcion: ");

    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        double valor, resultadoAnterior = MiCalculadora.Resultado;
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingrese un valor a sumar");
                if (double.TryParse(Console.ReadLine(), out valor))
                {
                    MiCalculadora.Sumar(valor);
                    Console.WriteLine($"Se sumo el valor: {valor}. El resultado es: {MiCalculadora.Resultado}");
                    MiCalculadora.Historial.Add(new Operacion(resultadoAnterior, MiCalculadora.Resultado, TipoOperacion.Suma)); //agrego una operacion al historial
                }
                else
                {
                    Console.WriteLine("Valor Ingresado Incorrecto");
                }
            break;
            case 2:
                Console.WriteLine("Ingrese un valor a Restar");
                if (double.TryParse(Console.ReadLine(), out valor))
                {
                    MiCalculadora.Restar(valor);
                    Console.WriteLine($"Se resto el valor: {valor}. El resultado es: {MiCalculadora.Resultado}");
                    MiCalculadora.Historial.Add(new Operacion(resultadoAnterior, MiCalculadora.Resultado, TipoOperacion.Resta)); //agrego una operacion al historial
                }
                else
                {
                    Console.WriteLine("Valor Ingresado Incorrecto");
                }
            break;
            case 3:
                Console.WriteLine("Ingrese un valor a Multiplicar");
                if (double.TryParse(Console.ReadLine(), out valor))
                {
                    MiCalculadora.Multiplicar(valor);
                    Console.WriteLine($"Se multiplico el valor: {valor}. El resultado es: {MiCalculadora.Resultado}");
                    MiCalculadora.Historial.Add(new Operacion(resultadoAnterior, MiCalculadora.Resultado, TipoOperacion.Multiplicacion)); //agrego una operacion al historial
                }
                else
                {
                    Console.WriteLine("Valor Ingresado Incorrecto");
                }
            break;
            case 4:
                Console.WriteLine("Ingrese un valor para dividir");
                if (double.TryParse(Console.ReadLine(), out valor))
                {
                    if (valor != 0)
                    {
                        MiCalculadora.Dividir(valor);
                        Console.WriteLine($"Se dividio por {valor}. El resultado es: {MiCalculadora.Resultado}");
                        MiCalculadora.Historial.Add(new Operacion(resultadoAnterior, MiCalculadora.Resultado, TipoOperacion.Division)); //agrego una operacion al historial
                    }
                    else
                    {
                        Console.WriteLine("Valor Ingresado Incorrecto ingreso 0 (no se puede dividir por 0)");
                    }
                }
                else
                {
                    Console.WriteLine("Valor Ingresado Incorrecto");
                }
            break;
            case 5:
                MiCalculadora.Limpiar();
                Console.WriteLine($"Se limpio el resultado: {MiCalculadora.Resultado}");
                MiCalculadora.Historial.Add(new Operacion(resultadoAnterior, MiCalculadora.Resultado, TipoOperacion.Limpiar)); //agrego una operacion al historial
            break;
            case 6:
                Console.WriteLine("########  HISTORIAL DE OPERACIONES  #########"); 
                foreach (var op in MiCalculadora.Historial) //recorro la lista
                {
                    Console.WriteLine(op.ShowOperacion()); //muestro operacion con el metodo de cada op
                }
            break;
            default:
            break;
        }
    }
    else{
        Console.WriteLine("Opcion ingresada incorrecta");
    }
    Console.WriteLine("Desea continuar operando? : 1 - Si");
    opcion = Convert.ToInt32(Console.ReadLine());
} while (opcion == 1);






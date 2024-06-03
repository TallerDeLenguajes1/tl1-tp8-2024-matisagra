using EspacioTipoOperacion;
namespace espacioOperacion
{
    public class Operacion{
        private double resultadoAnterior;
        private double nuevoValor;
        private TipoOperacion operacion;

        public double ResultadoAnterior { get => resultadoAnterior; set => resultadoAnterior = value; }
        public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }
        public TipoOperacion OperacionT { get => operacion; set => operacion = value; }

        //metodo constructor de operacion
        public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion){
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.operacion = operacion;
        }

        public string ShowOperacion(){
            return "Operacion Realizada: " + operacion + " | " +  "Resultado Anterior: " + resultadoAnterior + " | " +"Nuevo Valor: " + nuevoValor;
        }
    }
}
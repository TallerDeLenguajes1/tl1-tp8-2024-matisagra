using espacioOperacion;
namespace EspacioCalculadora
{

    public class MiCalculadora
    {
        private double dato = 0;

        public double Resultado{
            get => dato;
        }

        private List<Operacion> historial; //declaro un miembro para el historial

        public List<Operacion> Historial { get => historial; set => historial = value; } //propiedades de acceso al historial

        public void Sumar(double x){
            dato+=x;
        }
        public void Restar(double x){
            dato-=x;
        }
        public void Multiplicar(double x){
            dato*=x;
        }
        public void Dividir(double x){
            if (x != 0)
            {
                dato/=x;
            }
        }
        public void Limpiar(){
            dato = 0;
        }

        
    }
}
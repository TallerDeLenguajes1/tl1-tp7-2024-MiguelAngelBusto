using System.Runtime.CompilerServices;
namespace EspacioCalculadora;

class Calculadora {
    private float dato;

        public Calculadora(){
            this.dato = 0;
        }

        public void Sumar(float x,float y){
            this.dato = x+y;
        }
        public void Restar(float x, float y){
            this.dato = x - y;
        }
        public void Multiplicar(float x, float y){
            this.dato = x * y;
        }
        public void Dividir(float x, float y){
            if(y!=0){
                this.dato = x/y;
            }
            else {
                Console.WriteLine("No se pueden hacer diviciones en 0");
            }
        }
        public void Limpiar(){
            this.dato = 0;
        }
        public float Resultado (){
            return this.dato;
        }
}

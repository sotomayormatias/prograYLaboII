using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase03
{
    class Rectangulo
    {
        private int ladoUno;
        private int ladoDos;
        private double perimetro;
        private double superficie;

        public Rectangulo(int ladoUno, int ladoDos) {
            this.ladoUno = ladoUno;
            this.ladoDos = ladoDos;
            this.ObtenerDatos();
        }

        private void ObtenerDatos() {
            this.perimetro = (this.ladoUno + this.ladoDos) * 2.00;
            this.superficie = this.ladoUno * this.ladoDos;
        }

        public string Mostrar(){
            return "ladoUno: " + this.ladoUno + " - ladoDos: " + this.ladoDos + " - perimetro: " + this.perimetro + " - superficie: " + this.superficie;
        }

        public static void dibujar(Rectangulo unRectangulo)
        {
            for (int i = 0; i < unRectangulo.ladoUno; i++) {
                for (int j = 0; j < unRectangulo.ladoDos; j++) {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}

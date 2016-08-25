using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase03
{
    class Triangulo
    {
        private int baseT;
        private int altura;
        private double superficie;

        public Triangulo(int baseT, int altura) {
            this.baseT = baseT;
            this.altura = altura;
            this.obtenerDatos();
        }

        private void obtenerDatos()
        {
            this.superficie = this.baseT * this.altura / 2.00;
        }

        public string Mostrar()
        {
            return "base: " + this.baseT + " - altura: " + this.altura + " - superficie: " + this.superficie;
        }

        public static void dibujar(Triangulo unTriangulo){
            
        }
    }
}

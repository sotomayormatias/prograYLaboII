using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo unTriangulo = new Triangulo(3, 5);
            Rectangulo unRectangulo = new Rectangulo(3, 8);

            Console.WriteLine(unTriangulo.Mostrar());
            Console.WriteLine(unRectangulo.Mostrar());

            Rectangulo.dibujar(unRectangulo);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            while (numero < 0) {
                Console.WriteLine("Ingrese un numero POSITIVO");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El cuadrado es: {0} y el cubo es: {1}", Math.Pow(numero, 2), Math.Pow(numero, 3));

            Console.ReadKey();
        }
    }
}

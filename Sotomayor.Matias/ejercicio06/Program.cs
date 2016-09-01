using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un numero");

            while(!int.TryParse(Console.ReadLine(), out numero)){
                Console.WriteLine("Ingrese un NUMERO");
            }

            if ((numero % 4 == 0) && (numero % 100 != 0 || numero % 400 == 0))
            {
                Console.WriteLine("El año es bisiesto");
            }
            else 
            {
                Console.WriteLine("El año NO es bisiesto");
            }

            Console.ReadKey();
        }
    }
}

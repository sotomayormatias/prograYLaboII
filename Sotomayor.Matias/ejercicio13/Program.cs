using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double i = 1; i <= 10; i++) {
                Console.WriteLine("Decimal: " + i + ", Binario: " + Conversor.DecimalBinario(i));
            }

            Console.ReadKey();
        }
    }
}

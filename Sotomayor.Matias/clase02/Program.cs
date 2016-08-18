using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase02
{
    class Program
    {
        static void Main(string[] args)
        {

            Sello.mensaje = "Hola mundo";
            Console.WriteLine("1.- " + Sello.imprimir());
            Sello.borrar();
            Console.WriteLine("2.- " + Sello.imprimir());
            Sello.mensaje = "Otro mensaje";
            Sello.color = ConsoleColor.Cyan;
            Sello.imprimirEnColor();
            Console.WriteLine("3.- " + Sello.imprimir());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manualidades;

namespace clase02
{
    class Program
    {
        static void Main(string[] args)
        {

            Sello.mensaje = "Hola mundo";
            Sello.imprimir();
            Sello.borrar();
            Sello.imprimir();
            Sello.mensaje = "Otro mensaje";
            Sello.imprimirEnColor(ConsoleColor.Green);
            Sello.imprimir();
            Sello.imprimirConFormato();
            Sello.mensaje = "        ";
            Sello.imprimirConFormato();
            Console.ReadKey();
        }
    }
}

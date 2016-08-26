using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto prod1 = new Producto();
            Producto prod2 = new Producto(23.5);
            Producto prod3 = new Producto(23.5, "24684361836513");
            Producto prod4 = new Producto(23.5, unNombre:"24684361836513", unCodBarra:"Harina");
            
            prod1.Mostrar();
            prod2.Mostrar();
            prod3.Mostrar();
            prod4.Mostrar();

            Console.ReadKey();
        }
    }
}

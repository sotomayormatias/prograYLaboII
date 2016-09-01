using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta tintaUno = new Tinta();
            Tinta tintaDos = new Tinta(ConsoleColor.Cyan, ETipoTinta.China);

            Console.WriteLine((string)tintaUno);
            Console.WriteLine((string)tintaDos);

            if (tintaUno == tintaDos)
            {
                Console.WriteLine("Son iguales");
            }
            else 
            {
                Console.WriteLine("Son distintos");
            }

            Console.WriteLine("*********************************************************");

            Pluma unaPluma = new Pluma("Parker", tintaDos, 4);

            Console.WriteLine(unaPluma);

            if (unaPluma == tintaDos)
            {
                Console.WriteLine("Son iguales!!");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }

            Console.WriteLine("*********************************************************");

            Pluma plumaDos = new Pluma("Parker", tintaUno, 4);

            Pluma plumaTres = new Pluma();

            Console.WriteLine(plumaDos + tintaUno);
            Console.WriteLine(plumaTres + tintaUno);
            Console.WriteLine(unaPluma + tintaUno);

            Console.WriteLine(plumaDos - tintaUno);

            Console.ReadKey();
        }
    }
}

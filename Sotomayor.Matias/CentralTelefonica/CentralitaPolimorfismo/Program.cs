using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita centra = new Centralita("Telefonica");

            Local llamLoc1 = new Local("Jujuy", "Salta", 30F, 2.65F);
            Provincial llamProv1 = new Provincial("Mendoza", "Chubut", 21F, Franja.Franja_1);
            Local llamLoc2 = new Local("Bs As", "Chaco", 45F, 1.99F);
            Provincial llamProv2 = new Provincial(llamProv1, Franja.Franja_3);

            centra += llamLoc1;
            centra += llamProv1;
            centra += llamLoc2;
            centra += llamProv2;

            Console.WriteLine(centra.ToString());

            Console.ReadKey();

            centra.OrdenarLlamadas();
            Console.WriteLine(centra.ToString());

            Console.ReadKey();
        }
    }
}

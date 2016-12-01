using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio57_CL;

namespace ejercicio57_CA
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita centra = new Centralita("Telefonica");

            Local llamLoc1 = new Local("Jujuy", 30F, "Salta", 2.65F);
            Provincial llamProv1 = new Provincial("Mendoza", 21F, "Chubut", Provincial.Franja.Franja_1);
            Local llamLoc2 = new Local("Bs As", 45F, "Chaco", 1.99F);
            Provincial llamProv2 = new Provincial(Provincial.Franja.Franja_3, llamProv1);

            centra += llamLoc1;
            centra += llamProv1;
            centra += llamLoc2;
            centra += llamProv2;

            Console.WriteLine(centra.ToString());
            Console.ReadKey();

            centra.OrdenarLlamadas();
            Console.WriteLine(centra.ToString());
            Console.ReadKey();

            centra.Serializarse();
            Console.ReadKey();

            centra.DeSerializarse();
            Console.ReadKey();

            centra.GuardarEnArchivo(true);
            Console.ReadKey();
        }
    }
}

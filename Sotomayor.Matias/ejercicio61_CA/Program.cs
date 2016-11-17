using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio61_CL;

namespace ejercicio61_CA
{
    class Program
    {
        static void Main(string[] args)
        {
            TrenBala tb = new TrenBala(300, "Tandil");
            TrenElectrico te = new TrenElectrico(100, "Constitucion");

            List<Tren> trenes = new List<Tren>();
            trenes.Add(tb);
            trenes.Add(te);

            Xml<List<Tren>> serializador = new Xml<List<Tren>>();

            serializador.Guardar("trenes.xml", trenes);


            Console.ReadKey();
        }
    }
}

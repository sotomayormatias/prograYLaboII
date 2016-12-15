using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploSerializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaXml = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\prueba.xml";
            string rutaTxt = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\prueba.txt";

            List<MiClaseBase> lista = new List<MiClaseBase>();

            MiClaseBase cb = new MiClaseBase(3, "clase base");
            MiClaseDerivada cd = new MiClaseDerivada(5, "clase derivada", 7);

            lista.Add(cb);
            lista.Add(cd);

            Xml<List<MiClaseBase>> serializador = new Xml<List<MiClaseBase>>();
            serializador.guardar(rutaXml, lista);

            Console.ReadKey();

            List<MiClaseBase> lista2;
            serializador.leer(rutaXml, out lista2);

            foreach (MiClaseBase clase in lista2)
            {
                Console.WriteLine(clase.ToString());
            }

            Console.ReadKey();

            Texto texto = new Texto();
            foreach (MiClaseBase clase in lista)
            {
                texto.guardar(rutaTxt, clase.ToString());
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace clase16
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\equipo.xml";
                Persona diego = new Persona("Diego Armando", "Maradona", 10101010);
                Persona martin = new Persona("Martin", "Palermo", 99999999);
                Persona apache = new Persona("Carlos", "Tevez", 11111111);
                PersonaLoca caruso = new PersonaLoca("Ricardo", "Caruso Lombardi", 9843516, "Vende humo");

                List<Persona> equipo = new List<Persona>();
                equipo.Add(diego);
                equipo.Add(martin);
                equipo.Add(apache);
                equipo.Add(caruso);

                Serializador<List<Persona>> ser = new Serializador<List<Persona>>();

                ser.Serializar(path, equipo);

                List<Persona> otroEquipo = ser.Deserializar(path);

                foreach (Persona jugador in otroEquipo)
                {
                    Console.WriteLine(jugador.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase20;

namespace clase20_CA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lista = Persona.TraerPersonas();
            foreach (Persona persona in lista)
            {
                Console.WriteLine(persona.ToString());
            }
            Console.ReadKey();

            Persona nuevaPersona = new Persona("Juan", 56);

            if (nuevaPersona.Eliminar())
                Console.WriteLine("Se elimino");

            Console.ReadKey();
        }
    }
}

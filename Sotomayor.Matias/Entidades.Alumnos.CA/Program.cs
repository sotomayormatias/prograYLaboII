using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Alumnos;
using Entidades.Externa;
using Entidades.Externa.Otra;

namespace Entidades.Alumnos.CA
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona personita = new Persona("Diego", "Perez", 68, ESexo.Masculino);
            PersonaDerivada personaExt = new PersonaDerivada("Alicia", "Martinez", 54, Externa.ESexo.Femenino);
            PersonaExternaOtra personaExtOtra = new PersonaExternaOtra("Roberto", "Dominguez", 32, Externa.Otra.ESexo.Indefinido);
            Int32 numero = 44;
            string cadena = "Hola, esta cadena de texto tiene ocho palabras";

            Console.WriteLine("Nombre: " + personita.Nombre);
            Console.WriteLine("Apellido: " + personita.Apellido);
            Console.WriteLine("Edad: " + personita.Edad);
            Console.WriteLine("Sexo: " + personita.Sexo);

            Console.WriteLine(personita);
            Console.WriteLine(personaExt);

            Console.WriteLine(personita.Mostrar());
            Console.WriteLine(personaExtOtra.Mostrar());

            Console.WriteLine(personita.EsNulo());
            Console.WriteLine(numero.EsPar());
            Console.WriteLine(cadena.contarPalabras());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Otra;

namespace Entidades.Alumnos
{
    public static class Extensora
    {
        public static void MostrarPersona(Persona persona)
        {
            Console.WriteLine(persona);
        }

        //Usando el this, el metodo mostrar se vincula con la clase Persona
        public static string Mostrar(this Persona persona) 
        {
            return persona.ToString();
        }

        public static string Mostrar(this PersonaExternaOtra persona)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre: " + persona.Nombre);
            sb.Append(" - Apellido: " + persona.Apellido);
            sb.Append(" - Edad: " + persona.Edad);
            sb.Append(" - Sexo: " + persona.Sexo);

            return sb.ToString();
        }

        public static bool EsNulo(this Object objeto)
        {
            return object.Equals(objeto, null);
        }

        public static int contarPalabras(this string cadena) 
        {
            List<string> palabras = new List<string>();
            palabras = cadena.Split(' ').ToList<string>();

            return palabras.Count;
        }

        public static bool EsPar(this Int32 entero)
        {
            return entero % 2 == 0;
        }
    }
}

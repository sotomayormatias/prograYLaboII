using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio57_CL
{
    public static class Extensora
    {
        public static void Saludar(this Centralita centralita, string nombre)
        {
            Console.WriteLine("Hola " + nombre + "!!");
        }
    }
}

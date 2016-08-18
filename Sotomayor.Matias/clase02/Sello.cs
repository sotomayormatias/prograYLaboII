using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase02
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string imprimir() {
            return "El mensaje es: " + Sello.mensaje;
        }

        public static void borrar() {
            Sello.mensaje = "";
        }

        public static void imprimirEnColor() {
            Console.BackgroundColor = Sello.color;
        }
    }
}

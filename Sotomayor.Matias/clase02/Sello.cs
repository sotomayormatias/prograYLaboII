using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manualidades
{
    class Sello
    {
        public static string mensaje;

        public static void imprimir() {
            string mensajeFinal;

            validarMensaje(Sello.mensaje, out mensajeFinal);
            Console.WriteLine(mensajeFinal);
        }

        public static void borrar() {
            Sello.mensaje = "";
        }

        public static void imprimirEnColor(ConsoleColor unColor)
        {
            string mensajeFinal;

            if (validarMensaje(Sello.mensaje, out mensajeFinal))
            {
                Console.BackgroundColor = unColor;
                Console.WriteLine(Sello.mensaje);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.WriteLine(mensajeFinal);
            }
        }

        public static void imprimirConFormato() {
            string mensajeFinal;

            if (validarMensaje(Sello.mensaje, out mensajeFinal))
            {
                string techo = "";
                string piso = "";
                int longitud = Sello.mensaje.Length;

                for (int i = 0; i < longitud + 2; i++)
                {
                    techo += "*";
                    piso += "*";
                }

                Console.WriteLine(techo);
                Console.WriteLine("*" + mensajeFinal + "*");
                Console.WriteLine(piso);
            }
            else 
            {
                Console.WriteLine(mensajeFinal);  
            }
            
        }

        static bool validarMensaje(string mensaje, out string mensajeSalida) {
            bool mensajeValido;
            mensajeSalida = mensaje;
            mensajeValido = !string.IsNullOrEmpty(mensaje.Trim()) || !string.IsNullOrWhiteSpace(mensaje.Trim());
            if (!mensajeValido)
                mensajeSalida = "Error, el mensaje ingresado no es valido";

            return mensajeValido;
        }
    }
}

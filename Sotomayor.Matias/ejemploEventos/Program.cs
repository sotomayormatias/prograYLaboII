using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejemploEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase clase = new MiClase(1000);
            clase.miEvento += Program.generar;

            Thread hilo = new Thread(clase.generadorDeEvento);
            hilo.Start("hola putazo");
            
            //clase.generadorDeEvento();

            Console.ReadKey();
            hilo.Abort();
        }

        public static void generar(object mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio;
            int mes;
            int dia;

            Console.WriteLine("Ingrese el día de su nacimiento");
            dia = int.Parse(Console.ReadLine());
            while (dia < 0 || dia > 31) 
            {
                Console.WriteLine("Ingrese el día de su nacimiento (entre 0 y 31)");
                dia = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese el mes de su nacimiento");
            mes = int.Parse(Console.ReadLine());
            while (mes < 0 || mes > 12)
            {
                Console.WriteLine("Ingrese el mes de su nacimiento (entre 0 y 12)");
                mes = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese el año de su nacimiento");
            anio = int.Parse(Console.ReadLine());
            while (anio < 0)
            {
                Console.WriteLine("Ingrese el año de su nacimiento (mayor a 0)");
                anio = int.Parse(Console.ReadLine());
            }

            DateTime fecha = new DateTime(anio, mes, dia);

            TimeSpan resultado = DateTime.Now.Date - fecha;

            Console.WriteLine("Usted ha vivido " + resultado.TotalDays +" días");

            Console.ReadKey();
        }
    }
}

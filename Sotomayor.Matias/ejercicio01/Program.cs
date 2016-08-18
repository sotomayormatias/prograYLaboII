using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 0;
            int numero;
            int suma = 0;

            for (int i = 0; i < 5; i++) { 
                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    min = numero;
                    max = numero;
                } 
                else 
                {
                    if (numero < min)
                        min = numero;

                    if (numero > max)
                        max = numero;
                }
                suma += numero;
            }

            Console.WriteLine("El maximo es {0}, el minimo es {1} y el promedio es {2:.00}", max, min, suma/5.0);
            Console.ReadKey();
        }
    }
}

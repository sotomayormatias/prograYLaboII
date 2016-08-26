using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int exitos = 0;
            int cont = 1;
            string resultado = "";

            while (exitos < 4)
            {
                int suma = 0;
                for (int i = 1; i < cont; i++) {
                    if (cont % i == 0)
                        suma += i;
                }

                if (suma == cont) {
                    exitos++;
                    if (string.IsNullOrEmpty(resultado))
                        resultado += cont;
                    else
                        resultado += ", " + cont;
                }

                cont++;
            }

            Console.WriteLine("Los primeros 4 numeros perfectos son: {0}", resultado);

            Console.ReadKey();
        }
    }
}

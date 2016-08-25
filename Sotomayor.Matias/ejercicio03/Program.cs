using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int numeroIngresado = int.Parse(Console.ReadLine());
            string numeros = "";

            for (int i = 0; i < numeroIngresado; i++)
            { 
                if(VerificarPrimo(i)){
                    if(numeros == "")
                        numeros += i;
                    else
 			            numeros += ", " + i;
 		        }
            }

            Console.WriteLine("Los numeros primos hasta el numero ingresado son: {0}", numeros);

            Console.ReadKey();
        }

        private static Boolean VerificarPrimo(int numero){
 	        int contador = 0;

 	        for(var i=1; i<=numero; i++){
 		        if(numero%i == 0){
 			        contador++;
 		        }
 	        }
 	        return contador == 2;
        }
    }
}

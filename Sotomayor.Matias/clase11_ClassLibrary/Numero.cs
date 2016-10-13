using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase11_ClassLibrary
{
    public class Numero
    {
        protected int _numero;

        public int Lectura
        {
            get
            {
                return this._numero;
            }
        }

        public Numero(int numero)
        {
            if (numero < 0)
            {
                throw new Exception("El numero es negativo, todo mal vieja");
            } 
            else 
            {
                this._numero = numero; 
            }
        }

        public static int operator +(Numero numUno, Numero numDos)
        {
            return numUno._numero + numDos._numero;
        }

        public static int operator -(Numero numUno, Numero numDos)
        {
            return numUno._numero - numDos._numero;
        }

        public static double operator /(Numero numUno, Numero numDos)
        {
            return numUno._numero / numDos._numero;
        }

        public static int operator *(Numero numUno, Numero numDos)
        {
            return numUno._numero * numDos._numero;
        }
    }
}

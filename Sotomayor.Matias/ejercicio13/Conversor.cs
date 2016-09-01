using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(double numDecimal) {
            string numBinario = "";

            while (numDecimal > 1) 
            {
                numBinario = (numDecimal % 2).ToString() + numBinario;
                numDecimal = Math.Floor(numDecimal / 2);
            }

            if (numDecimal == 1)
            {
                numBinario = "1" + numBinario;
            }
            else
            {
                numBinario = "0" + numBinario;
            }

            return numBinario;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase15_campus
{
    public static class Parser
    {
        public static bool TryParse(string entrada, out int salida)
        {
            try
            {
                salida = int.Parse(entrada);
                return true;
            }
            catch (FormatException)
            {
                salida = 0;
                throw;
            }
            catch (OverflowException)
            {
                salida = 0;
                throw;
            }
        }

        public static int Parse(string entrada)
        {
            try
            {
                return int.Parse(entrada);
            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (OverflowException e)
            {
                throw e;
            }
        }
    }
}

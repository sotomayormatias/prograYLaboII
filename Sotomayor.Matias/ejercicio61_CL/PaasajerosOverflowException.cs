using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio61_CL
{
    public class PaasajerosOverflowException : Exception
    {
        public PaasajerosOverflowException(string message)
            : base(message)
        { }
    }
}

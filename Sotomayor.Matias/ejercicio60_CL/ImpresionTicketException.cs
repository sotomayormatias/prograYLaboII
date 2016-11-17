using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio60_CL
{
    public class ImpresionTicketException : Exception
    {
        public ImpresionTicketException(string message)
            : base(message)
        { }
    }
}

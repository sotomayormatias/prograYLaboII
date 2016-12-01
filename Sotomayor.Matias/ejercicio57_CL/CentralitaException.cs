using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio57_CL
{
    public class CentralitaException : Exception
    {
        private Exception _excepcionInterna;

        public Exception ExcepcionInterna
        {
            get { return _excepcionInterna; }
        }

        private string _nombreMetodo;

        public string NombreMetodo
        {
            get { return _nombreMetodo; }
        }

        private string _nombreClase;

        public string NombreClase
        {
            get { return _nombreClase; }
        }

        public CentralitaException(string mensaje, string clase, string metodo)
            : base("mensaje: " + mensaje + ", en metodo: " + metodo + " de clase: " + clase)
        { }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
            : base("mensaje: " + mensaje + ", en metodo: " + metodo + " de clase: " + clase, innerException)
        { 
        }
    }
}

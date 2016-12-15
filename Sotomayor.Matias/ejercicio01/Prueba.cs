using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    public class Prueba
    {
        public string descripcion;

        public Prueba()
        {
            this.descripcion = "hola";
        }

        protected virtual int propiedad { get; set; }

    }
}

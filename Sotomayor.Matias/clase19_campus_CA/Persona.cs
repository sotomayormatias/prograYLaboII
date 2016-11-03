using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase19_campus_CA
{
    public class Persona
    {
        public string _nombre;
        public string _apellido;

        public string Nombre { get { return this._nombre; } }
        public string Apellido { get { return this._apellido; } }

        public Persona()
        { }

        public Persona(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
    }
}

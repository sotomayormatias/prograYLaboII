using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace Entidades.Alumnos
{
    public class PersonaDerivada : PersonaExterna
    {
        public string Nombre
        {
            get
            {
                return this._nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this._apellido;
            }
        }

        public int Edad
        {
            get
            {
                return this._edad;
            }
        }

        public Externa.ESexo Sexo
        {
            get
            {
                return this._sexo;
            }
        }

        public PersonaDerivada(string nombre, string apellido, int edad, Externa.ESexo sexo)
            :base(nombre, apellido, edad, sexo)
        { }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre: " + this._nombre);
            sb.Append(" - Apellido: " + this._apellido);
            sb.Append(" - Edad: " + this._edad);
            sb.Append(" - Sexo: " + this._sexo);

            return sb.ToString();
        }
    }
}

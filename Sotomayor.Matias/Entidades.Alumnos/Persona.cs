using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Alumnos
{
    public class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected int _edad;
        protected ESexo _sexo;

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

        public ESexo Sexo
        {
            get
            {
                return this._sexo;
            }
        }

        public Persona(string nombre, string apellido, int edad, ESexo sexo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._sexo = sexo;
        }

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase16
{
    public class PersonaLoca : Persona
    {
        public string _diagnostico;

        public PersonaLoca()
            : base()
        { }

        public PersonaLoca(string nombre, string apellido, long dni, string diagnostico)
            : base(nombre, apellido, dni)
        {
            this._diagnostico = diagnostico;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Diagnostico: " + this._diagnostico);
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ejemploSerializacion
{
    [Serializable]
    [XmlInclude(typeof(MiClaseDerivada))]
    public class MiClaseBase
    {
        public int numero;
        public string nombre;

        public MiClaseBase()
        { }

        public MiClaseBase(int numero, string nombre)
        {
            this.numero = numero;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploSerializacion
{
    [Serializable]
    public class MiClaseDerivada : MiClaseBase
    {
        public int otroNumero;

        public MiClaseDerivada()
            : base()
        { }

        public MiClaseDerivada(int numero, string nombre, int otroNumero)
            : base(numero, nombre)
        {
            this.otroNumero = otroNumero;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

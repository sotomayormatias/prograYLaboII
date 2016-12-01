using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio57_CL
{
    [Serializable]
    public class Local : Llamada
    {
        public float _costo;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return this._costo * this._duracion;
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        public Local()
        { }

        public Local(string origen, float duracion, string destino, float costo)
            : base(origen, destino, duracion)
        {
            this._costo = costo;
        }

        public Local(Llamada unaLlamada, float costo)
            : this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, costo)
        { 
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Costo llamada: " + this.CostoLlamada);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}

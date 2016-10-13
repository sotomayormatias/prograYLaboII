using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public class Local : Llamada
    {
        protected float _costo;

        public override float CostoLlamada {
            get 
            {
                return this.CalcularCosto();
            }
        }

        public Local(Llamada unaLlamada, float costo) 
            : this(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion, costo) 
        {
        }

        public Local(string origen, string destino, float duracion, float costo)
            : base(origen, destino, duracion)
        {
            this._costo = costo;
        }

        private float CalcularCosto()
        {
            return this._costo * this._duracion;
        }

        protected override string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.Append("Costo: ");
            mensaje.Append(this.CostoLlamada + "\n");
            
            mensaje.Append(base.Mostrar());
            return mensaje.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return (obj is Local);
        }
    }
}

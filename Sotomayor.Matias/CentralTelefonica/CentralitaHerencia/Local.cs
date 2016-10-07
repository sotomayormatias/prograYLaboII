using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float _costo;

        public float CostoLlamada {
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

        public void Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.Append("Costo: ");
            mensaje.Append(this.CostoLlamada + "\n");
            
            base.Mostrar();
            Console.WriteLine(mensaje);
        }
    }
}

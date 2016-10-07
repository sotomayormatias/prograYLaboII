using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja _franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Provincial(Llamada unaLlamada, Franja franja) 
            : this(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion, franja) 
        {
        }

        public Provincial(string origen, string destino, float duracion, Franja franja)
            : base(origen, destino, duracion)
        {
            this._franjaHoraria = franja;
        }

        private float CalcularCosto()
        {
            float costoFinal;
            switch (this._franjaHoraria)
            { 
                case Franja.Franja_1:
                    costoFinal = this._duracion * 0.99F;
                    break;
                case Franja.Franja_2:
                    costoFinal = this._duracion * 1.25F;
                    break;
                default:
                    costoFinal = this._duracion * 0.66F;
                    break;
            }

            return costoFinal;
        }

        public void Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.Append("Franja horaria: ");
            mensaje.Append(this._franjaHoraria.ToString() + "\n");
            mensaje.Append("Costo: ");
            mensaje.Append(this.CostoLlamada + "\n");

            base.Mostrar();
            Console.WriteLine(mensaje);
        }
    }
}

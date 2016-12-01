using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio57_CL
{
    [Serializable]
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 };

        public Franja _franjaHoraria;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Provincial()
        { }

        public Provincial(Franja miFranja, Llamada unaLlamada)
            : this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, miFranja)
        { 
        }

        public Provincial(string origen, float duracion, string destino, Franja miFranja)
            : base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float costo = 0F;

            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = this.Duracion * 0.99F;
                    break;
                case Franja.Franja_2:
                    costo = this.Duracion * 1.25F;
                    break;
                case Franja.Franja_3:
                    costo = this.Duracion * 0.66F;
                    break;
            }

            return costo;
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Franja horaria: " + this._franjaHoraria.ToString());
            sb.AppendLine("Costo llamada: " + this.CostoLlamada);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}

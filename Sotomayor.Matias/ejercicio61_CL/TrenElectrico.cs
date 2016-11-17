using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio61_CL
{
    [Serializable]
    public class TrenElectrico : Tren
    {
        private List<Pasajero> _pasajeros;

        public override List<Pasajero> Pasajeros
        {
            get
            {
                return this._pasajeros;
            }
        }

        public TrenElectrico()
        {
            this._pasajeros = new List<Pasajero>();
        }

        public TrenElectrico(int cantMaxPasajeros, string destino)
            : base(cantMaxPasajeros, destino)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cant max de pasajeros: " + this._cantMaxPasajeros);
            sb.AppendLine("Destino: " + this._destino);
            sb.AppendLine("Pasajeros: ");

            foreach (Pasajero unPasajero in this._pasajeros)
            {
                sb.AppendLine(unPasajero.ToString());
            }

            return sb.ToString();
        }

        public override void IngresarPasajero(Pasajero unPasajero)
        {
            if (this._pasajeros.Count < this._cantMaxPasajeros)
            {
                this._pasajeros.Add(unPasajero);
            }
            else 
            {
                throw new PaasajerosOverflowException("El tren electrico esta lleno");
            }
        }
    }
}

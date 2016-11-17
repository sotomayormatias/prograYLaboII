using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ejercicio61_CL
{
    [Serializable]
    [XmlInclude(typeof(TrenBala))]
    [XmlInclude(typeof(TrenElectrico))]
    public abstract class Tren
    {
        protected int _cantMaxPasajeros;

        public int CantMaxPasajeros
        {
            get { return _cantMaxPasajeros; }
            set { _cantMaxPasajeros = value; }
        }

        protected bool _motorEncendido;

        public bool MotorEncendido
        {
            get { return _motorEncendido; }
            set { _motorEncendido = value; }
        }

        protected string _destino;

        public string Destino
        {
            get { return _destino; }
            set { _destino = value; }
        }

        public abstract List<Pasajero> Pasajeros { get; }

        public Tren()
        {
        }

        public Tren(int cantMaxPasajeros, string destino)
            :this()
        {
            this._cantMaxPasajeros = cantMaxPasajeros;
            this._destino = destino;
        }

        public abstract void IngresarPasajero(Pasajero unPasajero);

        public virtual string IndicarDestino()
        {
            return this._destino;
        }

        public bool EncenderMotor()
        {
            if (!this._motorEncendido)
            {
                this._motorEncendido = true;
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

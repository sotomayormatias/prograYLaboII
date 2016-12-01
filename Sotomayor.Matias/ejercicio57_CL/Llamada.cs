using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ejercicio57_CL
{
    [Serializable]
    [XmlInclude(typeof(Provincial))]
    [XmlInclude(typeof(Local))]
    public abstract class Llamada
    {
        public float _duracion;
        public string _nroDestino;
        public string _nroOrigen;

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        public abstract float CostoLlamada
        {
            get;
        }

        public Llamada()
        { }

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("nro origen: " + this.NroOrigen);
            sb.AppendLine("nro destino: " + this.NroDestino);
            sb.AppendLine("duracion: " + this.Duracion.ToString());

            return sb.ToString();
        }

        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.Equals(llamada2) && llamada1.NroOrigen == llamada2.NroOrigen && llamada1.NroDestino == llamada2.NroDestino;
        }

        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        { 
            return !(llamada1 == llamada2);
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.Duracion.CompareTo(llamada2.Duracion);
        }
    }
}

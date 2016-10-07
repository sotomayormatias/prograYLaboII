using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public float Duracion { 
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

        public Llamada(string origen, string destino, float duracion) 
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            return uno._duracion.CompareTo(dos._duracion);
        }

        public void Mostrar() 
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.Append("Llamada desde: ");
            mensaje.Append(this._nroOrigen + "\n");
            mensaje.Append("Llamada hasta: ");
            mensaje.Append(this._nroDestino + "\n");
            mensaje.Append("Con duracion: ");
            mensaje.Append(this._duracion + "\n");

            Console.WriteLine(mensaje);
        }
    }
}

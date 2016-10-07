using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected String _razonSocial;

        public float GananciaPorLocal 
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciaTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas 
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }

        private Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) 
            : this()
        {
            this._razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0.0F;

            foreach (Llamada llamada in this._listaDeLlamadas)
            {
                switch (tipo)
                {
                    case TipoLlamada.Todas:
                        if (llamada is Local)
                            ganancia += ((Local)llamada).CostoLlamada;
                        else
                            ganancia += ((Provincial)llamada).CostoLlamada;
                        break;
                    case TipoLlamada.Local:
                        if (llamada is Local)
                            ganancia += ((Local)llamada).CostoLlamada;
                        break;
                    case TipoLlamada.Provincial:
                        if (llamada is Provincial)
                            ganancia += ((Provincial)llamada).CostoLlamada;
                        break;
                }
            }
            
            return ganancia;
        }

        public void Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.Append("Razon social: ");
            mensaje.Append(this._razonSocial + "\n");
            mensaje.Append("Ganancia total: ");
            mensaje.Append(this.GananciaTotal + "\n");
            mensaje.Append("Ganancia Local: ");
            mensaje.Append(this.GananciaPorLocal + "\n");
            mensaje.Append("Ganancia Provincial: ");
            mensaje.Append(this.GananciaPorProvincial + "\n");
            mensaje.Append("Detalle de llamadas: \n");

            Console.WriteLine(mensaje);
            foreach (Llamada llamada in this._listaDeLlamadas)
            {
                llamada.Mostrar();
            }
        }

        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort();
        }

        public static Centralita operator +(Centralita unaCentralita, Llamada unaLlamada)
        {
            unaCentralita._listaDeLlamadas.Add(unaLlamada);
            return unaCentralita;
        }
    }
}

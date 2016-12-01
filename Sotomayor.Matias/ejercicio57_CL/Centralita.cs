using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ejercicio57_CL
{
    [Serializable]
    [XmlInclude(typeof(Llamada))]
    public class Centralita : ISerializable
    {
        public enum TipoLlamada { Local, Provincial, Todas };

        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        private string _ruta;

        public string RutaDelArchivo
        {
            get
            {
                return this._ruta;
            }
            set
            {
                this._ruta = value;
            }
        }

        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciaTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0F;
            if(tipo == TipoLlamada.Todas)
            {
                foreach (Llamada llamada in this._listaDeLlamadas)
	            {
		             ganancia += llamada.CostoLlamada;
	            }
            }
            else if(tipo == TipoLlamada.Local)
            {
                foreach (Llamada llamada in this._listaDeLlamadas)
	            {
                    ganancia += llamada is Local ? llamada.CostoLlamada : 0F;
	            }
            }
            else
            {
                foreach (Llamada llamada in this._listaDeLlamadas)
	            {
                    ganancia += llamada is Provincial ? llamada.CostoLlamada : 0F;
	            }
            }

            return ganancia;
        }

        public Centralita()
        { 
            this._listaDeLlamadas = new List<Llamada>();
            this._ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this._razonSocial = nombreEmpresa;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Razon social: " + this._razonSocial);
            sb.AppendLine("Ganancia por local: " + this.GananciaPorLocal);
            sb.AppendLine("Ganancia por provincial: " + this.GananciaPorProvincial);
            sb.AppendLine("Ganancia total: " + this.GananciaTotal);
            sb.AppendLine("Llamadas: ");
            foreach (Llamada llamada in this._listaDeLlamadas)
            {
                sb.AppendLine(llamada.ToString());
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this._listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita centralita, Llamada nuevaLlamada)
        {
            bool esIgual = false;
            foreach (Llamada llamada in centralita._listaDeLlamadas)
            {
                if (llamada == nuevaLlamada)
                    esIgual = true;
            }

            return esIgual;
        }

        public static bool operator !=(Centralita centralita, Llamada nuevaLlamada)
        {
            return !(centralita == nuevaLlamada);
        }

        public static Centralita operator +(Centralita centralita, Llamada nuevaLlamada)
        {
            if (centralita != nuevaLlamada)
                centralita._listaDeLlamadas.Add(nuevaLlamada);
            else
                Console.WriteLine("Esta llamada ya esta registrada, no se puede agregar.");

            return centralita;
        }

        public bool Serializarse()
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Centralita));
                XmlTextWriter tw = new XmlTextWriter(this._ruta + "\\Centralita.xml", Encoding.UTF8);
                ser.Serialize(tw, this);
                tw.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new CentralitaException("No se pudo serializar", "Centralita", "Serializarse", e);
            }
        }

        public bool DeSerializarse()
        {
            try
            {
                Centralita centralita;
                XmlSerializer ser = new XmlSerializer(typeof(Centralita));
                XmlTextReader tr = new XmlTextReader(this._ruta + "\\Centralita.xml");
                centralita = (Centralita)ser.Deserialize(tr);
                tr.Close();
                Console.WriteLine(centralita.ToString());
                return true;
            }
            catch (Exception e)
            {
                throw new CentralitaException("No se pudo deserializar", "Centralita", "DeSerializarse", e);
            }
        }

        public bool GuardarEnArchivo(bool agrego)
        {
            try
            {
                StreamWriter sw = new StreamWriter(this._ruta + "\\Llamadas.txt", agrego, Encoding.UTF8);
                sw.WriteLine(this.ToString());
                sw.Close();

                return true;
            }
            catch (Exception e)
            {
                throw new CentralitaException("No se pudo grabar el archivo", "Centralita", "GuardarEnArchivo", e);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ejemploSerializacion
{
    public class Xml<T> : ISerializable<T>
    {
        private XmlSerializer _ser;

        public Xml()
        {
            this._ser = new XmlSerializer(typeof(T));
        }

        public bool guardar(string ruta, T dato)
        {
            try
            {
                XmlTextWriter tw = new XmlTextWriter(ruta, Encoding.UTF8);
                this._ser.Serialize(tw, dato);
                tw.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool leer(string ruta, out T dato)
        {
            dato = default(T);
            try
            {
                XmlTextReader tr = new XmlTextReader(ruta);
                dato = (T)this._ser.Deserialize(tr);
                tr.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

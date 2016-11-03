using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace clase19_campus_CL
{
    public class Xml<T> : IArchivo<T>
    {
        private XmlSerializer _ser;

        public Xml()
        {
            this._ser = new XmlSerializer(typeof(T));
        }

        public bool guardar(string archivo, T datos)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
                XmlTextWriter tw = new XmlTextWriter(path + archivo, Encoding.UTF8);
                this._ser.Serialize(tw, datos);
                tw.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool leer(string archivo, out T datos)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
                XmlTextReader tr = new XmlTextReader(path + archivo);
                datos = (T)this._ser.Deserialize(tr);
                tr.Close();

                return true;
            }
            catch (Exception)
            {
                datos = default(T);
                return false;
            }
        }
    }
}

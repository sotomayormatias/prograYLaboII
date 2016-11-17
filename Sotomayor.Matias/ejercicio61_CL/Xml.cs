using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ejercicio61_CL
{
    public class Xml<T> : IArchivo<T>
    {
        private static string PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
        private XmlSerializer _ser;

        public Xml() 
        {
            this._ser = new XmlSerializer(typeof(T));
        }

        public bool Guardar(string archivo, T datos)
        {
            try
            {
                XmlTextWriter tw = new XmlTextWriter(PATH + archivo, Encoding.UTF8);
                this._ser.Serialize(tw, datos);
                tw.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Leer(string archivo, out T datos)
        {
            datos = default(T);
            try
            {
                XmlTextReader tr = new XmlTextReader(archivo);
                datos = (T)this._ser.Deserialize(tr);
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

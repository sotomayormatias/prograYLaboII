using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace clase16
{
    public class Serializador<T>
    {
        private XmlSerializer _serializer;

        public Serializador()
        {
            this._serializer = new XmlSerializer(typeof(T));
        }

        public void Serializar(string path, T dato)
        {
            XmlTextWriter tw = new XmlTextWriter(path, Encoding.UTF8);
            this._serializer.Serialize(tw, dato);
            tw.Close();
        }

        public T Deserializar(string path)
        {
            XmlTextReader tr = new XmlTextReader(path);
            T otro = (T)this._serializer.Deserialize(tr);
            tr.Close();

            return otro;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploSerializacion
{
    public class Texto : ISerializable<string>
    {
        public bool guardar(string ruta, string dato)
        {
            try
            {
                StreamWriter sr = new StreamWriter(ruta, true, Encoding.UTF8);
                sr.WriteLine(dato);
                sr.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool leer(string ruta, out string dato)
        {
            dato = "";
            try
            {
                StreamReader sr = new StreamReader(ruta, Encoding.UTF8);
                dato = sr.ReadToEnd();
                sr.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

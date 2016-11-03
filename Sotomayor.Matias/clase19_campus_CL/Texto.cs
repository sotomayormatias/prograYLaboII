using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase19_campus_CL
{
    public class Texto : IArchivo<string>
    {
        public bool guardar(string archivo, string datos)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
                StreamWriter sw = new StreamWriter(path + archivo, false, Encoding.UTF8);
                sw.Write(datos);
                sw.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool leer(string archivo, out string datos)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
                StreamReader sr = new StreamReader(path + archivo, Encoding.UTF8);
                datos = sr.ReadToEnd();

                return true;
            }
            catch (Exception)
            {
                datos = "";
                return false;
            }
        }
    }
}

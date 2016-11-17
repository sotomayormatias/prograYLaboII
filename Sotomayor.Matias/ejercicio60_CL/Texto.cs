using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio60_CL
{
    public class Texto : IArchivo<string>
    {
        private static string PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";

        public bool Guardar(string archivo, string datos)
        {
            try
            {
                StreamWriter sw = new StreamWriter(PATH + archivo, true, Encoding.UTF8);
                sw.WriteLine(datos);
                sw.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Leer(string archivo, out string datos)
        {
            datos = "";
            try
            {
                StreamReader sr = new StreamReader(PATH + archivo, Encoding.UTF8);
                datos = sr.ReadToEnd();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase18_campus_CL;
using System.IO;

namespace clase18_campus_CA
{
    public class Vista : IGrafica
    {
        
        public void MostrarEnGUI(string datos)
        {
            Console.WriteLine(datos);
        }

        public bool EscribirTXT(string path, Empleado e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);
                sw.Write(e.ToString());
                sw.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Main(string[] args)
        {
            Empleado empleado = new Empleado("Norberto", "Napolitano", "1234", Empleado.EPuestoJerarquico.Administracion, 938347);
            empleado.Mostrar(this);
            this.EscribirTXT(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Empleado.txt", empleado);
            Console.ReadKey();
        }
    }
}

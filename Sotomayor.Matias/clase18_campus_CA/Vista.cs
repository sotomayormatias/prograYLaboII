using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase18_campus_CL;

namespace clase18_campus_CA
{
    public class Vista : IGrafica
    {
        public void MostrarEnGUI(string datos)
        {
            Console.WriteLine(datos);
        }

        public void Main(string[] args)
        {
            Empleado empleado = new Empleado("Norberto", "Napolitano", "1234", Empleado.EPuestoJerarquico.Administracion, 938347);
            empleado.Mostrar(this);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase19_campus_CL;

namespace clase19_campus_CA
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empl = new Empleado("Matias", "Sotomayor", "C52656", Empleado.EPuestoJerarquico.Sistemas, 65498765);
            Empleado empl2;
            string datosEmpleado;

            Texto texto = new Texto();
            Xml<Empleado> xml = new Xml<Empleado>();

            texto.guardar("empleado.txt", empl.ToString());
            xml.guardar("empleado.xml", empl);

            Console.WriteLine("Se persistieron los datos");
            Console.ReadKey();

            if (texto.leer("empleado.txt", out datosEmpleado))
                Console.WriteLine(datosEmpleado);

            Console.ReadKey();

            if (xml.leer("empleado.xml", out empl2))
                Console.WriteLine(empl2.ToString());

            Console.ReadKey();
        }
    }
}

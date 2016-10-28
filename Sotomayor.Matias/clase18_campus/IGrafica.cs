using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase18_campus_CL
{
    public interface IGrafica
    {
        void MostrarEnGUI(string datos);
        bool EscribirTXT(string path, Empleado e);
    }
}

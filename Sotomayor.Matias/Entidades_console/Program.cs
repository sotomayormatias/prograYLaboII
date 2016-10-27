using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Deportivo autoDep = new Deportivo(100, "ABC123", 600);
            Privado avionPriv = new Privado(100, 500, 123);
            Comercial avionCom = new Comercial(100, 500, 50);
            Carreta carreta = new Carreta(100);
            Avion avion = new Avion(100, 200);

            Console.WriteLine(Gestion.MostrarImpuestoNacional((IAFIP)autoDep));
            Console.WriteLine(Gestion.MostrarImpuestoNacional((IAFIP)avionPriv));
            Console.WriteLine();

            Console.ReadKey();

            Console.WriteLine(Gestion.MostrarImpuestoProvincial((IARBA)avion));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial((IARBA)avionPriv));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial((IARBA)avionCom));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial((IARBA)carreta));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial((IARBA)autoDep));

            Console.ReadKey();
        }
    }
}

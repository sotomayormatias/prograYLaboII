using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lavadero;

namespace clase09
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero lava = new Lavadero(100, 200, 50);

            lava += new Auto("ABC123", 4, EMarcas.Fiat, 4);
            lava += new Moto("XYZ123", 2, EMarcas.Honda, 600);
            lava += new Camion("ABC456", 8, EMarcas.Scania, 7000);

            lava.Vehiculos.Sort(lava.OrdenarPorPatente);

            lava.Vehiculos.Sort(new Vehiculo("ABU037", 5, EMarcas.Ford).OrdenarPorMarca);
        }
    }
}

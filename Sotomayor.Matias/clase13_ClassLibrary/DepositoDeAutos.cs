using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase13_ClassLibrary
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }

        public static bool operator +(DepositoDeAutos depo, Auto auto)
        {
            if (depo._lista.Count() < depo._capacidadMaxima)
            {
                depo._lista.Add(auto);
                return true;
            }

            return false;
        }

        private int GetIndice(Auto auto)
        {
            for (int i = 0; i < this._lista.Count(); i++)
            {
                if (this._lista[i] == auto)
                    return i;
            }

            return -1;
        }

        public static bool operator -(DepositoDeAutos depo, Auto auto)
        {
            int indice = depo.GetIndice(auto);

            if (indice > 0)
            {
                depo._lista.RemoveAt(indice);
                return true;
            }

            return false;
        }

        public bool Agregar(Auto auto) 
        {
            return this + auto;
        }

        public bool Remover(Auto auto)
        {
            return this - auto;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Capacidad Maxima: ");
            sb.Append(this._capacidadMaxima + "\n");
            sb.Append("Listado de autos: \n");

            foreach (Auto item in this._lista)
            {
                sb.Append(item.ToString());
            }

            return sb.ToString();
        }
    }
}

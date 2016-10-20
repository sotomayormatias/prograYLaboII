using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase13_ClassLibrary
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }

        public static bool operator +(DepositoDeCocinas depo, Cocina cocina)
        {
            if (depo._lista.Count() < depo._capacidadMaxima)
            {
                depo._lista.Add(cocina);
                return true;
            }

            return false;
        }

        private int GetIndice(Cocina cocina)
        {
            for (int i = 0; i < this._lista.Count(); i++)
            {
                if (this._lista[i] == cocina)
                    return i;
            }

            return -1;
        }

        public static bool operator -(DepositoDeCocinas depo, Cocina cocina)
        {
            int indice = depo.GetIndice(cocina);

            if (indice > 0)
            {
                depo._lista.RemoveAt(indice);
                return true;
            }

            return false;
        }

        public bool Agregar(Cocina cocina) 
        {
            return this + cocina;
        }

        public bool Remover(Cocina cocina)
        {
            return this - cocina;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Capacidad Maxima: ");
            sb.Append(this._capacidadMaxima + "\n");
            sb.Append("Listado de Cocinas: \n");

            foreach (Cocina item in this._lista)
            {
                sb.Append(item.ToString());
            }

            return sb.ToString();
        }
    }
}

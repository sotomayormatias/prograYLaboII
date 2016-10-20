using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase13_ClassLibrary
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }

        public static bool operator +(Deposito<T> depo, T unItem)
        {
            if (depo._lista.Count() < depo._capacidadMaxima)
            {
                depo._lista.Add(unItem);
                return true;
            }

            return false;
        }

        private int GetIndice(T unItem)
        {
            for (int i = 0; i < this._lista.Count(); i++)
            {
                if (this._lista[i].Equals(unItem))
                    return i;
            }

            return -1;
        }

        public static bool operator -(Deposito<T> depo, T unItem)
        {
            int indice = depo.GetIndice(unItem);

            if (indice > 0)
            {
                depo._lista.RemoveAt(indice);
                return true;
            }

            return false;
        }

        public bool Agregar(T unItem) 
        {
            return this + unItem;
        }

        public bool Remover(T unItem)
        {
            return this - unItem;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Capacidad Maxima: ");
            sb.Append(this._capacidadMaxima + "\n");
            sb.Append("Listado de " + typeof(T).Name + ": \n");

            foreach (T item in this._lista)
            {
                sb.Append(item.ToString());
            }

            return sb.ToString();
        }
    }
}

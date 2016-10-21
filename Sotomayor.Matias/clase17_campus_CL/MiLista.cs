using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase17_campus_CL
{
    public class MiLista<T> : IEnumerable<T>
    {
        private T[] _lista;

        public MiLista()
        {
            this._lista = new T[0]; 
        }

        public int Count
        {
            get
            {
                return this._lista.Length;
            }
        }

        public void Add(T item)
        {
            Array.Resize<T>(ref this._lista, this.Count() + 1);
            this._lista[this.Count-1] = item;
        }

        public void Remove(T item)
        {
            int cont = 0;
            int indiceAEliminar = -1;

            while(indiceAEliminar == -1 || cont < this.Count)
            {
                if (this._lista[cont].Equals(item))
                    indiceAEliminar = cont;
                cont++;
            }

            if (indiceAEliminar != -1)
            {
                for (int i = indiceAEliminar + 1; i < this.Count; i++)
                {
                    this._lista[i - 1] = this._lista[i];
                }

                Array.Resize<T>(ref this._lista, this.Count - 1);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this._lista)
            {
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            for (int index = 0; index < this._lista.Length; index++)
            {
                // Yield each day of the week.
                yield return this._lista[index];
            }
        }

    }
}

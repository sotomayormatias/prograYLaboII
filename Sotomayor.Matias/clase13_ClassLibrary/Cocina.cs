using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase13_ClassLibrary
{
    public class Cocina
    {
        private int _codigo;

        public int Codigo
        {
            get { return _codigo; }
        }

        private bool _esIndustrial;

        public bool EsIndustrial
        {
            get { return _esIndustrial; }
        }

        private double _precio;

        public double Precio
        {
            get { return _precio; }
        }

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }

        public static bool operator ==(Cocina unaCocina, Cocina otraCocina)
        {
            return unaCocina._codigo == otraCocina._codigo;
        }

        public static bool operator !=(Cocina unaCocina, Cocina otraCocina)
        {
            return !(unaCocina == otraCocina);
        }

        public override bool Equals(object obj)
        {
            return obj is Cocina && this == (Cocina)obj;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Codigo: ");
            sb.Append(this._codigo);
            sb.Append(" - Precio: ");
            sb.Append(this._precio);
            sb.Append(" - Es industrial? ");
            sb.Append(this._esIndustrial + "\n");

            return sb.ToString();
        }
    }
}

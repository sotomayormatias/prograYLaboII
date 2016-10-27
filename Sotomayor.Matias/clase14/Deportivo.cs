using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deportivo : Auto, IAFIP, IARBA
    {
        protected int _caballosFuerza;

        public override double Precio
        {
            get
            {
                return this._precio;
            }
        }

        public override string Patente
        {
            get
            {
                return this._patente;
            }
        }

        public int CaballosFuerza
        {
            get
            {
                return this._caballosFuerza;
            }
        }

        public Deportivo(double precio, string patente, int hp)
            : base(precio, patente)
        {
            this._caballosFuerza = hp;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio: " + this._precio);
        }

        public override void MostrarPatente()
        {
            Console.WriteLine("Patente: " + this._patente);
        }

        double IAFIP.CalcularImpuesto()
        {
            return this._precio * 0.28;
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 0.23;
        }
    }
}

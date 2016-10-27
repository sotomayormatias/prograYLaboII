﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comercial : Avion, IARBA
    {
        protected int _capacidadPasajeros;

        public int CapacidadPasajeros
        {
            get
            {
                return this._capacidadPasajeros;
            }
        }

        public Comercial(double precio, double velocidad, int pasajeros)
            : base(precio, velocidad)
        {
            this._capacidadPasajeros = pasajeros;
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 0.25;
        }
    }
}

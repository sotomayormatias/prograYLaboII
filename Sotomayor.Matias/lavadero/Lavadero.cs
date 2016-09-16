using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lavadero
{
    public class Lavadero
    {
        #region Atributos
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;
        private List<Vehiculo> _vehiculos;
        public List<Vehiculo> Vehiculos { 
            get {
                return this._vehiculos;
            } 
        }
        #endregion

        #region Constructores
        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto)
            : this()
        {
            this._precioAuto = precioAuto;
            this._precioCamion = precioCamion;
            this._precioMoto = precioMoto;
        }
        #endregion

        #region Metodos
            public Double MostrarTotalFacturado()
            {
                Double total = 0;
                foreach (Vehiculo vehiculo in this._vehiculos)
                {
                    if (vehiculo is Auto)
                        total += this._precioAuto;
                    else if (vehiculo is Camion)
                        total += this._precioCamion;
                    else
                        total += this._precioMoto;
                }

                return total;
            }

            public Double MostrarTotalFacturado(EVehiculo tipoVehiculo)
            {
                Double total = 0;

                foreach (Vehiculo vehiculo in this._vehiculos)
                {
                    switch (tipoVehiculo)
                    {
                        case EVehiculo.Auto:
                            if (vehiculo is Auto)
                                total += this._precioAuto;
                            break;
                        case EVehiculo.Camion:
                            if (vehiculo is Camion)
                                total += this._precioCamion;
                            break;
                        case EVehiculo.Moto:
                            if (vehiculo is Moto)
                                total += this._precioMoto;
                            break;
                    }
                }

                return total;
            }

            public int OrdenarPorPatente(Vehiculo vehi1, Vehiculo vehi2)
            {
                return vehi1.Patente.CompareTo(vehi2.Patente);
            }
        #endregion

        #region Sobrecarga de metodos
            public static Boolean operator ==(Lavadero lavadero, Vehiculo vehiculo) { 
                foreach (Vehiculo vehi in lavadero._vehiculos)
                {
                    if (vehi == vehiculo)
                        return true;
                }
                return false;
            }

            public static Boolean operator !=(Lavadero lavadero, Vehiculo vehiculo)
            {
                return !(lavadero == vehiculo);
            }

            public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo) {
                if (lavadero != vehiculo)
                    lavadero._vehiculos.Add(vehiculo);

                return lavadero;
            }

            public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
            {
                if (lavadero == vehiculo)
                    lavadero._vehiculos.Remove(vehiculo);

                return lavadero;
            }
        #endregion
    }
}

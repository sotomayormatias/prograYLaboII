using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lavadero
{
    public class Auto : Vehiculo
    {
        #region Atributos
            private int _cantidadAsientos;
        #endregion

        #region Constructores
            public Auto(string patente, Byte cantRuedas, EMarcas marca, int cantAsientos) : base(patente, cantRuedas, marca)
            {
                this._cantidadAsientos = cantAsientos;
            }
        #endregion

        #region Metodos
            public string MostrarAuto(){
                string mensaje = base.Mostrar();
                mensaje += "Cantidad de asientos: " + this._cantidadAsientos + "\n\n";

                return mensaje;
            }
        #endregion
    }
}

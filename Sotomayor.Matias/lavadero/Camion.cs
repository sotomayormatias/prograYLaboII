using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lavadero
{
    public class Camion : Vehiculo
    {
        #region Atributos
            private float _tara;
        #endregion

        #region Constructores
            public Camion(string patente, Byte cantRuedas, EMarcas marca, float tara) : base(patente, cantRuedas, marca)
            {
                this._tara = tara;
            }
        #endregion

        #region Metodos
        public string MostrarCamion()
        {
            string mensaje = base.Mostrar();
            mensaje += "Tara: " + this._tara + "\n\n";

            return mensaje;
        }
        #endregion
    }
}

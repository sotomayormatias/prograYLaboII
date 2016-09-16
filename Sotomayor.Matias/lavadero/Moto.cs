using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lavadero
{
    public class Moto : Vehiculo
    {
        #region Atributos
            private float _cilindrada;
        #endregion

        #region Constructores
            public Moto(string patente, Byte cantRuedas, EMarcas marca, float cilindrada) : base(patente, cantRuedas, marca)
            {
                this._cilindrada = cilindrada;
            }
        #endregion

        #region Metodos
            public string MostrarMoto()
            {
                string mensaje = base.Mostrar();
                mensaje += "Cilindrada: " + this._cilindrada + "\n";

                return mensaje;
            }
        #endregion
    }
}

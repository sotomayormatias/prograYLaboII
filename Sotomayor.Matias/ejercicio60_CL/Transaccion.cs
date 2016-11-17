using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio60_CL
{
    [Serializable]
    public class Transaccion
    {
        public DateTime _fecha;
        public decimal _importe;

        public Transaccion()
        { }

        public Transaccion(DateTime fecha, decimal importe)
        {
            this._fecha = fecha;
            this._importe = importe;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Fecha: " + this._fecha.ToString());
            sb.AppendLine("Importe: $" + this._importe.ToString());

            return sb.ToString();
        }
    }
}

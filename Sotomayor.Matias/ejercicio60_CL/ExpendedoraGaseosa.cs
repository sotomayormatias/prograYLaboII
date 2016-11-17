using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ejercicio60_CL
{
    [Serializable]
    public class ExpendedoraGaseosa : Expendedora, IOperacion
    {
        public int _stock;

        [XmlIgnore]
        public bool TieneStock
        {
            get
            {
                return this._stock > 0;
            }
        }

        public override Expendedora.eEstado Estado { get; set; }

        public ExpendedoraGaseosa()
        { }

        public ExpendedoraGaseosa(string marca, DateTime fechaFabricacion, int stockInicial)
            : base(marca, fechaFabricacion)
        {
            this._stock = stockInicial;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.DatosExpendedora());
            sb.AppendLine("Stock: " + this._stock);

            return sb.ToString();
        }

        public bool ImprimirTicket(decimal importe)
        {
            if (this.Estado == eEstado.Disponible && this.TieneStock)
            {
                Transaccion trans = new Transaccion(DateTime.Now, importe);
                Console.WriteLine(trans.ToString());
                this._stock--;
                this._transacciones.Add(trans);
                return true;
            }
            else 
            {
                this.Estado = eEstado.NoDisponible;
                throw new ImpresionTicketException("La expendedora de gaseosas no tiene stock o no esta disponible");
            }
        }
    }
}

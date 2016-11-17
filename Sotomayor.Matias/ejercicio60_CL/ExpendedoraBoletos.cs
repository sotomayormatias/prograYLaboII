using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ejercicio60_CL
{
    [Serializable]
    public class ExpendedoraBoletos : Expendedora, IOperacion
    {
        public int _mmPapelDisponible;

        [XmlIgnore]
        public bool TienePapel
        {
            get
            {
                return this._mmPapelDisponible > 0;
            }
        }

        public override Expendedora.eEstado Estado { get; set; }

        public ExpendedoraBoletos()
        { }

        public ExpendedoraBoletos(string marca, DateTime fechaFabricacion, int papelInicial)
            : base(marca, fechaFabricacion)
        {
            this._mmPapelDisponible = papelInicial;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.DatosExpendedora());
            sb.AppendLine("papel disponible: " + this._mmPapelDisponible);

            return sb.ToString();
        }

        public bool ImprimirTicket(decimal importe)
        {
            if (this.Estado == eEstado.Disponible && this.TienePapel)
            {
                Transaccion trans = new Transaccion(DateTime.Now, importe);
                Console.WriteLine(trans.ToString());
                this._mmPapelDisponible -= 15;
                this._transacciones.Add(trans);
                return true;
            }
            else 
            {
                this.Estado = eEstado.NoDisponible;
                throw new ImpresionTicketException("La expendedora de boletos no tiene papel o no esta disponible");
            }
        }
    }
}

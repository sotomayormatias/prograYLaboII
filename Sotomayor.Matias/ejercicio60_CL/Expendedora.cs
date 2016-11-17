using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ejercicio60_CL
{
    [Serializable]
    [XmlInclude(typeof(Transaccion))]
    [XmlInclude(typeof(ExpendedoraBoletos))]
    [XmlInclude(typeof(ExpendedoraGaseosa))]
    public abstract class Expendedora
    {
        public enum eEstado { Disponible, NoDisponible }

        public string _marca;
        public DateTime _fechaFabricacion;
        public List<Transaccion> _transacciones;

        public List<Transaccion> Transacciones
        {
            get
            {
                return this._transacciones;
            }
        }

        public abstract eEstado Estado { get; set; }

        public Expendedora()
        {
            this._transacciones = new List<Transaccion>();
        }

        public Expendedora(string marca, DateTime fechaFabricacion)
            :this()
        {
            this._marca = marca;
            this._fechaFabricacion = fechaFabricacion;
        }

        public virtual string DatosExpendedora()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Marca: " + this._marca);
            sb.AppendLine("Fecha de fabricacion: " + this._fechaFabricacion.ToString());
            sb.AppendLine("Estado: " + this.Estado);
            sb.AppendLine("Transacciones: ");
            foreach (Transaccion trans in this._transacciones)
            {
                sb.AppendLine(trans.ToString());
            }

            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase13_ClassLibrary
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }

        public string Marca
        {
            get
            {
                return this._marca;
            }
            set
            {
                this._marca = value;
            }
        }

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public static bool operator ==(Auto unAuto, Auto otroAuto)
        {
            return unAuto._marca == otroAuto._marca && unAuto._color == otroAuto._color;
        }

        public static bool operator !=(Auto unAuto, Auto otroAuto)
        {
            return !(unAuto == otroAuto);
        }

        public override bool Equals(object obj)
        {
            return obj is Auto && this == (Auto)obj;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Marca: ");
            sb.Append(this._marca);
            sb.Append(" - Color: ");
            sb.Append(this._color + "\n");
            
            return sb.ToString();
        }
    }
}

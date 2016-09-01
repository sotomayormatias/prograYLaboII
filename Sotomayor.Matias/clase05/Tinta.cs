using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase05
{
    class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipo;

    #region Contructores
        public Tinta()
        {
            this._color = ConsoleColor.Black;
            this._tipo = ETipoTinta.Comun;
        }

        public Tinta(ConsoleColor unColor): this()//Reutiliza el constructor sin parametros
        {
            this._color = unColor;
        }

        public Tinta(ConsoleColor unColor, ETipoTinta unTipoTinta)
        {
            this._color = unColor;
            this._tipo = unTipoTinta;
        } 
    #endregion

    #region MetodosDeInstancia
        private string mostrar()
        {
            return "La tinta es de color " + this._color + " y de tipo " + this._tipo;
        } 
    #endregion

    #region MetodosDeClase
        public static string mostrar(Tinta unaTinta)
        {
            return unaTinta.mostrar();
        } 

        //Se sobrecarga el operador de comparacion "igual"
        public static bool operator ==(Tinta unaTinta, Tinta otraTinta)
        {
            bool sonIguales = false;

            if (unaTinta._color == otraTinta._color && unaTinta._tipo == otraTinta._tipo) 
            {
                sonIguales = true;
            }

            return sonIguales;
        }

        //Se sobrecarga el operador de comparacion "distinto"
        public static bool operator !=(Tinta unaTinta, Tinta otraTinta)
        {
            return !(unaTinta == otraTinta);
        }

        //Se sobrecarga el operador para mostrar por consola
        public static explicit operator string(Tinta unaTinta) {
            string mensaje = "No tiene tinta";
            if(!Object.Equals(unaTinta, null))
                mensaje = "Color: " + unaTinta._color + ", Tipo: " + unaTinta._tipo;
            return mensaje;
        }
    #endregion
    }
}

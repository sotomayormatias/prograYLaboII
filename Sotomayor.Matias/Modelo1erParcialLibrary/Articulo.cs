using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticuloClassLibrary
{
    public class Articulo
    {
        #region Atributos
            private int _codigo;
            private string _nombre;
            private float _precioCosto;
            private float _precioVenta;
            private int _stock; 
        #endregion

        #region Propiedades
            public string NombreYCodigo
            {
                get
                {
                    return this._codigo + "--" + this._nombre;
                }
            }
            public float PrecioCosto
            {
                set
                {
                    this._precioCosto = value;
                    this._precioVenta = this._precioCosto * 1.3F;
                }
            }
            public float PrecioVenta
            {
                get
                {
                    return this._precioVenta;
                }
            }
            public int Stock
            {
                set
                {
                    this._stock = value;
                }
            } 
        #endregion

        #region Constructor
        public Articulo(int codigo, string nombre, float precioCosto, int cantidad)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this.PrecioCosto = precioCosto;
            this.Stock = cantidad;
        } 
        #endregion

        #region Metodos
        public bool HayStock(int cantidad)
        {
            return this._stock >= cantidad;
        } 
        #endregion

        #region Sobrecarga de metodos
            public static bool operator ==(Articulo articuloUno, Articulo articuloDos)
            {
                bool sonIguales = false;
                if (articuloUno.NombreYCodigo == articuloDos.NombreYCodigo)
                    sonIguales = true;

                return sonIguales;
            }

            public static bool operator !=(Articulo articuloUno, Articulo articuloDos)
            {
                return !(articuloUno == articuloDos);
            }

            public static int operator +(Articulo articuloUno, Articulo articuloDos) {
                return articuloUno._stock + articuloDos._stock;
            }

            public static int operator -(Articulo articulo, int cantidad)
            {
                return articulo._stock - cantidad;
            }
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticuloClassLibrary;

namespace VentaClassLibrary
{
    public class Venta
    {
        private Articulo _articuloVendido { get; set; }
        private int _cantidad { get; set; }

        public Venta(Articulo articuloVendido, int cantidad) {
            this._articuloVendido = articuloVendido;
            this._cantidad = cantidad;
        }

        public float RetornarGanancia() {
            return this._articuloVendido.PrecioVenta * this._cantidad;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticuloClassLibrary;
using VentaClassLibrary;

namespace ComercioClassLibrary
{
    public class Comercio
    {
        private string _duenio { get; set; }
        private List<Articulo> _misArticulos { get; set; }
        private List<Venta> _misVentas { get; set; }

        public Comercio(string duenio)
        {
            this._duenio = duenio;
            this._misArticulos = new List<Articulo>();
            this._misVentas = new List<Venta>();
        }

        #region Metodos
        public void ComprarArticulo(Articulo articuloComprado)
        {
            bool yaExiste = false;

            foreach (Articulo articulo in this._misArticulos)
            {
                if (articulo == articuloComprado)
                {
                    yaExiste = true;
                    articulo.Stock = articulo + articuloComprado;
                }
            }

            if (!yaExiste)
            {
                this._misArticulos.Add(articuloComprado);
            }
        }

        public static void MostrarArticulos(Comercio comercioAMostrar)
        {
            string articulos = "Los productos existentes son \n";
            foreach (Articulo articulo in comercioAMostrar._misArticulos)
            {
                articulos += articulo.NombreYCodigo + "\n";
            }

            Console.WriteLine(articulos + "\n");
        }

        public static void MostrarGanancia(Comercio comercioParaResumen)
        {
            float ganancia = 0.0F;
            foreach (Venta venta in comercioParaResumen._misVentas)
            {
                ganancia += venta.RetornarGanancia();
            }

            Console.WriteLine("La ganancia obtenida es de: " + ganancia + "\n");
        }

        public void VenderArticulo(Articulo articuloAsociado, int cantidad)
        {
            bool yaExiste = false;

            foreach (Articulo articulo in this._misArticulos)
            {
                if (articulo == articuloAsociado)
                {
                    yaExiste = true;
                    if (articulo.HayStock(cantidad))
                    {
                        articulo.Stock = articulo - cantidad;
                        this._misVentas.Add(new Venta(articuloAsociado, cantidad));
                    }
                    else
                    {
                        Console.WriteLine("El siguiente producto no tiene stock para la venta \n" + articulo.NombreYCodigo + "\n\n");
                    }
                }
            }

            if (!yaExiste)
            {
                Console.WriteLine("El siguiente producto no existe en nuestro comercio \n" + articuloAsociado.NombreYCodigo + "\n");
            }
        }
        #endregion
    }
}

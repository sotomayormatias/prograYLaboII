using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase04
{
    class Producto
    {
        private string codBarra;
        private double precio;
        private string nombre;

        //Metodos

        public void Mostrar() {
            Console.WriteLine("precio: {0} - codigo de barra: {1} - nombre: {2} ", this.precio, this.codBarra, this.nombre);
        }

        //Constructores

        /// <summary>
        /// Constructor sin parametros, setea todos los atributos con valores default
        /// </summary>
        public Producto()
        {
            this.precio = 0.0;
            this.codBarra = "sin codigo";
            this.nombre = "sin nombre";
        }

        /// <summary>
        /// Constructor con precio
        /// </summary>
        /// <param name="unPrecio">Precio del producto</param>
        public Producto(double unPrecio):this() //el :this() llama al constructor sin parametros
        {
            this.precio = unPrecio;
        }

        /// <summary>
        /// Constructor con precio y código de barra
        /// </summary>
        /// <param name="unPrecio">Precio del producto</param>
        /// <param name="unCodBarra">Código de barra del producto</param>
        public Producto(double unPrecio, string unCodBarra):this(unPrecio) //el :this(unPrecio) llama al constructor que recibe un solo parametro
        {
            this.codBarra = unCodBarra;
        }

        /// <summary>
        /// Constructor con precio, código de barra y nombre
        /// </summary>
        /// <param name="unPrecio">Precio del producto</param>
        /// <param name="unCodBarra">Código de barra del producto</param>
        /// <param name="unNombre">Nombre del producto</param>
        public Producto(double unPrecio, string unCodBarra, string unNombre)
        {
            this.precio = unPrecio;
            this.codBarra = unCodBarra;
            this.nombre = unNombre;
        }

    }
}

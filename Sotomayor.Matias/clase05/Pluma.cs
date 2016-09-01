using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase05
{
    class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        #region Constructores
        public Pluma()
        {
            this._marca = "Sin marca";
            this._tinta = null;
            this._cantidad = 1;
        }

        public Pluma(string unaMarca)
            : this()
        {
            this._marca = unaMarca;
        }

        public Pluma(string unaMarca, Tinta unaTinta)
            : this(unaMarca)
        {
            this._tinta = unaTinta;
        }

        public Pluma(string unaMarca, Tinta unaTinta, int unaCantidad)
        {
            this._marca = unaMarca;
            this._tinta = unaTinta;
            this._cantidad = unaCantidad;
        } 
        #endregion

        #region MetodosDeInstancia
        private string mostrar()
        {
            return "Marca: " + this._marca + ", tinta: " + (string)this._tinta + ", cantidad: " + this._cantidad;
        }
        #endregion

        #region MetodosDeClase
        public static implicit operator string(Pluma unaPluma)
        {
            return unaPluma.mostrar();
        } 

        public static bool operator ==(Pluma unaPluma, Tinta unaTinta)
        {
            return unaPluma._tinta == unaTinta;
        }

        public static bool operator !=(Pluma unaPluma, Tinta unaTinta)
        {
            return !(unaPluma == unaTinta);
        }

        public static Pluma operator +(Pluma unaPluma, Tinta unaTinta){
            //si la Tinta de la pluma es null, le agrego la tinta
            //si la tinta de la pluma no es null, me fijo si las tintas son iguales, si son iguales, aumento la cantidad en uno
            //si son distintas, no incremento nada

            Pluma nuevaPluma = new Pluma(unaPluma._marca, unaPluma._tinta, unaPluma._cantidad);

            if (Object.Equals(nuevaPluma._tinta, null))
            {
                nuevaPluma._tinta = unaTinta;
            }
            else {
                if (nuevaPluma == unaTinta) {
                    nuevaPluma._cantidad++;
                }
            }

            return nuevaPluma;
        }

        public static Pluma operator -(Pluma unaPluma, Tinta unaTinta)
        {
            //unicamente le voy a poder quitar la tinta a mi pluma si la tinta que le quiero 
            //quitar es igual a la que tiene la pluma
            //si no es del mismo tipo mostrar mensaje de que no se puede hacer
            //si son iguales le voy decrementando la cantidad hasta que llego a 1 y la 
            //proxima vez que le saque la misma tinta, le pongo la tinta en null
            Pluma nuevaPluma = new Pluma(unaPluma._marca, unaPluma._tinta, unaPluma._cantidad);

            if (!Object.Equals(nuevaPluma._tinta, null))
            {
                if (nuevaPluma == unaTinta)
                {
                    if (nuevaPluma._cantidad == 1)
                        nuevaPluma._tinta = null;
                    else
                        nuevaPluma._cantidad--;
                }
                else {
                    Console.WriteLine("Las tintas son distintas y no se pueden restar");
                }
            }
            else
            {
                
            }

            return nuevaPluma;
        }
        #endregion
    }
}

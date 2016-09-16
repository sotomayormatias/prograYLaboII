using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lavadero
{
    public class Vehiculo
    {
        #region Atributos
            protected string _patente;
            public string Patente
            {
                get { return this._patente; }
            }

            protected Byte _cantRuedas;
            protected EMarcas _marca; 
        #endregion

        #region Constructores
            public Vehiculo(string patente, Byte cantRuedas, EMarcas marca) {
                this._patente = patente;
                this._cantRuedas = cantRuedas;
                this._marca = marca;
            }
        #endregion

        #region Metodos
            protected string Mostrar() {
                return "Patente: " + this.Patente +
                        "\n Marca: " + this._marca +
                        "\n Cantidad de ruedas: " + this._cantRuedas + "\n";
            }

            public void AcelerarHasta(Byte acelera) {
                Console.WriteLine("Acelero hasta " + acelera + " km/h");
            }

            public int OrdenarPorMarca(Vehiculo vehi1, Vehiculo vehi2){
                return vehi1._marca.CompareTo(vehi2._marca);
            }
        #endregion

        #region Sobrecarga de operadores
            public static Boolean operator ==(Vehiculo vehiculo1, Vehiculo vehiculo2) {
                return vehiculo1.Patente == vehiculo2.Patente;
            }

            public static Boolean operator !=(Vehiculo vehiculo1, Vehiculo vehiculo2)
            {
                return !(vehiculo1 == vehiculo2);
            }
        #endregion
    }
}

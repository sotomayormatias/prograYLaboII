using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase07
{
    class Paleta
    {
        #region Atributos y Propiedades
            private Tempera[] _temperas;
            private sbyte _cantMaximaColores;

            public sbyte CantMaximaColores
            {
                get { return this._cantMaximaColores; }
            } 
        #endregion

        #region Constructores
            private Paleta(sbyte cantMaxima)
            {
                this._cantMaximaColores = cantMaxima;
                this._temperas = new Tempera[cantMaxima];
            }

            private Paleta()
                : this(4)
            {
            } 
        #endregion

        #region Metodos privados
            private static string Mostrar(Paleta unaPaleta)
            {
                string detalle = "Cantidad maxima: " + unaPaleta._cantMaximaColores + "\n";
                for (int i = 0; i < unaPaleta.cantTemperas(); i++)
                {
                    detalle += "Tempera " + i + ": " + unaPaleta._temperas[i] + "\n";
                }

                return detalle;
            }

            private int cantTemperas()
            {
                int cant = 0;
                for (int i = 0; i < this._cantMaximaColores; i++)
                {
                    if (this._temperas.GetValue(i) != null)
                        cant++;
                }
                return cant;
            }

            /// <summary>
            /// Retorna el indice en donde se encuentra la tempera en la paleta
            /// </summary>
            /// <param name="unaTempera"></param>
            /// <returns></returns>
            private int buscarTempera(Tempera unaTempera)
            {
                int indice = -1;
                if (this == unaTempera)
                {
                    for (int i = 0; i < this.cantTemperas(); i++)
                    {
                        if (this._temperas[i] == unaTempera)
                        {
                            indice = i;
                        }
                    }
                }

                return indice;
            } 
        #endregion

        #region Sobrecarga de operadores
            //Esto es re loco porque hace que yo pueda construir una paleta con "Paleta p = 3;"
            //ya que el 3 lo intenta castear implicitamente con este metodo y devuelve una Paleta
            //Esto tiene "sentido" porque el constructor es privado, sino uso el constructor y listo
            public static implicit operator Paleta(sbyte cantidad)
            {
                return new Paleta(cantidad);
            }

            public static explicit operator string(Paleta unaPaleta)
            {
                return Paleta.Mostrar(unaPaleta);
            }

            //Retorna verdadero si en el array de temperas de la paleta hay una como la tempera pasada por parametro 
            public static bool operator ==(Paleta unaPaleta, Tempera unaTempera)
            {
                bool sonIguales = false;
                for (int i = 0; i < unaPaleta._cantMaximaColores; i++)
                {
                    if (unaPaleta._temperas.GetValue(i) != null && unaPaleta._temperas[i] == unaTempera)
                    {
                        sonIguales = true;
                    }
                }

                return sonIguales;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="unaPaleta"></param>
            /// <param name="unaTempera"></param>
            /// <returns></returns>
            public static bool operator !=(Paleta unaPaleta, Tempera unaTempera)
            {
                return !(unaPaleta == unaTempera);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="unaPaleta"></param>
            /// <param name="unaTempera"></param>
            /// <returns></returns>
            public static Paleta operator +(Paleta unaPaleta, Tempera unaTempera)
            {
                int cantTemperas = unaPaleta.cantTemperas();
                if (cantTemperas < unaPaleta._cantMaximaColores && unaPaleta != unaTempera)
                    unaPaleta._temperas[cantTemperas] = unaTempera;

                return unaPaleta;
            }

            /// <summary>
            /// Suma dos paletas, las temperas repetidas las genera una sola vez y le suma las cantidades
            /// la paleta resultante no tiene temperas nulas
            /// </summary>
            /// <param name="paleta1"></param>
            /// <param name="paleta2"></param>
            /// <returns></returns>
            public static Paleta operator +(Paleta paleta1, Paleta paleta2)
            {
                int contIguales = 0;

                for (int i = 0; i < paleta2.cantTemperas(); i++)
                {
                    if (paleta1 == paleta2._temperas[i])
                    {
                        contIguales++;
                    }
                }

                sbyte nuevaCantMax = (sbyte)(paleta1.cantTemperas() + paleta2.cantTemperas() - contIguales);
                Paleta nuevaPaleta = new Paleta(nuevaCantMax);

                for (int i = 0; i < paleta2.cantTemperas(); i++)
                {
                    if (paleta1 == paleta2._temperas[i])
                    {
                        int indice = paleta1.buscarTempera(paleta2._temperas[i]);
                        Tempera nuevaTempera = paleta1._temperas[indice] + paleta2._temperas[i];
                        nuevaPaleta += nuevaTempera;
                    }
                    else
                    {
                        nuevaPaleta += paleta2._temperas[i];
                    }
                }

                for (int i = 0; i < paleta1.cantTemperas(); i++)
                {
                    if (paleta2 != paleta1._temperas[i])
                    {
                        nuevaPaleta += paleta1._temperas[i];
                    }
                }

                return nuevaPaleta;
            }

            //Agregar el operador paleta - tempera
            //Quita la tempera de la paleta y la pone en null 
        #endregion
    }
}

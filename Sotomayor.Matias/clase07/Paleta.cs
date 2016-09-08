using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase07
{
    class Paleta
    {
        private Tempera[] _temperas;
        private sbyte _cantMaximaColores;
        
        private Paleta(sbyte cantMaxima)
        {
            this._cantMaximaColores = cantMaxima;
            this._temperas = new Tempera[cantMaxima];
        }

        private Paleta(): this(4)
        {
        }

        //Esto es re loco porque hace que yo pueda construir una paleta con "Paleta p = 3;"
        //ya que el 3 lo intenta castear implicitamente con este metodo y devuelve una Paleta
        //Esto tiene "sentido" porque el constructor es privado, sino uso el constructor y listo
        public static implicit operator Paleta(sbyte cantidad)
        {
            return new Paleta(cantidad);
        }

        public static explicit operator string(Paleta unaPaleta) {
            return Paleta.Mostrar(unaPaleta);
        }

        private static string Mostrar(Paleta unaPaleta) {
            string detalle = "Cantidad maxima: " + unaPaleta._cantMaximaColores + "\n";
            for(int i = 0; i < unaPaleta._cantMaximaColores; i++) {
                detalle += "Tempera " + i + ": " + unaPaleta._temperas[i];
            }

            return detalle;
        }

        //Retorna verdadero si en el array de temperas de la paleta hay una como la tempera pasada por parametro 
        public static bool operator ==(Paleta unaPaleta, Tempera unaTempera) {
            bool sonIguales = false;
            foreach (Tempera temp in unaPaleta._temperas)
            {
                if (temp == unaTempera) {
                    sonIguales = true;
                }
            }

            return sonIguales;
        }

        public static bool operator !=(Paleta unaPaleta, Tempera unaTempera)
        {
            return !(unaPaleta == unaTempera);
        }

        public static Paleta operator +(Paleta unaPaleta, Tempera unaTempera){
            int cantTemperas = unaPaleta.cantTemperas();
            if (cantTemperas < unaPaleta._cantMaximaColores && unaPaleta != unaTempera)
                unaPaleta._temperas[cantTemperas] = unaTempera;

            return unaPaleta;
        }

        private int cantTemperas() {
            int cant = 0;
            foreach (Tempera temp in this._temperas)
            {
                if (temp != null)
                    cant++;
            }
            return cant;
        }

        //Falta agregar el paleta + paleta
        //esto genera una nueva paleta con la suma de posibles temperas de ambas paletas sumadas
        //Si las dos paletas tienen alguna de las temperas iguales, se genera una con la suma de las cantidades

        //Agregar el operador paleta - tempera
        //Quita la tempera de la paleta y la pone en null
    }
}

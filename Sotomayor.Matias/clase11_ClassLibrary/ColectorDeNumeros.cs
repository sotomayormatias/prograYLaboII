using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase11_ClassLibrary
{
    public class ColectorDeNumeros
    {
        protected List<Numero> _numeros;

        public ETipoNumero TipoNumero { get; set; }

        public double SumaDeNumeros
        {
            get
            {
                return ColectorDeNumeros.ObtenerResultado(this, ETipoResultado.Suma);
            }
        }

        public double RestaDeNumeros
        {
            get
            {
                return ColectorDeNumeros.ObtenerResultado(this, ETipoResultado.Resta);
            }
        }

        public double MultiplicacionDeNumeros
        {
            get
            {
                return ColectorDeNumeros.ObtenerResultado(this, ETipoResultado.Multiplicacion);
            }
        }

        public double DivisionDeNumeros
        {
            get
            {
                return ColectorDeNumeros.ObtenerResultado(this, ETipoResultado.Division);
            }
        }

        private ColectorDeNumeros()
        {
            this._numeros = new List<Numero>();
        }

        public ColectorDeNumeros(ETipoNumero tipoNumero)
            : this()
        {
            this.TipoNumero = tipoNumero;
        }

        public static ColectorDeNumeros operator +(ColectorDeNumeros colector, Numero num)
        {
            colector._numeros.Add(num);
            return colector;
        }

        public static ColectorDeNumeros operator -(ColectorDeNumeros colector, Numero num)
        {
            colector._numeros.Remove(num);
            return colector;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Numero num in this._numeros)
            {
                sb.Append(num.Lectura + "\n");
            }

            return sb.ToString();
        }

        protected static double ObtenerResultado(ColectorDeNumeros colector, ETipoResultado tipoResultado)
        {
            double resultado = 0;

            if (colector._numeros.Count > 0)
            {
                for (int i = 1; i < colector._numeros.Count; i++)
                {
                    switch(tipoResultado)
                    {
                        case ETipoResultado.Suma:
                            resultado += colector._numeros[0] + colector._numeros[i];
                            break;
                        case ETipoResultado.Resta:
                            resultado -= colector._numeros[0] - colector._numeros[i];
                            break;
                        case ETipoResultado.Multiplicacion:
                            resultado *= colector._numeros[0] * colector._numeros[i];
                            break;
                        case ETipoResultado.Division:
                            resultado /= colector._numeros[0] / colector._numeros[i];
                            break;
                    }
                }
            }
            return resultado;
        }
    }
}

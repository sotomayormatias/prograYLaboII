using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio61_CL
{
    [Serializable]
    public class Pasajero
    {
        public enum eRango { Azafata, Cocinero, Maquinista, Cliente };

        public string Apellido;
        public string Nombre;
        public eRango rango;

        public Pasajero()
        { }

        public Pasajero(string nombre, string apellido, eRango rango)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.rango = rango;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Apellido: " + this.Apellido);
            sb.AppendLine("Rango: " + this.rango);
            
            return sb.ToString();
        }
    }
}

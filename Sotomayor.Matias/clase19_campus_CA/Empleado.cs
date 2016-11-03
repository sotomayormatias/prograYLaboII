using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase19_campus_CA
{
    public class Empleado : Persona
    {
        public enum EPuestoJerarquico { Administracion, Gerencia, Sistemas, Accionista };

        #region Atributos
        public string _legajo;
        public EPuestoJerarquico _puesto;
        public int _salario;
        #endregion

        #region Constructor
        public Empleado()
        { 
            
        }

        public Empleado(string nombre, string apellido, string legajo, EPuestoJerarquico puesto, int salario)
            : base(nombre, apellido)
        {
            this._legajo = legajo;
            this._puesto = puesto;
            this._salario = salario;
        }

        public Empleado(Persona persona, string legajo, EPuestoJerarquico puesto, int salario)
            : this(persona.Nombre, persona.Apellido, legajo, puesto, salario)
        { }
        #endregion

        #region Sobrecarga de Operadores
        public static Boolean operator ==(Empleado empleado1, Empleado empleado2)
        {
            return empleado1._legajo == empleado2._legajo;
        }

        public static Boolean operator !=(Empleado empleado1, Empleado empleado2)
        {
            return !(empleado1 == empleado2);
        }
        #endregion

        #region Metodos de instancia
        public void Mostrar(IGrafica grafica)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE: " + this._nombre);
            sb.AppendLine("APELLIDO: " + this._apellido);
            sb.AppendLine("LEGAJO: " + this._legajo);
            sb.AppendLine("PUESTO: " + this._puesto);
            sb.AppendLine("SALARIO: $" + this._salario + "\n");

            grafica.MostrarEnGUI(sb.ToString());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE: " + this._nombre);
            sb.AppendLine("APELLIDO: " + this._apellido);
            sb.AppendLine("LEGAJO: " + this._legajo);
            sb.AppendLine("PUESTO: " + this._puesto);
            sb.AppendLine("SALARIO: $" + this._salario + "\n");

            return sb.ToString();
        }
        #endregion
    }
}

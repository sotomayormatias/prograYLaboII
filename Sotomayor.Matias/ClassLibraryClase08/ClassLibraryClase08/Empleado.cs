using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryClase08
{
    public class Empleado
    {
        #region Atributos
        private string _nombre;
        private string _apellido;
        private string _legajo;
        private EPuestoJerarquico _puesto;
        private int _salario; 
        #endregion

        #region Constructor
            public Empleado(string nombre, string apellido, string legajo, EPuestoJerarquico puesto, int salario)
            {
                this._nombre = nombre;
                this._apellido = apellido;
                this._legajo = legajo;
                this._puesto = puesto;
                this._salario = salario;
            } 
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
            public string Mostrar()
            {
                return "NOMBRE: " + this._nombre + "\n" +
                    "APELLIDO: " + this._apellido + "\n" +
                    "LEGAJO: " + this._legajo + "\n" +
                    "PUESTO: " + this._puesto + "\n" +
                    "SALARIO: $" + this._salario + "\n\n";
            } 
        #endregion
    }
}

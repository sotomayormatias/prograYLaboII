using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryClase08
{
    public class Empresa
    {
        #region Atributos
        private List<Empleado> _nominaEmpleados;
        private string _razonSocial;
        public string RazonSocial 
        {
            get { return this._razonSocial; }
            set { this._razonSocial = value; }
        }

        private string _direccion;
        public string Direccion
        {
            get { return this._direccion; }
            set { this._direccion = value; }
        }

        private float _ganancias;
        public float Ganancias
        {
            get { return this._ganancias; }
            set { this._ganancias = value; }
        }
        #endregion

        #region Constructores
        private Empresa() 
        { 
            
        }
        #endregion

//Codificar un constructor privado por defecto. Este será el único lugar donde se instanciará la nómina de empleados.
//Codificar otro constructor que reciba como parámetro la razón social, dirección y ganancias de la Empresa.
//Sobrecarga del operador + (Empresa, Empleado). Si el empleado no existe, lo agrega a la nómina.
//Método MostrarEmpresa() : string. Retornará la lista de empleados con el siguiente formato:
    }
}

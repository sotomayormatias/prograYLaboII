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
                this._nominaEmpleados = new List<Empleado>();
            }

            public Empresa(string razonSocial, string direccion, int ganancias) : this()
            {
                this.RazonSocial = razonSocial;
                this.Direccion = direccion;
                this.Ganancias = ganancias;
            }

            public static Empresa operator +(Empresa unaEmpresa, Empleado unEmpleado) {
                if (unaEmpresa != unEmpleado)
                    unaEmpresa._nominaEmpleados.Add(unEmpleado);

                return unaEmpresa;
            }

        #endregion


        #region Sobreacarga de operadores
            public static Boolean operator ==(Empresa unaEmpresa, Empleado unEmpleado)
            {
                bool sonIguales = false;
                foreach (Empleado empl in unaEmpresa._nominaEmpleados)
                {
                    if (empl == unEmpleado)
                        sonIguales = true;
                }

                return sonIguales;
            }

            public static Boolean operator !=(Empresa unaEmpresa, Empleado unEmpleado)
            {
                return !(unaEmpresa == unEmpleado);
            } 
        #endregion

        #region Metodos
            public string MostrarEmpresa() {
                string mensaje = "La empresa " + this.RazonSocial + " sita en la calle " + this.Direccion + " cuenta con ganancias por " + this.Ganancias + " y con " + this._nominaEmpleados.Count() + " empleados:\n";

                foreach (Empleado empl in this._nominaEmpleados)
                {
                    mensaje += empl.Mostrar();
                }

                return mensaje;
            }
        #endregion
    }
}

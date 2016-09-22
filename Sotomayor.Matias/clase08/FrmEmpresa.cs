using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryClase08;

namespace clase08
{
    public partial class frmEmpresa : Form
    {
        private Empresa _empresa;
        public Empresa Empresa { 
            get { return this._empresa; }
            set { this._empresa = value; }
        }

        public frmEmpresa()
        {
            InitializeComponent();
        }

        public frmEmpresa(Empresa empresa)
        {
            InitializeComponent();
            this.Empresa = empresa;
            if (!Object.Equals(this.Empresa, null)) 
            {
                txtRazonSocial.Text = this.Empresa.RazonSocial;
                txtDireccion.Text = this.Empresa.Direccion;
                mtxtGanancias.Text = this.Empresa.Ganancias.ToString();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float ganancias = float.Parse(this.mtxtGanancias.Text.Replace(".", ",").Substring(1, mtxtGanancias.Text.Length - 1));
            if(Object.Equals(this.Empresa, null))
            {
                Empresa = new Empresa(txtRazonSocial.Text, txtDireccion.Text, ganancias);
            }
            else 
            {
                this.Empresa.RazonSocial = txtRazonSocial.Text;
                this.Empresa.Direccion = txtDireccion.Text;
                this.Empresa.Ganancias = ganancias;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}

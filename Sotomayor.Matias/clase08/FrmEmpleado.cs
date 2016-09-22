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
    public partial class FrmEmpleado : Form
    {
        private Empresa _empresa;
        public Empresa Empresa 
        { 
            get { return this._empresa; }
            set { this._empresa = value; }
        }

        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            cmbPuesto.DataSource = Enum.GetValues(typeof(EPuestoJerarquico));
            btnEmpresa_Click(sender, e);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            frmEmpresa frm = new frmEmpresa(this.Empresa);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this.Empresa = frm.Empresa;
            }
            else 
            {
                this.Close();
            }
        }

        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            mtxtLegajo.Clear();
            mtxtSalario.Clear();
            cmbPuesto.SelectedIndex = 0;
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            int salario;
            EPuestoJerarquico puesto;

            if (!int.TryParse(mtxtSalario.Text.Substring(1, mtxtSalario.Text.Length - 1), out salario)) {
                MessageBox.Show("El salario debe ser numerico y mayor a 0");
                return;
            }
            if (!Enum.TryParse<EPuestoJerarquico>(cmbPuesto.SelectedValue.ToString(), out puesto)) 
            {
                MessageBox.Show("El puesto debe ser un valor valido dentro del combo");
                return;
            }

            Empleado empleado = new Empleado(txtNombre.Text, txtApellido.Text, mtxtLegajo.Text, puesto, salario);
            this.Empresa += empleado;
            rtxtConsola.Text = this.Empresa.MostrarEmpresa();
        }
    }
}

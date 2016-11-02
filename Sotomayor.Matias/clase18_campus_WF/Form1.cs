using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clase18_campus_CL;

namespace clase18_campus_WF
{
    public partial class Form1 : Form, IGrafica
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void MostrarEnGUI(string datos)
        {
            lblDatos.Text = datos;
        }

        public bool EscribirTXT(string path, Empleado e)
        {
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado("Norberto", "Napolitano", "1234", Empleado.EPuestoJerarquico.Gerencia, 999999999);
            empleado.Mostrar(this);
        }
    }
}

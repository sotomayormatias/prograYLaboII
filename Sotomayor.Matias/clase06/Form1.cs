using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase06
{
    public partial class Form1 : Form
    {
        private int cantClicks = 1;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Bienvenidos!! " + DateTime.Now;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.lblSaludo.Text = "Hola mundo!";
            switch (cantClicks) { 
                case 1:
                    this.BackColor = Color.Purple;
                    this.cantClicks++;
                    break;
                case 2:
                    this.BackColor = Color.Red;
                    this.cantClicks++;
                    break;
                case 3:
                    this.BackColor = Color.Yellow;
                    this.cantClicks++;
                    break;
                case 4:
                    this.BackColor = Color.Green;
                    this.cantClicks = 1;
                    break;
            }
        }

    }
}

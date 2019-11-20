using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppIUWin
{
    public partial class TareaEcuaciones : Form
    {
        public TareaEcuaciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            double a, b, c,com;
            a = Double.Parse(this.txta.Text);
            b = Double.Parse(this.txtb.Text);
            c = Double.Parse(this.txtc.Text);
            if (a == 0)
            {
                MessageBox.Show("El valor de la division no puede ser 0");
            }
            com = (b * b) - (4 * a * c);
            if (com<0)
            {
                MessageBox.Show("La ecuacion tiene soluciones imaginarias");
                return;
            }
            double x1 = Ecuacion2dogrado.ecuacion2dogrado.ecu2dosuma(a, b, c);
            double x2 = Ecuacion2dogrado.ecuacion2dogrado.ecu2doresta(a, b, c);
            this.x1.Text = x1.ToString("0.00");
            this.x2.Text = x2.ToString("0.00");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.txta.Text = "";
            this.txtb.Text = "";
            this.txtc.Text = "";
            this.x1.Text = "";
            this.x2.Text = "";
        }
    }
}

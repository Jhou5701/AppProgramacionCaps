using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Ecuacion2dogradoo : Form
    {
        public Ecuacion2dogradoo()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.txta.Text = "";
            this.txtb.Text = "";
            this.txtc.Text = "";
            this.txtresultado.Text = "";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            double a, b, c, resultado1, resultado2;
            a = Double.Parse(this.txta.Text);
            b = Double.Parse(this.txtb.Text);
            c = Double.Parse(this.txtc.Text);
            resultado1 = ecuacion2dogrado.ecu2dosuma(a,b,c);
            resultado2 = ecuacion2dogrado.ecu2doresta(a, b, c);
            this.txtresultado.Text = resultado1.ToString();
            this.txtresultado.Text = resultado2.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

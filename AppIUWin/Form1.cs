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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int num;
            double res;

            num = int.Parse(this.txtingreso.Text);
            res = AppProgramacionCaps.Factorial.fact(num);
            this.txtresultado.Text = res.ToString();

        }
    }
}

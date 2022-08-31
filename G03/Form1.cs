using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            int r, x, a, b;
            a = int.Parse(txtValor1.Text);
            b = int.Parse(txtValor2.Text);
            x = a + b;
            if(x >= 10)
            {
                r = x + 5;
                MessageBox.Show("R = " + r.ToString(), "Resultado V");
            } 
            else
            {
                r = x - 7;
                MessageBox.Show("R = " + r.ToString(), "Resultado F");
            }
            txtValor1.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float a, b, r = 0;
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);

            if (rbAdicao.Checked)
                r = a + b;
            if (rbSubtracao.Checked)
                r = a - b;
            if (rbMultiplicacao.Checked)
                r = a * b;
            if(rbDivisao.Checked)
                if(b == 0)
                {
                    MessageBox.Show("Tentou dividir por 0 !", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                } else
                    r = a / b;
            txtRes.Text = r.ToString();
        }

        private void rbDivisao_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}

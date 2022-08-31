using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, c, r;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            if ((a + b) < c || (b + c) < a || (a + c) < b)
                MessageBox.Show("Não é tringulo","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                if(a == b && b == c)
                {
                    label1.Text = "Triangulo equilátero";
                    //pictureBox1.ImageLocation = ;
                }
                else 
                {
                    if (a == b || b == c)
                        label1.Text = "Triangulo isósceles";
                    else
                        label1.Text = "Triangulo escaleno";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

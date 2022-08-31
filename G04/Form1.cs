using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            do
            {
                resp = MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {
                    MessageBox.Show("OK", "Resposta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Oloco... :( ", " :( ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            } while (resp != DialogResult.Yes);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show(
                "Marea Turbo com GNV ?",
                "MAREA",
                MessageBoxButtons.YesNo
            );
            if (resp == DialogResult.Yes)
                MessageBox.Show("Explodiu!!!", "BOOOM!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Cuidado! Ainda á 99,8% de risco de explosão... ","VISHH",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Mensagem",
                "Titulo",
                MessageBoxButtons.AbortRetryIgnore
            );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Mensagem",
                "Titulo",
                MessageBoxButtons.YesNoCancel
            );
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Mensagem",
                "Titulo",
                MessageBoxButtons.RetryCancel
            );
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Mensagem",
                "Titulo",
                MessageBoxButtons.YesNo
            );
        }

        private void button7_Click(object sender, EventArgs e)
            { 
            MessageBox.Show(
                "Mensagem",
                "Titulo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Mensagem",
                "Titulo",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
            );
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Mensagem",
                "Titulo",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error
            );
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Mensagem",
                "Titulo",
                MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Question
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrayanQuiz_2DSB
{
    public partial class pergunta7 : Form
    {
        public pergunta7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pergunta8 = new pergunta8();
            pergunta8.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                contagem.ponto++;
                pictureBox2.Image = Properties.Resources.aaa;
                pictureBox3.Image = Properties.Resources.certo;
                MessageBox.Show("Resposta Correta! +1 ponto");

            }
            else if (radioButton2.Checked)
            {
                pictureBox2.Image = Properties.Resources.bbb;
                pictureBox4.Image = Properties.Resources.errado;
                MessageBox.Show("Resposta Errada");
            }
            else if (radioButton3.Checked)
            {
                pictureBox2.Image = Properties.Resources.bbb;
                pictureBox5.Image = Properties.Resources.errado;
                MessageBox.Show("Resposta Errada");
            }

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class pergunta9 : Form
    {
        public pergunta9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pergunta10 = new pergunta10();
            pergunta10.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                contagem.ponto++;
                pictureBox2.Image = Properties.Resources.aaa;
                pictureBox4.Image = Properties.Resources.certo;
                MessageBox.Show("Resposta Correta! +1 ponto");

            }
            else if (radioButton1.Checked)
            {
                pictureBox2.Image = Properties.Resources.bbb;
                pictureBox3.Image = Properties.Resources.errado;
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
    }
}

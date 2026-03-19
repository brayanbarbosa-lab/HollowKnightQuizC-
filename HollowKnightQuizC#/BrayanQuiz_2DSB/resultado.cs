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
    public partial class resultado : Form
    {

    
        public resultado()
        {
            InitializeComponent();
        }

        private void resultado_Load(object sender, EventArgs e)
        {
            if(contagem.ponto <= 5) {
                this.BackgroundImage = Properties.Resources.perdeu;
                label1.Text = "Perdedor!!! você teve " + contagem.ponto.ToString() + " acertos, você foi derrotado pelo meu quiz";

            }

            else if(contagem.ponto > 5 && contagem.ponto <= 8){

                this.BackgroundImage = Properties.Resources.medio;
                label1.Text = "Parabéns! você teve " + contagem.ponto.ToString() + " acertos, você até que foi bem :)";
            }

            else if( contagem.ponto == 9 || contagem.ponto == 10)
            {
                this.BackgroundImage= Properties.Resources.vitória;
                label1.Text = "UAU!!! você teve " + contagem.ponto.ToString() + " acertos, você alcançou o topo de Hallownest!!!";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

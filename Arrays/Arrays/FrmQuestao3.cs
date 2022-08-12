using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Arrays
{
    public partial class FrmQuestao3 : Form
    {
        Thread T1;
        public FrmQuestao3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txbOutput.Text = "";
            bool teste = Verificar(txbInputLinha.Text, txbInputColuna.Text);
            if (!teste)
            {
                txbOutput.ForeColor = Color.Red;
                txbOutput.Text = "Valores inválidos";
                return;
            }
            int Linha = int.Parse(txbInputLinha.Text);
            int Coluna = int.Parse(txbInputColuna.Text);
            int count = 1;

            for (int i = 0; i < Linha; i++)
            {
                for (int j = 0; j < Coluna; j++)
                {
                    txbOutput.Text += count.ToString();
                    count++;
                    if (j != Coluna - 1) txbOutput.Text += ',';
                }
                txbOutput.Text += @"
";
            }
        }

        private bool Verificar(string Linha, string Coluna)
        {
            if (int.TryParse(Linha, out _) && int.TryParse(Coluna, out _))
            {
                return true;
            }
            return false;
        }
        private void questao1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            T1 = new Thread(Form1);
            T1.SetApartmentState(ApartmentState.STA);
            T1.Start();
        }

        private void questao2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            T1 = new Thread(Form2);
            T1.SetApartmentState(ApartmentState.STA);
            T1.Start();
        }

        private void questao3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            T1 = new Thread(Form3);
            T1.SetApartmentState(ApartmentState.STA);
            T1.Start();
        }

        private void questao4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            T1 = new Thread(Form4);
            T1.SetApartmentState(ApartmentState.STA);
            T1.Start();
        }

        private void Form1(object obj)
        {
            Application.Run(new FrmQuestao1());
        }
        private void Form2(object obj)
        {
            Application.Run(new FrmQuestao2());
        }
        private void Form3(object obj)
        {
            Application.Run(new FrmQuestao3());
        }
        private void Form4(object obj)
        {
            Application.Run(new FrmQuestao4());
        }
    }
}

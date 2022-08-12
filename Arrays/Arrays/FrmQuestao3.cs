using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class FrmQuestao3 : Form
    {
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
    }
}

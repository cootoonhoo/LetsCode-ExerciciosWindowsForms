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
    public partial class FrmQuestao1 : Form
    {
        Thread T1;
        int i = 0;
        public FrmQuestao1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] ArrayNumber = new int[10], ArrEven = new int[10], ArrOdds = new int[10];
            i = 0;
            txbImpares.Text = "";
            txbPares.Text = "";
            txbCrescente.Text = "";
            if (!Validation(txbInput.Text)) {
                txbCrescente.ForeColor = Color.Red;
                txbCrescente.Text = "Input inválido";
                txbPares.ForeColor = Color.Red;
                txbPares.Text = "Input inválido";
                txbImpares.ForeColor = Color.Red;
                txbImpares.Text = "Input inválido";
                return;
            }
            foreach (var character in txbInput.Text.Split(','))
            {
                ArrayNumber[i] = int.Parse(character);
                i++;
            }

            Array.Sort(ArrayNumber);

            int j = 0, k = 0;
            for (int i = 0; i < ArrayNumber.Length; i++)
            {
                if (ArrayNumber[i] % 2 == 0)
                {
                    ArrEven[j] = ArrayNumber[i];
                    j++;
                }
                else
                {
                    ArrOdds[k] = ArrayNumber[i];
                    k++;
                }
            }

            txbCrescente.ForeColor = Color.Black;
            txbPares.ForeColor = Color.Black;
            txbImpares.ForeColor = Color.Black;

            for (int i = 0; i < ArrEven.Length; i++) {
                if (ArrEven[i] != 0) {
                    txbPares.Text += ArrEven[i];
                if (i != ArrEven.Length - 1) txbPares.Text += ',';
                }
            }
            for (int i = 0; i < ArrOdds.Length; i++)
            {
                if (ArrOdds[i] != 0)
                {
                    txbImpares.Text += ArrOdds[i];
                if (i != ArrOdds.Length - 1) txbImpares.Text += ',';
                }
            }
            for (int i = 0; i < ArrayNumber.Length; i++)
            {
                if (ArrayNumber[i] != 0)
                {
                    txbCrescente.Text += ArrayNumber[i];
                    if (i != ArrayNumber.Length - 1) txbCrescente.Text += ',';
                }
            }

            txbImpares.Text.Remove(txbImpares.Text.Length - 2, 1);
            txbPares.Text.Remove(txbPares.Text.Length - 2, 1);
        }
        bool Validation(string txt)
        {
            foreach (var character in txbInput.Text.Split(','))
            {
                bool teste = int.TryParse(character.ToString(), out _) && txbInput.Text.Split(',').Length <= 10;
                if (!teste) return false;
            }
            return true;
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

        private void Form1(object obj) {
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

        private void txbInput_TextChanged(object sender, EventArgs e)
        {
            txbInput.ForeColor = Color.Black;
        }
        private void txbInput_Click(object sender, EventArgs e)
        {
            txbInput.Text = "";
        }
        private void txbInput_Leave(object sender, EventArgs e)
        {
            if (txbInput.Text == "")
            {
                txbInput.Text = "1,2,3,4...";
                txbInput.ForeColor = Color.Silver;

            }
        }
    }
}

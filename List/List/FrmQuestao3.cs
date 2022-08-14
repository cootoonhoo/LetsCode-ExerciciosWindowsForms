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

namespace List
{
    public partial class FrmQuestao3 : Form
    {
        Thread T1;
        int MinPos = int.MaxValue, MaxNeg = int.MinValue;
        List<int> Lista = new();
        public FrmQuestao3()
        {
            InitializeComponent();
        }

        private void txbLista_Enter(object sender, EventArgs e)
        {
            if (txbLista.Text == "1,-2,3 ...")
            {
                txbLista.ForeColor = Color.Black;
                txbLista.Text = "";
            }
        }

        private void txbLista_Leave(object sender, EventArgs e)
        {
            if (txbLista.Text == "")
            {
                txbLista.ForeColor = Color.Gray;
                txbLista.Text = "1,-2,3 ...";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Lista.Clear();
            if (!Validation())
            {
                lblOutput.ForeColor = Color.Red;
                lblOutput.Text = "Lista inválida";
                txbLista.Text = "";
                return;
            }
            foreach (var item in txbLista.Text.Split(','))
            {
                var Numero = int.Parse(item);
                Lista.Add(Numero);
            }
            int Positivo = Lista.Max();
            int Negativo = Lista.Min();

            if (Positivo == Negativo * -1) {
                lblOutput.ForeColor = Color.Black;
                lblOutput.Text = "Nenhum";
            }
            else if (Positivo > Negativo * -1)
            {
                lblOutput.ForeColor = Color.Black;
                lblOutput.Text = $"{Lista.Min()}";
            }
            else {
                lblOutput.ForeColor = Color.Black;
                lblOutput.Text = $"{Lista.Max()}";
            }
        }
        private bool Validation()
        {
            foreach (var item in txbLista.Text.Split(','))
            {
                if (!int.TryParse(item.ToString(), out _))
                {
                    return false;
                }
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
    }
}

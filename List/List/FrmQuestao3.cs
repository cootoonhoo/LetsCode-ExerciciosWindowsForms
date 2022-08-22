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
        List<int> ListaPositiva = new();
        List<int> ListaNegativa = new();
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
            ListaPositiva.Clear();
            ListaPositiva.Clear();
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
                if (Numero >= 0)
                {
                    ListaPositiva.Add(Numero);
                }
                else {
                    ListaNegativa.Add(Numero);
                }
            }
            int Positivo;
            int Negativo;

            if (ListaPositiva.Count == 0)
                Positivo = int.MaxValue;
            else
                Positivo = ListaPositiva.Min();

            if (ListaNegativa.Count == 0)
                Negativo = int.MinValue;
            else
                Negativo = ListaPositiva.Min();

            if (Positivo == Math.Abs(Negativo)) {
                lblOutput.ForeColor = Color.Black;
                lblOutput.Text = "Nenhum";
            }
            else if (Positivo > Math.Abs(Negativo))
            {
                lblOutput.ForeColor = Color.Black;
                lblOutput.Text = $"{Negativo}";
            }
            else {
                lblOutput.ForeColor = Color.Black;
                lblOutput.Text = $"{Positivo}";
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

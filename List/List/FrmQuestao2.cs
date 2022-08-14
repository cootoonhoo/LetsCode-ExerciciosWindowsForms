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
    public partial class FrmQuestao2 : Form
    {
        Thread T1;
        public FrmQuestao2()
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
            txbAmplitude.Text = "";
            int Max = int.MinValue, Min = int.MaxValue;
            if (!Validation())
            {
                txbAmplitude.ForeColor = Color.Red;
                txbAmplitude.Text = "Lista inválida";
                txbLista.Text = "";
                return;
            }
            foreach (var item in txbLista.Text.Split(',')) {
                var Numero = int.Parse(item);
                if (Numero > Max)
                {
                    Max = Numero;
                }
                if (Numero < Min) {
                    Min = Numero;
                }
            }
            txbAmplitude.ForeColor = Color.Black;
            txbAmplitude.Text = $"{Max - Min}";

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

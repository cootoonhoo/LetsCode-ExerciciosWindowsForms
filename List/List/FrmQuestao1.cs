using System.Threading;

namespace List
{
    public partial class FrmQuestao1 : Form
    {
        Thread T1;
        int SomPos = 0, SomNeg = 0;
        List<int> Lista = new List<int>();

        private void txbLista_Leave(object sender, EventArgs e)
        {
            if (txbLista.Text == "") {
                txbLista.ForeColor = Color.Gray;
                txbLista.Text = "1,-2,3 ...";
            }
        }

        private void txbLista_Enter(object sender, EventArgs e)
        {
            if (txbLista.Text == "1,-2,3 ...")
            {
                txbLista.ForeColor = Color.Black;
                txbLista.Text = "";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!Validation()) {
                txbOutputNeg.ForeColor = Color.Red;
                txbOutputPos.ForeColor = Color.Red;
                txbOutputNeg.Text = "Lista inválida";
                txbOutputPos.Text = "Lista inválida";
                txbLista.Text = "";
                return;
            }
            foreach (var item in txbLista.Text.Split(','))
            {
                Lista.Add(int.Parse(item));
                if (int.Parse(item) > 0)
                {
                    SomPos += int.Parse(item);
                }
                else if (int.Parse(item) < 0)
                {
                    SomNeg += int.Parse(item);
                }
            }
            txbOutputNeg.ForeColor = Color.Black;
            txbOutputPos.ForeColor = Color.Black;
            txbOutputNeg.Text = $"{SomNeg}";
            txbOutputPos.Text = $"{SomPos}";
        }

        public FrmQuestao1()
        {
            InitializeComponent();
        }
        private bool Validation() {
            foreach (var item in txbLista.Text.Split(',')) {
                if (!int.TryParse(item.ToString(), out _)) {
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
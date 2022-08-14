namespace List
{
    public partial class FrmQuestao1 : Form
    {
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
    }
}
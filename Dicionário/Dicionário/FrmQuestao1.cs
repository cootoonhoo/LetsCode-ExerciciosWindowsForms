using System.Threading;
namespace Dicionário
{
    public partial class Form1 : Form
    {
        Thread T1;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularVogais(txbFrase.Text);
            txbFrase.Text = "";
            
        }

        private void CalcularVogais(string text) {
            text = text.ToUpper();

            text = text.Normalize(System.Text.NormalizationForm.FormD);

            Dictionary<string, int> Vogais = new Dictionary<string, int>();
            Vogais.Add("A", 0);
            Vogais.Add("E", 0);
            Vogais.Add("I", 0);
            Vogais.Add("O", 0);
            Vogais.Add("U", 0);

            foreach (var letra in text) {
                switch (letra) {
                    case 'A':
                        Vogais["A"]++; 
                        break;
                    case 'E':
                        Vogais["E"]++;
                        break;
                    case 'I':
                        Vogais["I"]++;
                        break;
                    case 'O':
                        Vogais["O"]++;
                        break;
                    case 'U':
                        Vogais["U"]++;
                        break;
                    default:
                        continue;
                }
            }
            txbA.Text = Vogais["A"].ToString();
            txbE.Text = Vogais["E"].ToString();
            txbI.Text = Vogais["I"].ToString();
            txbO.Text = Vogais["O"].ToString();
            txbU.Text = Vogais["U"].ToString();
            Vogais.Clear();
        }
        private void questao1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            T1 = new Thread(form1);
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
        private void form1(object obj)
        {
            Application.Run(new Form1());
        }
        private void Form2(object obj)
        {
            Application.Run(new FrmQuestao2());
        }
    }
}
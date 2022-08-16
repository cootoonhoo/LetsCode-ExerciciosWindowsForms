namespace Dicionário
{
    public partial class Form1 : Form
    {

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
    }
}
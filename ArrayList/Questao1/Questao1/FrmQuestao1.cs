using System.Collections;

namespace Questao1
{
    public partial class FrmQuestao1 : Form
    {
        ArrayList Lista = new ArrayList();
        int numero = 0;
        public FrmQuestao1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = 0;
            txbNumero.ForeColor = Color.Black;
            txbOutput.Text = " ";
            List<int> Posicoes = new List<int>();
            Lista.Clear();
            foreach (var item in txbArrayList.Text.Split('\r'))
            {
                Lista.Add(item);
            }
            if (!int.TryParse(txbNumero.Text, out _))
            {
                txbNumero.ForeColor = Color.Red;
                txbNumero.Text = "Número inválido";
                return;
            }
            Posicoes = PosicoesArrayList(Lista, int.Parse(txbNumero.Text));
            if (Posicoes.Count == 0) {
                txbOutput.Text = "Não foi encontrado nenhuma posição";
                return;
            }
            foreach (var item in Posicoes)
            {
                txbOutput.Text += item + " ";
            }
            Posicoes.Clear();
        }
        private List<int> PosicoesArrayList(ArrayList arr, int numero)
        {
            int i = 0;
            List<int> Posicoes = new List<int>();
            foreach (var item in arr)
            {
                if (int.TryParse(item.ToString(), out int aux) && aux == numero)
                    Posicoes.Add(i);
                i++;
            }
            return Posicoes;
        }

        private void txbNumero_Enter(object sender, EventArgs e)
        {
            if (txbNumero.Text == "Número inválido") {
                txbNumero.Text = "";
                txbNumero.ForeColor = Color.Black;
            }
        }
    }
}

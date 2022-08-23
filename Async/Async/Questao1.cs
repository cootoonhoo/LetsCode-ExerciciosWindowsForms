using System.Diagnostics;

namespace Async
{
    public partial class Questao1 : Form
    {
        public Questao1()
        {
            InitializeComponent();
        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            decimal Salarios, Imposto, Receita, Despesa;

            var task1 = FolhaDePagamento();
            var task2 = Impostos();
            var task3 = Receitas();
            var task4 = Despesas();

            lblLoading.Visible = true;
            lblLoading.ForeColor = Color.Red;
            lblLoading.Text = "Calculando os dados... Aguarde";

            Salarios = await task1;
            Imposto = await task2;
            Receita = await task3;
            Despesa = await task4;

            lblLoading.ForeColor = Color.Green;
            lblLoading.Text = "Dados calculados! :)";
            txbCalculos.Text = @$"Valores da folha de pagamento: 
R${Salarios:F2}
Valores dos impostos: 
R${Imposto:F2}
Receita arrecadada: 
R${Receita:F2}
Despesas totais: 
R${Despesa:F2}";

            sw.Stop();
            txbTempoGasto.Text = $"{(sw.ElapsedMilliseconds/1000F).ToString("f2")}";
        }
        private async Task<decimal> FolhaDePagamento() {
            await Task.Delay(5000);
            return 12345.86M;
        }
        private async Task<decimal> Impostos()
        {
            await Task.Delay(3000);
            return 25385.72M;
        }
        private async Task<decimal> Receitas()
        {
            await Task.Delay(2300);
            return 50231.24M;
        }
        private async Task<decimal> Despesas()
        {
            await Task.Delay(2300);
            return 35231.24M;
        }
    }
}
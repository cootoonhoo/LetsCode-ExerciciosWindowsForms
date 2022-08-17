using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace Dicionário
{
    public partial class FrmQuestao2 : Form
    {
        Thread T1;
        Dictionary<string, string> Traducao = new Dictionary<string, string>();
        int CountIf = 0 , CountWhile = 0 , CountMaior = 0 , CountMenor = 0,
        CountMaiorIgual = 0 , CountMenorIgual = 0 , CountIgual = 0 , CountDif = 0;

        private void FrmQuestao2_Load(object sender, EventArgs e)
        {
            AdicionarTraducao();
        }

        public FrmQuestao2()
        {
            InitializeComponent();
        }

        private void txbInput_Click(object sender, EventArgs e)
        {
            if (txbInput.Text == "if x > y")
            {
                txbInput.ForeColor = Color.Black;
                txbInput.Text = "";
            }
        }

        private void txbInput_Leave(object sender, EventArgs e)
        {
            if (txbInput.Text == "") {
                txbInput.ForeColor = Color.LightGray;
                txbInput.Text = "if x > y";
            }
        }
        private void btnTraduzir_Click(object sender, EventArgs e)
        {
            ContarOperadores(txbInput.Text);
            if (!Verificacoes()) {
                txbOutput.ForeColor = Color.Red;
                txbInput.Text = "";
                txbOutput.Text = "Expressão com erro lógico";
                return;
            }
            txbOutput.ForeColor = Color.Black;
            txbOutput.Text = TraduzirExpressao(txbInput.Text);

        }
        private void ContarOperadores(string text) {
            CountIf = 0;
            CountWhile = 0;
            CountMaior = 0;
            CountMenor = 0;
            CountMaiorIgual = 0;
            CountMenorIgual = 0;
            CountIgual = 0;
            CountDif = 0;
            text = text.ToLower();
            CountIf = text.Split("if").Count();
            CountWhile = text.Split("while").Count();
            CountMaior = text.Split(">").Count();
            CountMenor = text.Split("<").Count();
            CountMaiorIgual = text.Split(">=").Count();
            CountMenorIgual = text.Split("<=").Count();
            CountIgual = text.Split("==").Count();
            CountDif = text.Split("!=").Count();
        }
        private void AdicionarTraducao() {
            Traducao.Add("if","se");
            Traducao.Add("while", "enquanto");
            Traducao.Add(">", "maior que");
            Traducao.Add("<", "menor que");
            Traducao.Add(">=", "maior ou igual que");
            Traducao.Add("<=", "igual a");
            Traducao.Add("!=", "diferente de");
        }
        private bool Verificacoes() {
            int CountLacos = CountIf + CountWhile;
            int CountMaiorMenor = CountMaior + CountMenor;
            int CountMaiorMenorIgual = CountMaiorIgual + CountMenorIgual;
            int CountIgualDiferente = CountIgual + CountDif;

            if (CountLacos > 3) return false;
            if (CountMaiorMenor > 3) return false;
            if (CountMaiorMenorIgual > 3) return false;
            if (CountIgualDiferente > 3) return false;

            return true;        
        }
        private string TraduzirExpressao(string text){
            string traducao = "";
            string[] strings = text.Split(' ');

            foreach (var frase in strings) {
                switch (frase)
                {
                    case "if":
                        traducao += Traducao["if"] + " ";
                        break;
                    case "while":
                        traducao += Traducao["while"] + " ";
                        break;
                    case ">":
                        traducao += Traducao[">"] + " ";
                        break;
                    case "<":
                        traducao += Traducao["<"] + " ";
                        break;
                    case ">=":
                        traducao += Traducao[">="] + " ";
                        break;
                    case "<=":
                        traducao += Traducao["<="] + " ";
                        break;
                    case "==":
                        traducao += Traducao["=="] + " ";
                        break;
                    case "!=":
                        traducao += Traducao["!="] + " ";
                        break;
                    default:
                        traducao += frase + " ";
                        break;
                }
            }
            return traducao;
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoras
{
    public partial class FmrCalculadora : Form
    {
        bool IgualPrecionado = false;
        bool PrimeiraMultiDiv = true;
        string ValorDisplay = "0";
        string LastAction = "";
        double ValorReal = 0;
        double ValorMemoria = 0;
        public FmrCalculadora()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            IgualPrecionado = false;
            ValorDisplay = "0";
            LastAction = "";
            ValorReal = 0;
            ValorMemoria = 0;
            txbVisor.Text = ValorDisplay;
            PrimeiraMultiDiv = true;
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (LastAction)
            {
                case "Soma":
                    ValorMemoria += ValorReal;
                    ValorDisplay = ValorMemoria.ToString();
                    txbVisor.Text = ValorDisplay;
                    break;
                case "Subtracao":
                    ValorMemoria -= ValorReal;
                    ValorDisplay = ValorMemoria.ToString();
                    txbVisor.Text = ValorDisplay;
                    break;
                case "Multiplicacao":
                    ValorMemoria *= ValorReal;
                    ValorDisplay = ValorMemoria.ToString();
                    txbVisor.Text = ValorDisplay;
                    break;
                case "Divisao":
                    ValorMemoria /= ValorReal;
                    ValorDisplay = ValorMemoria.ToString();
                    txbVisor.Text = ValorDisplay;
                    break;
            }
            // Usar o switch com lambda
            // Ver o caso negativo 1-1 = -2 (corrigir)
            ValorReal = 0;
            IgualPrecionado = true;
        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (PrimeiraMultiDiv)
            {
                ValorMemoria = 1;
                PrimeiraMultiDiv = false;
            }
            if (IgualPrecionado)
            {
                IgualPrecionado = false;
                LastAction = "Divisao";
                return;
            }
            ValorMemoria /= ValorReal;
            ValorReal = 0;
            ValorDisplay = ValorMemoria.ToString();
            txbVisor.Text = ValorDisplay;
            LastAction = "Divisao";
        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (PrimeiraMultiDiv) {
                ValorMemoria = 1;
                PrimeiraMultiDiv = false;
            }
            if (IgualPrecionado)
            {
                IgualPrecionado = false;
                LastAction = "Multiplicacao";
                return;
            }
            ValorMemoria *= ValorReal;
            ValorReal = 0;
            ValorDisplay = ValorMemoria.ToString();
            txbVisor.Text = ValorDisplay;
            LastAction = "Multiplicacao";
        }
        private void btnMais_Click(object sender, EventArgs e)
        {
            if (IgualPrecionado) {
                IgualPrecionado = false;
                LastAction = "Soma";
                return;
            }
            ValorMemoria += ValorReal;
            ValorReal = 0;
            ValorDisplay = ValorMemoria.ToString();
            txbVisor.Text = ValorDisplay;
            LastAction = "Soma";
        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (IgualPrecionado)
            {
                IgualPrecionado = false;
                LastAction = "Subtracao";
                return;
            }
            ValorMemoria -= ValorReal;
            ValorReal = 0;
            ValorDisplay = ValorMemoria.ToString();
            txbVisor.Text = ValorDisplay;
            LastAction = "Subtracao";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            AdicionarNumero(0);
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            AdicionarNumero(1);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            AdicionarNumero(2);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            AdicionarNumero(3);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            AdicionarNumero(4);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            AdicionarNumero(5);
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            AdicionarNumero(6);
        }
        private void bnt7_Click(object sender, EventArgs e)
        {
            AdicionarNumero(7);
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            AdicionarNumero(8);
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            AdicionarNumero(9);
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            txbVisor.Text = ValorDisplay;
        }
        private void AdicionarNumero(double digito)
        {
            if (ValorReal.ToString().Length == 12 || txbVisor.Text == "Erro") {
                return;
            }
            if (ValorReal == 0)
            {
                ValorDisplay = $"{digito}";
                ValorReal = digito;
            }
            else
            {
                ValorDisplay += digito.ToString();
                ValorReal = double.Parse(ValorDisplay);
            }
            txbVisor.Text = ValorDisplay;
        }

    }
}

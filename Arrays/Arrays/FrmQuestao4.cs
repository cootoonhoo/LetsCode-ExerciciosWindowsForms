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

namespace Arrays
{
    public partial class FrmQuestao4 : Form
    {
        Thread T1;
        string Turn = "O";
        char[,] Tabuleiro = new char[3, 3];
        bool game = false;
        public FrmQuestao4()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "" && game == false)
            {
                Tabuleiro[0, 0] = Turn[0];
                btn1.Text = Turn;
                ChangeTurn();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "" && game == false)
            {
                Tabuleiro[0, 1] = Turn[0];
                btn2.Text = Turn;
                ChangeTurn();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "" && game == false)
            {
                Tabuleiro[0, 2] = Turn[0];
                btn3.Text = Turn;
                ChangeTurn();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "" && game == false)
            {
                Tabuleiro[1, 0] = Turn[0];
                btn4.Text = Turn;
                ChangeTurn();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text == "" && game == false)
            {
                Tabuleiro[1, 1] = Turn[0];
                btn5.Text = Turn;
                ChangeTurn();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "" && game == false)
            {
                Tabuleiro[1, 2] = Turn[0];
                btn6.Text = Turn;
                ChangeTurn();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text == "" && game == false)
            {
                Tabuleiro[2, 0] = Turn[0];
                btn7.Text = Turn;
                ChangeTurn();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text == "" && game == false)
            {
                Tabuleiro[2,1] = Turn[0];
                btn8.Text = Turn;
                ChangeTurn();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text == "" && game == false)
            {
                Tabuleiro[2,2] = Turn[0];
                btn9.Text = Turn;
                ChangeTurn();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
            T1 = new Thread(ReinicarJogo);
            T1.SetApartmentState(ApartmentState.STA);
            T1.Start();
        }
        private void ChangeTurn()
        {
            game = ValidateGame();
            if (game)
            {
                WinGame();
                return;
            }

            if (Turn == "O") Turn = "X";
            else Turn = "O";
            lblTurno.Text = $"Vez de {"'" + Turn + "'"}";
        }
        void ReinicarJogo(object obj)
        {
            Application.Run(new FrmQuestao4());
        }
        private bool ValidateGame()
        {
            bool teste = false;
            char Value;
            for (int i = 0; i < 3; i++) {
                Value = Tabuleiro[i, 0];
                if (Tabuleiro[i,1] == Value && Tabuleiro[i, 2] == Value && (Value == 'O' || Value =='X')) return true;
            }
            for (int i = 0; i < 3; i++)
            {
                Value = Tabuleiro[0,i];
                if (Tabuleiro[1,i] == Value && Tabuleiro[2,i] == Value && (Value == 'O' || Value == 'X')) return true;
            }
            Value = Tabuleiro[0, 0];
            if (Value == Tabuleiro[1,1] && Value == Tabuleiro[2, 2] && (Value == 'O' || Value == 'X')) return true;
            Value = Tabuleiro[2, 0];
            if (Value == Tabuleiro[1, 1] && Value == Tabuleiro[0, 2] && (Value == 'O' || Value == 'X')) return true;

            return teste;
        }

        private void WinGame() {
            lblTurno.Text = "Parabéns!!";
            lblTitulo.Text = "Vitória do jogador " + Turn;
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

        private void questao4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            T1 = new Thread(Form4);
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
        private void Form4(object obj)
        {
            Application.Run(new FrmQuestao4());
        }
    }
}

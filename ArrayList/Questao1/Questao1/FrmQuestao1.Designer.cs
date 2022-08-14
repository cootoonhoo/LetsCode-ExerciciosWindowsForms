namespace Questao1
{
    partial class FrmQuestao1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLista = new System.Windows.Forms.Label();
            this.lblInteiro = new System.Windows.Forms.Label();
            this.lblPosicoes = new System.Windows.Forms.Label();
            this.txbArrayList = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLista.Location = new System.Drawing.Point(12, 22);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(118, 21);
            this.lblLista.TabIndex = 0;
            this.lblLista.Text = "Digite uma lista";
            // 
            // lblInteiro
            // 
            this.lblInteiro.AutoSize = true;
            this.lblInteiro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInteiro.Location = new System.Drawing.Point(12, 123);
            this.lblInteiro.Name = "lblInteiro";
            this.lblInteiro.Size = new System.Drawing.Size(137, 21);
            this.lblInteiro.TabIndex = 1;
            this.lblInteiro.Text = "Digite um numero";
            // 
            // lblPosicoes
            // 
            this.lblPosicoes.AutoSize = true;
            this.lblPosicoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPosicoes.Location = new System.Drawing.Point(12, 173);
            this.lblPosicoes.Name = "lblPosicoes";
            this.lblPosicoes.Size = new System.Drawing.Size(279, 21);
            this.lblPosicoes.TabIndex = 2;
            this.lblPosicoes.Text = "Posições em que esse número aparece:";
            // 
            // txbArrayList
            // 
            this.txbArrayList.Location = new System.Drawing.Point(12, 46);
            this.txbArrayList.Multiline = true;
            this.txbArrayList.Name = "txbArrayList";
            this.txbArrayList.Size = new System.Drawing.Size(279, 74);
            this.txbArrayList.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(200, 277);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 43);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txbOutput
            // 
            this.txbOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbOutput.Location = new System.Drawing.Point(12, 197);
            this.txbOutput.Multiline = true;
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.ReadOnly = true;
            this.txbOutput.Size = new System.Drawing.Size(279, 74);
            this.txbOutput.TabIndex = 5;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(12, 147);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(279, 23);
            this.txbNumero.TabIndex = 6;
            // 
            // FrmQuestao1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 332);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.txbOutput);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbArrayList);
            this.Controls.Add(this.lblPosicoes);
            this.Controls.Add(this.lblInteiro);
            this.Controls.Add(this.lblLista);
            this.Name = "FrmQuestao1";
            this.Text = "Questão 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLista;
        private Label lblInteiro;
        private Label lblPosicoes;
        private TextBox txbArrayList;
        private Button btnCalcular;
        private TextBox txbOutput;
        private TextBox txbNumero;
    }
}
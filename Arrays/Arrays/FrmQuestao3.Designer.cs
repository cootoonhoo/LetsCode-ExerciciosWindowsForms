namespace Arrays
{
    partial class FrmQuestao3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumLinhas = new System.Windows.Forms.Label();
            this.lblNumColunas = new System.Windows.Forms.Label();
            this.txbInputLinha = new System.Windows.Forms.TextBox();
            this.txbInputColuna = new System.Windows.Forms.TextBox();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.questão1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questão2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questão3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questão4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumLinhas
            // 
            this.lblNumLinhas.AutoSize = true;
            this.lblNumLinhas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumLinhas.Location = new System.Drawing.Point(57, 45);
            this.lblNumLinhas.Name = "lblNumLinhas";
            this.lblNumLinhas.Size = new System.Drawing.Size(189, 21);
            this.lblNumLinhas.TabIndex = 0;
            this.lblNumLinhas.Text = "Digite o numero de linhas";
            // 
            // lblNumColunas
            // 
            this.lblNumColunas.AutoSize = true;
            this.lblNumColunas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumColunas.Location = new System.Drawing.Point(57, 109);
            this.lblNumColunas.Name = "lblNumColunas";
            this.lblNumColunas.Size = new System.Drawing.Size(204, 21);
            this.lblNumColunas.TabIndex = 1;
            this.lblNumColunas.Text = "Digite o numero de Colunas";
            // 
            // txbInputLinha
            // 
            this.txbInputLinha.Location = new System.Drawing.Point(57, 69);
            this.txbInputLinha.Name = "txbInputLinha";
            this.txbInputLinha.Size = new System.Drawing.Size(189, 23);
            this.txbInputLinha.TabIndex = 2;
            // 
            // txbInputColuna
            // 
            this.txbInputColuna.Location = new System.Drawing.Point(57, 133);
            this.txbInputColuna.Name = "txbInputColuna";
            this.txbInputColuna.Size = new System.Drawing.Size(189, 23);
            this.txbInputColuna.TabIndex = 3;
            // 
            // txbOutput
            // 
            this.txbOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbOutput.Location = new System.Drawing.Point(57, 212);
            this.txbOutput.Multiline = true;
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.ReadOnly = true;
            this.txbOutput.Size = new System.Drawing.Size(189, 89);
            this.txbOutput.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(57, 188);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(79, 21);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(105, 307);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(89, 45);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questão1ToolStripMenuItem,
            this.questão2ToolStripMenuItem,
            this.questão3ToolStripMenuItem,
            this.questão4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // questão1ToolStripMenuItem
            // 
            this.questão1ToolStripMenuItem.Name = "questão1ToolStripMenuItem";
            this.questão1ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.questão1ToolStripMenuItem.Text = "Questão 1";
            this.questão1ToolStripMenuItem.Click += new System.EventHandler(this.questao1ToolStripMenuItem_Click);
            // 
            // questão2ToolStripMenuItem
            // 
            this.questão2ToolStripMenuItem.Name = "questão2ToolStripMenuItem";
            this.questão2ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.questão2ToolStripMenuItem.Text = "Questão 2";
            this.questão2ToolStripMenuItem.Click += new System.EventHandler(this.questao2ToolStripMenuItem_Click);
            // 
            // questão3ToolStripMenuItem
            // 
            this.questão3ToolStripMenuItem.Name = "questão3ToolStripMenuItem";
            this.questão3ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.questão3ToolStripMenuItem.Text = "Questão 3";
            this.questão3ToolStripMenuItem.Click += new System.EventHandler(this.questao3ToolStripMenuItem_Click);
            // 
            // questão4ToolStripMenuItem
            // 
            this.questão4ToolStripMenuItem.Name = "questão4ToolStripMenuItem";
            this.questão4ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.questão4ToolStripMenuItem.Text = "Questão 4";
            this.questão4ToolStripMenuItem.Click += new System.EventHandler(this.questao4ToolStripMenuItem_Click);
            // 
            // FrmQuestao3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 365);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txbOutput);
            this.Controls.Add(this.txbInputColuna);
            this.Controls.Add(this.txbInputLinha);
            this.Controls.Add(this.lblNumColunas);
            this.Controls.Add(this.lblNumLinhas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmQuestao3";
            this.Text = "Questão 3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumLinhas;
        private Label lblNumColunas;
        private TextBox txbInputLinha;
        private TextBox txbInputColuna;
        private TextBox txbOutput;
        private Label lblResultado;
        private Button btnCalcular;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem questão1ToolStripMenuItem;
        private ToolStripMenuItem questão2ToolStripMenuItem;
        private ToolStripMenuItem questão3ToolStripMenuItem;
        private ToolStripMenuItem questão4ToolStripMenuItem;
    }
}
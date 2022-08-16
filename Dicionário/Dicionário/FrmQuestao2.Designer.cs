namespace Dicionário
{
    partial class FrmQuestao2
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
            this.lblFrase = new System.Windows.Forms.Label();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.lblTraducao = new System.Windows.Forms.Label();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.btnTraduzir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.questão1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questão2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFrase.Location = new System.Drawing.Point(12, 30);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(294, 21);
            this.lblFrase.TabIndex = 0;
            this.lblFrase.Text = "Digite uma frase com operadores lógicos";
            // 
            // txbInput
            // 
            this.txbInput.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbInput.Location = new System.Drawing.Point(12, 54);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(332, 23);
            this.txbInput.TabIndex = 2;
            this.txbInput.Text = "if x > y";
            this.txbInput.Click += new System.EventHandler(this.txbInput_Click);
            this.txbInput.Leave += new System.EventHandler(this.txbInput_Leave);
            // 
            // lblTraducao
            // 
            this.lblTraducao.AutoSize = true;
            this.lblTraducao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTraducao.Location = new System.Drawing.Point(12, 80);
            this.lblTraducao.Name = "lblTraducao";
            this.lblTraducao.Size = new System.Drawing.Size(73, 21);
            this.lblTraducao.TabIndex = 2;
            this.lblTraducao.Text = "Tradução";
            // 
            // txbOutput
            // 
            this.txbOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbOutput.Location = new System.Drawing.Point(12, 104);
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.ReadOnly = true;
            this.txbOutput.Size = new System.Drawing.Size(332, 23);
            this.txbOutput.TabIndex = 3;
            // 
            // btnTraduzir
            // 
            this.btnTraduzir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTraduzir.Location = new System.Drawing.Point(262, 145);
            this.btnTraduzir.Name = "btnTraduzir";
            this.btnTraduzir.Size = new System.Drawing.Size(82, 34);
            this.btnTraduzir.TabIndex = 1;
            this.btnTraduzir.Text = "Traduzir";
            this.btnTraduzir.UseVisualStyleBackColor = true;
            this.btnTraduzir.Click += new System.EventHandler(this.btnTraduzir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questão1ToolStripMenuItem,
            this.questão2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(365, 24);
            this.menuStrip1.TabIndex = 4;
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
            // FrmQuestao2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 191);
            this.Controls.Add(this.btnTraduzir);
            this.Controls.Add(this.txbOutput);
            this.Controls.Add(this.lblTraducao);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.lblFrase);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmQuestao2";
            this.Text = "Questão 2";
            this.Load += new System.EventHandler(this.FrmQuestao2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFrase;
        private TextBox txbInput;
        private Label lblTraducao;
        private TextBox txbOutput;
        private Button btnTraduzir;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem questão1ToolStripMenuItem;
        private ToolStripMenuItem questão2ToolStripMenuItem;
    }
}
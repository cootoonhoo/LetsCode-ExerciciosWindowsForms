namespace Arrays
{
    partial class FrmQuestao1
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
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCrescente = new System.Windows.Forms.TextBox();
            this.txbPares = new System.Windows.Forms.TextBox();
            this.txbImpares = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.questao1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questao2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questao3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questao4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnunciado.Location = new System.Drawing.Point(12, 50);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(421, 21);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = "Digite uma sequência de 10 digitos inteiros maior que zero:";
            // 
            // txbInput
            // 
            this.txbInput.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbInput.Location = new System.Drawing.Point(12, 81);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(412, 23);
            this.txbInput.TabIndex = 2;
            this.txbInput.Text = "1,2,3,4...";
            this.txbInput.Click += new System.EventHandler(this.txbInput_Click);
            this.txbInput.TextChanged += new System.EventHandler(this.txbInput_TextChanged);
            this.txbInput.Leave += new System.EventHandler(this.txbInput_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sequência crescente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numeros pares:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numeros impares:";
            // 
            // txbCrescente
            // 
            this.txbCrescente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbCrescente.Location = new System.Drawing.Point(12, 165);
            this.txbCrescente.Name = "txbCrescente";
            this.txbCrescente.ReadOnly = true;
            this.txbCrescente.Size = new System.Drawing.Size(412, 23);
            this.txbCrescente.TabIndex = 5;
            // 
            // txbPares
            // 
            this.txbPares.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbPares.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbPares.Location = new System.Drawing.Point(12, 215);
            this.txbPares.Name = "txbPares";
            this.txbPares.ReadOnly = true;
            this.txbPares.Size = new System.Drawing.Size(412, 23);
            this.txbPares.TabIndex = 6;
            // 
            // txbImpares
            // 
            this.txbImpares.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbImpares.Location = new System.Drawing.Point(12, 265);
            this.txbImpares.Name = "txbImpares";
            this.txbImpares.ReadOnly = true;
            this.txbImpares.Size = new System.Drawing.Size(412, 23);
            this.txbImpares.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(333, 309);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(91, 41);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questao1ToolStripMenuItem,
            this.questao2ToolStripMenuItem,
            this.questao3ToolStripMenuItem,
            this.questao4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(443, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // questao1ToolStripMenuItem
            // 
            this.questao1ToolStripMenuItem.Name = "questao1ToolStripMenuItem";
            this.questao1ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.questao1ToolStripMenuItem.Text = "Questão 1";
            this.questao1ToolStripMenuItem.Click += new System.EventHandler(this.questao1ToolStripMenuItem_Click);
            // 
            // questao2ToolStripMenuItem
            // 
            this.questao2ToolStripMenuItem.Name = "questao2ToolStripMenuItem";
            this.questao2ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.questao2ToolStripMenuItem.Text = "Questão 2";
            this.questao2ToolStripMenuItem.Click += new System.EventHandler(this.questao2ToolStripMenuItem_Click);
            // 
            // questao3ToolStripMenuItem
            // 
            this.questao3ToolStripMenuItem.Name = "questao3ToolStripMenuItem";
            this.questao3ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.questao3ToolStripMenuItem.Text = "Questão 3";
            this.questao3ToolStripMenuItem.Click += new System.EventHandler(this.questao3ToolStripMenuItem_Click);
            // 
            // questao4ToolStripMenuItem
            // 
            this.questao4ToolStripMenuItem.Name = "questao4ToolStripMenuItem";
            this.questao4ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.questao4ToolStripMenuItem.Text = "Questão 4";
            this.questao4ToolStripMenuItem.Click += new System.EventHandler(this.questao4ToolStripMenuItem_Click);
            // 
            // FrmQuestao1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 366);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbImpares);
            this.Controls.Add(this.txbPares);
            this.Controls.Add(this.txbCrescente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmQuestao1";
            this.Text = "Questão 1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEnunciado;
        private TextBox txbInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbCrescente;
        private TextBox txbPares;
        private TextBox txbImpares;
        private Button btnCalcular;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem questao1ToolStripMenuItem;
        private ToolStripMenuItem questao2ToolStripMenuItem;
        private ToolStripMenuItem questao3ToolStripMenuItem;
        private ToolStripMenuItem questao4ToolStripMenuItem;
    }
}
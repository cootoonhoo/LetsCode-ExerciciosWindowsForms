namespace List
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.questão1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questão2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questão3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.txbLista = new System.Windows.Forms.TextBox();
            this.lblSomaPos = new System.Windows.Forms.Label();
            this.txbOutputPos = new System.Windows.Forms.TextBox();
            this.txbOutputNeg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questão1ToolStripMenuItem,
            this.questão2ToolStripMenuItem,
            this.questão3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(323, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // questão1ToolStripMenuItem
            // 
            this.questão1ToolStripMenuItem.Name = "questão1ToolStripMenuItem";
            this.questão1ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.questão1ToolStripMenuItem.Text = "Questão 1";
            // 
            // questão2ToolStripMenuItem
            // 
            this.questão2ToolStripMenuItem.Name = "questão2ToolStripMenuItem";
            this.questão2ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.questão2ToolStripMenuItem.Text = "Questão 2";
            // 
            // questão3ToolStripMenuItem
            // 
            this.questão3ToolStripMenuItem.Name = "questão3ToolStripMenuItem";
            this.questão3ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.questão3ToolStripMenuItem.Text = "Questão 3";
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnunciado.Location = new System.Drawing.Point(12, 34);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(261, 21);
            this.lblEnunciado.TabIndex = 1;
            this.lblEnunciado.Text = "Digite uma lista de numeros inteiros";
            // 
            // txbLista
            // 
            this.txbLista.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbLista.Location = new System.Drawing.Point(12, 58);
            this.txbLista.Name = "txbLista";
            this.txbLista.Size = new System.Drawing.Size(295, 23);
            this.txbLista.TabIndex = 4;
            this.txbLista.Text = "1,-2,3 ...";
            this.txbLista.Enter += new System.EventHandler(this.txbLista_Enter);
            this.txbLista.Leave += new System.EventHandler(this.txbLista_Leave);
            // 
            // lblSomaPos
            // 
            this.lblSomaPos.AutoSize = true;
            this.lblSomaPos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSomaPos.Location = new System.Drawing.Point(12, 84);
            this.lblSomaPos.Name = "lblSomaPos";
            this.lblSomaPos.Size = new System.Drawing.Size(145, 21);
            this.lblSomaPos.TabIndex = 3;
            this.lblSomaPos.Text = "Soma dos positivos";
            // 
            // txbOutputPos
            // 
            this.txbOutputPos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbOutputPos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txbOutputPos.Location = new System.Drawing.Point(12, 108);
            this.txbOutputPos.Name = "txbOutputPos";
            this.txbOutputPos.ReadOnly = true;
            this.txbOutputPos.Size = new System.Drawing.Size(295, 23);
            this.txbOutputPos.TabIndex = 3;
            // 
            // txbOutputNeg
            // 
            this.txbOutputNeg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbOutputNeg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txbOutputNeg.Location = new System.Drawing.Point(12, 158);
            this.txbOutputNeg.Name = "txbOutputNeg";
            this.txbOutputNeg.ReadOnly = true;
            this.txbOutputNeg.Size = new System.Drawing.Size(295, 23);
            this.txbOutputNeg.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soma dos negativos";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(232, 187);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FrmQuestao1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 219);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbOutputNeg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbOutputPos);
            this.Controls.Add(this.lblSomaPos);
            this.Controls.Add(this.txbLista);
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

        private MenuStrip menuStrip1;
        private ToolStripMenuItem questão1ToolStripMenuItem;
        private ToolStripMenuItem questão2ToolStripMenuItem;
        private ToolStripMenuItem questão3ToolStripMenuItem;
        private Label lblEnunciado;
        private TextBox txbLista;
        private Label lblSomaPos;
        private TextBox txbOutputPos;
        private TextBox txbOutputNeg;
        private Label label1;
        private Button btnCalcular;
    }
}
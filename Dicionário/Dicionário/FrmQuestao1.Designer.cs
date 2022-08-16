namespace Dicionário
{
    partial class Form1
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
            this.lblFrase = new System.Windows.Forms.Label();
            this.txbFrase = new System.Windows.Forms.TextBox();
            this.lblVogais = new System.Windows.Forms.Label();
            this.txbA = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbI = new System.Windows.Forms.TextBox();
            this.txbO = new System.Windows.Forms.TextBox();
            this.txbU = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFrase.Location = new System.Drawing.Point(12, 9);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(127, 21);
            this.lblFrase.TabIndex = 0;
            this.lblFrase.Text = "Digite uma frase:";
            // 
            // txbFrase
            // 
            this.txbFrase.Location = new System.Drawing.Point(12, 33);
            this.txbFrase.Name = "txbFrase";
            this.txbFrase.Size = new System.Drawing.Size(284, 23);
            this.txbFrase.TabIndex = 1;
            // 
            // lblVogais
            // 
            this.lblVogais.AutoSize = true;
            this.lblVogais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVogais.Location = new System.Drawing.Point(12, 59);
            this.lblVogais.Name = "lblVogais";
            this.lblVogais.Size = new System.Drawing.Size(156, 21);
            this.lblVogais.TabIndex = 2;
            this.lblVogais.Text = "Frequência de vogais";
            // 
            // txbA
            // 
            this.txbA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbA.Location = new System.Drawing.Point(47, 108);
            this.txbA.Name = "txbA";
            this.txbA.ReadOnly = true;
            this.txbA.Size = new System.Drawing.Size(24, 23);
            this.txbA.TabIndex = 8;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblA.Location = new System.Drawing.Point(28, 109);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(18, 19);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "I";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "E";
            // 
            // txbE
            // 
            this.txbE.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbE.Location = new System.Drawing.Point(47, 137);
            this.txbE.Name = "txbE";
            this.txbE.ReadOnly = true;
            this.txbE.Size = new System.Drawing.Size(24, 23);
            this.txbE.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(89, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "O";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(90, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "U";
            // 
            // txbI
            // 
            this.txbI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbI.Location = new System.Drawing.Point(47, 167);
            this.txbI.Name = "txbI";
            this.txbI.ReadOnly = true;
            this.txbI.Size = new System.Drawing.Size(24, 23);
            this.txbI.TabIndex = 10;
            // 
            // txbO
            // 
            this.txbO.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbO.Location = new System.Drawing.Point(115, 107);
            this.txbO.Name = "txbO";
            this.txbO.ReadOnly = true;
            this.txbO.Size = new System.Drawing.Size(24, 23);
            this.txbO.TabIndex = 11;
            // 
            // txbU
            // 
            this.txbU.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbU.Location = new System.Drawing.Point(115, 138);
            this.txbU.Name = "txbU";
            this.txbU.ReadOnly = true;
            this.txbU.Size = new System.Drawing.Size(24, 23);
            this.txbU.TabIndex = 12;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(205, 108);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 49);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 210);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbU);
            this.Controls.Add(this.txbO);
            this.Controls.Add(this.txbI);
            this.Controls.Add(this.txbE);
            this.Controls.Add(this.txbA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblVogais);
            this.Controls.Add(this.txbFrase);
            this.Controls.Add(this.lblFrase);
            this.Name = "Form1";
            this.Text = "Questão 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFrase;
        private TextBox txbFrase;
        private Label lblVogais;
        private TextBox txbA;
        private Label lblA;
        private Label label2;
        private Label label1;
        private TextBox txbE;
        private Label label3;
        private Label label4;
        private TextBox txbI;
        private TextBox txbO;
        private TextBox txbU;
        private Button btnCalcular;
    }
}
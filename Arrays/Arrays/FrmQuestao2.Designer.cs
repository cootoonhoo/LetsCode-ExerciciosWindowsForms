namespace Arrays
{
    partial class FrmQuestao2
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
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.txbObs = new System.Windows.Forms.Label();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.lblRanqueamento = new System.Windows.Forms.Label();
            this.btnRanquear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnunciado.Location = new System.Drawing.Point(42, 46);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(305, 21);
            this.lblEnunciado.TabIndex = 1;
            this.lblEnunciado.Text = "Digite uma sequência de numeros inteiros:";
            // 
            // txbObs
            // 
            this.txbObs.AutoSize = true;
            this.txbObs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txbObs.Location = new System.Drawing.Point(42, 67);
            this.txbObs.Name = "txbObs";
            this.txbObs.Size = new System.Drawing.Size(337, 13);
            this.txbObs.TabIndex = 2;
            this.txbObs.Text = "Caso haja uma quebra de linha, o progra irá tratar como uma matriz.";
            // 
            // txbInput
            // 
            this.txbInput.BackColor = System.Drawing.SystemColors.Window;
            this.txbInput.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbInput.Location = new System.Drawing.Point(42, 83);
            this.txbInput.Multiline = true;
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(337, 60);
            this.txbInput.TabIndex = 3;
            this.txbInput.Text = "1,2,3,4....\r\n10,24,5...";
            this.txbInput.Click += new System.EventHandler(this.txbInput_Click);
            this.txbInput.TextChanged += new System.EventHandler(this.txbInput_TextChanged);
            this.txbInput.Leave += new System.EventHandler(this.txbInput_Leave);
            // 
            // txbOutput
            // 
            this.txbOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbOutput.Location = new System.Drawing.Point(42, 224);
            this.txbOutput.Multiline = true;
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.ReadOnly = true;
            this.txbOutput.Size = new System.Drawing.Size(337, 66);
            this.txbOutput.TabIndex = 4;
            // 
            // lblRanqueamento
            // 
            this.lblRanqueamento.AutoSize = true;
            this.lblRanqueamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRanqueamento.Location = new System.Drawing.Point(42, 200);
            this.lblRanqueamento.Name = "lblRanqueamento";
            this.lblRanqueamento.Size = new System.Drawing.Size(210, 21);
            this.lblRanqueamento.TabIndex = 5;
            this.lblRanqueamento.Text = "Resultado do ranqueamento:";
            // 
            // btnRanquear
            // 
            this.btnRanquear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRanquear.Location = new System.Drawing.Point(282, 311);
            this.btnRanquear.Name = "btnRanquear";
            this.btnRanquear.Size = new System.Drawing.Size(97, 41);
            this.btnRanquear.TabIndex = 6;
            this.btnRanquear.Text = "Ranquear";
            this.btnRanquear.UseVisualStyleBackColor = true;
            this.btnRanquear.Click += new System.EventHandler(this.btnRanquear_Click);
            // 
            // FrmQuestao2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 376);
            this.Controls.Add(this.btnRanquear);
            this.Controls.Add(this.lblRanqueamento);
            this.Controls.Add(this.txbOutput);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.txbObs);
            this.Controls.Add(this.lblEnunciado);
            this.Name = "FrmQuestao2";
            this.Text = "Questão 2 ";
            this.Load += new System.EventHandler(this.FrmQuestao2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEnunciado;
        private Label txbObs;
        private TextBox txbInput;
        private TextBox txbOutput;
        private Label lblRanqueamento;
        private Button btnRanquear;
    }
}
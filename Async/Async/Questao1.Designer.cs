namespace Async
{
    partial class Questao1
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
            this.txbCalculos = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblTempoGasto = new System.Windows.Forms.Label();
            this.txbTempoGasto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnunciado.Location = new System.Drawing.Point(12, 9);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(92, 21);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = "Calculadora";
            // 
            // txbCalculos
            // 
            this.txbCalculos.Location = new System.Drawing.Point(12, 33);
            this.txbCalculos.Multiline = true;
            this.txbCalculos.Name = "txbCalculos";
            this.txbCalculos.ReadOnly = true;
            this.txbCalculos.Size = new System.Drawing.Size(214, 177);
            this.txbCalculos.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(12, 216);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(214, 52);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoading.Location = new System.Drawing.Point(13, 271);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(213, 19);
            this.lblLoading.TabIndex = 3;
            this.lblLoading.Text = "----------PlaceHolder------------";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoading.Visible = false;
            // 
            // lblTempoGasto
            // 
            this.lblTempoGasto.AutoSize = true;
            this.lblTempoGasto.Location = new System.Drawing.Point(46, 323);
            this.lblTempoGasto.Name = "lblTempoGasto";
            this.lblTempoGasto.Size = new System.Drawing.Size(104, 15);
            this.lblTempoGasto.TabIndex = 4;
            this.lblTempoGasto.Text = "Tempo gasto(seg):";
            // 
            // txbTempoGasto
            // 
            this.txbTempoGasto.Location = new System.Drawing.Point(156, 320);
            this.txbTempoGasto.Name = "txbTempoGasto";
            this.txbTempoGasto.Size = new System.Drawing.Size(78, 23);
            this.txbTempoGasto.TabIndex = 5;
            // 
            // Questao1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 354);
            this.Controls.Add(this.txbTempoGasto);
            this.Controls.Add(this.lblTempoGasto);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbCalculos);
            this.Controls.Add(this.lblEnunciado);
            this.Name = "Questao1";
            this.Text = "Questão 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEnunciado;
        private TextBox txbCalculos;
        private Button btnCalcular;
        private Label lblLoading;
        private Label lblTempoGasto;
        private TextBox txbTempoGasto;
    }
}
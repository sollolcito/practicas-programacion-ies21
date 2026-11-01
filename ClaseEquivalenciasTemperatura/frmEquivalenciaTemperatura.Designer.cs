namespace ClaseEquivalenciasTemperatura
{
    partial class frmEquivalenciaTemperatura
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblF = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblIngresarNumero = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.lblRankine = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(35, 76);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(193, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRankine);
            this.groupBox1.Controls.Add(this.lblKelvin);
            this.groupBox1.Controls.Add(this.lblFahrenheit);
            this.groupBox1.Controls.Add(this.lblR);
            this.groupBox1.Controls.Add(this.lblK);
            this.groupBox1.Controls.Add(this.lblF);
            this.groupBox1.Location = new System.Drawing.Point(25, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculo de Temperaturas";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(7, 30);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(57, 13);
            this.lblF.TabIndex = 0;
            this.lblF.Text = "Fahrenheit";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(6, 61);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(36, 13);
            this.lblK.TabIndex = 1;
            this.lblK.Text = "Kelvin";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(6, 98);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(47, 13);
            this.lblR.TabIndex = 2;
            this.lblR.Text = "Rankine";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(131, 36);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(103, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // lblIngresarNumero
            // 
            this.lblIngresarNumero.AutoSize = true;
            this.lblIngresarNumero.Location = new System.Drawing.Point(21, 39);
            this.lblIngresarNumero.Name = "lblIngresarNumero";
            this.lblIngresarNumero.Size = new System.Drawing.Size(95, 13);
            this.lblIngresarNumero.TabIndex = 3;
            this.lblIngresarNumero.Text = "Ingrese un número";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFahrenheit.Location = new System.Drawing.Point(84, 30);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(119, 13);
            this.lblFahrenheit.TabIndex = 3;
            this.lblFahrenheit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKelvin
            // 
            this.lblKelvin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKelvin.Location = new System.Drawing.Point(84, 61);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(119, 13);
            this.lblKelvin.TabIndex = 4;
            this.lblKelvin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRankine
            // 
            this.lblRankine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRankine.Location = new System.Drawing.Point(84, 98);
            this.lblRankine.Name = "lblRankine";
            this.lblRankine.Size = new System.Drawing.Size(119, 13);
            this.lblRankine.TabIndex = 5;
            this.lblRankine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmEquivalenciaTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 274);
            this.Controls.Add(this.lblIngresarNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frmEquivalenciaTemperatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculando Equivalencia de Tempreratura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblIngresarNumero;
        private System.Windows.Forms.Label lblRankine;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.Label lblFahrenheit;
    }
}


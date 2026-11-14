namespace SistemaGestionClientes
{
    partial class frmConsultaCliente
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gbxDatosCliente = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblLim = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.gbxDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(80, 22);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(230, 21);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(20, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(42, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Cliente:";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(225, 49);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(85, 25);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // gbxDatosCliente
            // 
            this.gbxDatosCliente.Controls.Add(this.lblLimite);
            this.gbxDatosCliente.Controls.Add(this.label2);
            this.gbxDatosCliente.Controls.Add(this.lblDeuda);
            this.gbxDatosCliente.Controls.Add(this.lblLim);
            this.gbxDatosCliente.Location = new System.Drawing.Point(20, 80);
            this.gbxDatosCliente.Name = "gbxDatosCliente";
            this.gbxDatosCliente.Size = new System.Drawing.Size(290, 125);
            this.gbxDatosCliente.TabIndex = 3;
            this.gbxDatosCliente.TabStop = false;
            this.gbxDatosCliente.Text = "Datos del cliente";
            this.gbxDatosCliente.Enter += new System.EventHandler(this.gbxDatosCliente_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deuda:";
            // 
            // lblDeuda
            // 
            this.lblDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeuda.Location = new System.Drawing.Point(84, 30);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(105, 20);
            this.lblDeuda.TabIndex = 3;
            // 
            // lblLim
            // 
            this.lblLim.AutoSize = true;
            this.lblLim.Location = new System.Drawing.Point(15, 63);
            this.lblLim.Name = "lblLim";
            this.lblLim.Size = new System.Drawing.Size(92, 13);
            this.lblLim.TabIndex = 4;
            this.lblLim.Text = "Límite de crédito: ";
            // 
            // lblLimite
            // 
            this.lblLimite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLimite.Location = new System.Drawing.Point(127, 62);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(105, 20);
            this.lblLimite.TabIndex = 5;
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 239);
            this.Controls.Add(this.gbxDatosCliente);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lbl1);
            this.Name = "frmConsultaCliente";
            this.Text = "Consulta de clientes";
            this.Load += new System.EventHandler(this.frmConsultaCliente_Load_1);
            this.gbxDatosCliente.ResumeLayout(false);
            this.gbxDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox gbxDatosCliente;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLim;
        private System.Windows.Forms.Label lblLimite;
    }
}
namespace SistemaGestionClientes
{
    partial class frmListadoClientesDeudores
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
            this.gbxConsultaDatos = new System.Windows.Forms.GroupBox();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblPD = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblTD = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxConsultaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxConsultaDatos
            // 
            this.gbxConsultaDatos.Controls.Add(this.lblPromedioDeuda);
            this.gbxConsultaDatos.Controls.Add(this.lblTotalClientes);
            this.gbxConsultaDatos.Controls.Add(this.btnListar);
            this.gbxConsultaDatos.Controls.Add(this.lblTotalDeuda);
            this.gbxConsultaDatos.Controls.Add(this.lblPD);
            this.gbxConsultaDatos.Controls.Add(this.lblTC);
            this.gbxConsultaDatos.Controls.Add(this.lblTD);
            this.gbxConsultaDatos.Controls.Add(this.dgvClientes);
            this.gbxConsultaDatos.Location = new System.Drawing.Point(12, 12);
            this.gbxConsultaDatos.Name = "gbxConsultaDatos";
            this.gbxConsultaDatos.Size = new System.Drawing.Size(451, 335);
            this.gbxConsultaDatos.TabIndex = 1;
            this.gbxConsultaDatos.TabStop = false;
            this.gbxConsultaDatos.Text = "Consulta de Datos";
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(342, 274);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(92, 13);
            this.lblPromedioDeuda.TabIndex = 9;
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalClientes.Location = new System.Drawing.Point(342, 242);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(92, 13);
            this.lblTotalClientes.TabIndex = 8;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(359, 306);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuda.Location = new System.Drawing.Point(342, 214);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(92, 13);
            this.lblTotalDeuda.TabIndex = 4;
            // 
            // lblPD
            // 
            this.lblPD.AutoSize = true;
            this.lblPD.Location = new System.Drawing.Point(234, 274);
            this.lblPD.Name = "lblPD";
            this.lblPD.Size = new System.Drawing.Size(102, 13);
            this.lblPD.TabIndex = 3;
            this.lblPD.Text = "Promedio de deuda:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(234, 242);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(88, 13);
            this.lblTC.TabIndex = 2;
            this.lblTC.Text = "Total de clientes:";
            // 
            // lblTD
            // 
            this.lblTD.AutoSize = true;
            this.lblTD.Location = new System.Drawing.Point(234, 215);
            this.lblTD.Name = "lblTD";
            this.lblTD.Size = new System.Drawing.Size(82, 13);
            this.lblTD.TabIndex = 1;
            this.lblTD.Text = "Total de deuda:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colLimite,
            this.colDeuda});
            this.dgvClientes.Location = new System.Drawing.Point(20, 19);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(414, 188);
            this.dgvClientes.TabIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre y Apellido";
            this.colNombre.Name = "colNombre";
            // 
            // colLimite
            // 
            this.colLimite.HeaderText = "Límite de Crédito";
            this.colLimite.Name = "colLimite";
            // 
            // colDeuda
            // 
            this.colDeuda.HeaderText = "Deuda";
            this.colDeuda.Name = "colDeuda";
            // 
            // frmListadoClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxConsultaDatos);
            this.Name = "frmListadoClientesDeudores";
            this.Text = "Listado de Clientes Deudores";
            this.gbxConsultaDatos.ResumeLayout(false);
            this.gbxConsultaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxConsultaDatos;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblPD;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblTD;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
    }
}
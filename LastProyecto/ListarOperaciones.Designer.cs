namespace LastProyecto
{
    partial class ListarOperaciones
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.dgvOperaciones = new System.Windows.Forms.DataGridView();
            this.CUITCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(189, 12);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(286, 425);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // dgvOperaciones
            // 
            this.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUITCliente,
            this.CodigoProducto,
            this.MedioPago,
            this.CantProd});
            this.dgvOperaciones.Location = new System.Drawing.Point(501, 12);
            this.dgvOperaciones.Name = "dgvOperaciones";
            this.dgvOperaciones.RowHeadersWidth = 51;
            this.dgvOperaciones.RowTemplate.Height = 24;
            this.dgvOperaciones.Size = new System.Drawing.Size(537, 425);
            this.dgvOperaciones.TabIndex = 1;
            // 
            // CUITCliente
            // 
            this.CUITCliente.HeaderText = "CUIT Cliente";
            this.CUITCliente.MinimumWidth = 6;
            this.CUITCliente.Name = "CUITCliente";
            this.CUITCliente.Width = 125;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Código Producto";
            this.CodigoProducto.MinimumWidth = 6;
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Width = 125;
            // 
            // MedioPago
            // 
            this.MedioPago.HeaderText = "Medio de Pago";
            this.MedioPago.MinimumWidth = 6;
            this.MedioPago.Name = "MedioPago";
            this.MedioPago.Width = 125;
            // 
            // CantProd
            // 
            this.CantProd.HeaderText = "Cantidad de Productos";
            this.CantProd.MinimumWidth = 6;
            this.CantProd.Name = "CantProd";
            this.CantProd.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 110);
            this.button1.TabIndex = 2;
            this.button1.Text = "Listar Operaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 110);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cambiar DGV";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListarOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 443);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvOperaciones);
            this.Controls.Add(this.dgvDatos);
            this.Name = "ListarOperaciones";
            this.Text = "ListarOperaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridView dgvOperaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUITCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantProd;
        private System.Windows.Forms.Button button2;
    }
}
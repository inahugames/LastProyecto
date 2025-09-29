namespace LastProyecto
{
    partial class FormLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLista));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razón = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOperacion = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUITCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            resources.ApplyResources(this.dgvClientes, "dgvClientes");
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUIT,
            this.Razón});
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowTemplate.Height = 24;
            // 
            // CUIT
            // 
            resources.ApplyResources(this.CUIT, "CUIT");
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            // 
            // Razón
            // 
            resources.ApplyResources(this.Razón, "Razón");
            this.Razón.Name = "Razón";
            this.Razón.ReadOnly = true;
            // 
            // dgvProductos
            // 
            resources.ApplyResources(this.dgvProductos, "dgvProductos");
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripción,
            this.Costo,
            this.Precio,
            this.Existencia});
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowTemplate.Height = 24;
            // 
            // Codigo
            // 
            resources.ApplyResources(this.Codigo, "Codigo");
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripción
            // 
            resources.ApplyResources(this.Descripción, "Descripción");
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            // 
            // Costo
            // 
            resources.ApplyResources(this.Costo, "Costo");
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // Precio
            // 
            resources.ApplyResources(this.Precio, "Precio");
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Existencia
            // 
            resources.ApplyResources(this.Existencia, "Existencia");
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            // 
            // dgvOperacion
            // 
            resources.ApplyResources(this.dgvOperacion, "dgvOperacion");
            this.dgvOperacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Fecha,
            this.CUITCliente,
            this.RazonCliente,
            this.MedioPago,
            this.Habilitada});
            this.dgvOperacion.Name = "dgvOperacion";
            this.dgvOperacion.ReadOnly = true;
            this.dgvOperacion.RowTemplate.Height = 24;
            this.dgvOperacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOperacion_CellContentClick);
            // 
            // Num
            // 
            resources.ApplyResources(this.Num, "Num");
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // Fecha
            // 
            resources.ApplyResources(this.Fecha, "Fecha");
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // CUITCliente
            // 
            resources.ApplyResources(this.CUITCliente, "CUITCliente");
            this.CUITCliente.Name = "CUITCliente";
            this.CUITCliente.ReadOnly = true;
            // 
            // RazonCliente
            // 
            resources.ApplyResources(this.RazonCliente, "RazonCliente");
            this.RazonCliente.Name = "RazonCliente";
            this.RazonCliente.ReadOnly = true;
            // 
            // MedioPago
            // 
            resources.ApplyResources(this.MedioPago, "MedioPago");
            this.MedioPago.Name = "MedioPago";
            this.MedioPago.ReadOnly = true;
            // 
            // Habilitada
            // 
            resources.ApplyResources(this.Habilitada, "Habilitada");
            this.Habilitada.Name = "Habilitada";
            this.Habilitada.ReadOnly = true;
            // 
            // FormLista
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvOperacion);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.dgvClientes);
            this.Name = "FormLista";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razón;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUITCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habilitada;
    }
}
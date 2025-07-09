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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarOperaciones));
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOperaciones = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUITCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            resources.ApplyResources(this.dgvCliente, "dgvCliente");
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUIT,
            this.Razon});
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // CUIT
            // 
            resources.ApplyResources(this.CUIT, "CUIT");
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            // 
            // Razon
            // 
            resources.ApplyResources(this.Razon, "Razon");
            this.Razon.Name = "Razon";
            this.Razon.ReadOnly = true;
            // 
            // dgvOperaciones
            // 
            resources.ApplyResources(this.dgvOperaciones, "dgvOperaciones");
            this.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Fecha,
            this.CUITCliente,
            this.RazonCliente,
            this.MedioPago,
            this.Habilitado,
            this.CodigoProducto,
            this.CantProd});
            this.dgvOperaciones.Name = "dgvOperaciones";
            this.dgvOperaciones.ReadOnly = true;
            this.dgvOperaciones.RowTemplate.Height = 24;
            this.dgvOperaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOperaciones_CellClick);
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
            // Habilitado
            // 
            resources.ApplyResources(this.Habilitado, "Habilitado");
            this.Habilitado.Name = "Habilitado";
            this.Habilitado.ReadOnly = true;
            // 
            // CodigoProducto
            // 
            resources.ApplyResources(this.CodigoProducto, "CodigoProducto");
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // CantProd
            // 
            resources.ApplyResources(this.CantProd, "CantProd");
            this.CantProd.Name = "CantProd";
            this.CantProd.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGenerarFactura
            // 
            resources.ApplyResources(this.btnGenerarFactura, "btnGenerarFactura");
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvProductos
            // 
            resources.ApplyResources(this.dgvProductos, "dgvProductos");
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Costo,
            this.Precio,
            this.Existencia});
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // Codigo
            // 
            resources.ApplyResources(this.Codigo, "Codigo");
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            resources.ApplyResources(this.Descripcion, "Descripcion");
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
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
            // ListarOperaciones
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvOperaciones);
            this.Controls.Add(this.dgvCliente);
            this.Name = "ListarOperaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.DataGridView dgvOperaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUITCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habilitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantProd;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
    }
}
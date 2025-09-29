namespace LastProyecto
{
    partial class Operacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operacion));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numCantProd = new System.Windows.Forms.NumericUpDown();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.btnAgregarAlCarro = new System.Windows.Forms.Button();
            this.txtCarrito = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscaProducto = new System.Windows.Forms.TextBox();
            this.btnReestableceDGV = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numCantProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtPrecio
            // 
            resources.ApplyResources(this.txtPrecio, "txtPrecio");
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // numCantProd
            // 
            resources.ApplyResources(this.numCantProd, "numCantProd");
            this.numCantProd.Name = "numCantProd";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUIT,
            this.Razon});
            resources.ApplyResources(this.dgvClientes, "dgvClientes");
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtDescuento
            // 
            resources.ApplyResources(this.txtDescuento, "txtDescuento");
            this.txtDescuento.Name = "txtDescuento";
            // 
            // btnAgregarAlCarro
            // 
            resources.ApplyResources(this.btnAgregarAlCarro, "btnAgregarAlCarro");
            this.btnAgregarAlCarro.Name = "btnAgregarAlCarro";
            this.btnAgregarAlCarro.UseVisualStyleBackColor = true;
            this.btnAgregarAlCarro.Click += new System.EventHandler(this.btnAgregarAlCarro_Click);
            // 
            // txtCarrito
            // 
            resources.ApplyResources(this.txtCarrito, "txtCarrito");
            this.txtCarrito.Name = "txtCarrito";
            this.txtCarrito.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtBuscaProducto
            // 
            resources.ApplyResources(this.txtBuscaProducto, "txtBuscaProducto");
            this.txtBuscaProducto.Name = "txtBuscaProducto";
            this.txtBuscaProducto.TextChanged += new System.EventHandler(this.txtBuscaProducto_TextChanged);
            // 
            // btnReestableceDGV
            // 
            resources.ApplyResources(this.btnReestableceDGV, "btnReestableceDGV");
            this.btnReestableceDGV.Name = "btnReestableceDGV";
            this.btnReestableceDGV.UseVisualStyleBackColor = true;
            this.btnReestableceDGV.Click += new System.EventHandler(this.btnBuscaProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Costo,
            this.PrecioP,
            this.Existencia});
            resources.ApplyResources(this.dgvProductos, "dgvProductos");
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick_1);
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
            // PrecioP
            // 
            resources.ApplyResources(this.PrecioP, "PrecioP");
            this.PrecioP.Name = "PrecioP";
            this.PrecioP.ReadOnly = true;
            // 
            // Existencia
            // 
            resources.ApplyResources(this.Existencia, "Existencia");
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            // 
            // Operacion
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnReestableceDGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBuscaProducto);
            this.Controls.Add(this.txtCarrito);
            this.Controls.Add(this.btnAgregarAlCarro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.numCantProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Operacion";
            this.Load += new System.EventHandler(this.Operacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numCantProd;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Button btnAgregarAlCarro;
        private System.Windows.Forms.TextBox txtCarrito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscaProducto;
        private System.Windows.Forms.Button btnReestableceDGV;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
    }
}
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numCantProd = new System.Windows.Forms.NumericUpDown();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.btnAgregarAlCarro = new System.Windows.Forms.Button();
            this.txtCarrito = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscaProducto = new System.Windows.Forms.TextBox();
            this.btnBuscaProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numCantProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Medio de Pago";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 82);
            this.button1.TabIndex = 6;
            this.button1.Text = "Realizar Compra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Precio a Pagar";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(171, 513);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(100, 30);
            this.txtPrecio.TabIndex = 7;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Efectivo",
            "Transferencia"});
            this.comboBox1.Location = new System.Drawing.Point(171, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cantidad de Productos";
            // 
            // numCantProd
            // 
            this.numCantProd.Location = new System.Drawing.Point(171, 55);
            this.numCantProd.Name = "numCantProd";
            this.numCantProd.Size = new System.Drawing.Size(100, 22);
            this.numCantProd.TabIndex = 12;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(299, 22);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(395, 290);
            this.dgvClientes.TabIndex = 13;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descuentos Aplicables";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(171, 83);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 22);
            this.txtDescuento.TabIndex = 15;
            // 
            // btnAgregarAlCarro
            // 
            this.btnAgregarAlCarro.Location = new System.Drawing.Point(15, 309);
            this.btnAgregarAlCarro.Name = "btnAgregarAlCarro";
            this.btnAgregarAlCarro.Size = new System.Drawing.Size(256, 82);
            this.btnAgregarAlCarro.TabIndex = 17;
            this.btnAgregarAlCarro.Text = "Agregar Al Carrito";
            this.btnAgregarAlCarro.UseVisualStyleBackColor = true;
            this.btnAgregarAlCarro.Click += new System.EventHandler(this.btnAgregarAlCarro_Click);
            // 
            // txtCarrito
            // 
            this.txtCarrito.Location = new System.Drawing.Point(299, 339);
            this.txtCarrito.Multiline = true;
            this.txtCarrito.Name = "txtCarrito";
            this.txtCarrito.ReadOnly = true;
            this.txtCarrito.Size = new System.Drawing.Size(845, 204);
            this.txtCarrito.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Buscar Productos";
            // 
            // txtBuscaProducto
            // 
            this.txtBuscaProducto.Location = new System.Drawing.Point(171, 115);
            this.txtBuscaProducto.Name = "txtBuscaProducto";
            this.txtBuscaProducto.Size = new System.Drawing.Size(100, 22);
            this.txtBuscaProducto.TabIndex = 19;
            // 
            // btnBuscaProducto
            // 
            this.btnBuscaProducto.Location = new System.Drawing.Point(15, 221);
            this.btnBuscaProducto.Name = "btnBuscaProducto";
            this.btnBuscaProducto.Size = new System.Drawing.Size(256, 82);
            this.btnBuscaProducto.TabIndex = 21;
            this.btnBuscaProducto.Text = "Buscar Productos";
            this.btnBuscaProducto.UseVisualStyleBackColor = true;
            this.btnBuscaProducto.Click += new System.EventHandler(this.btnBuscaProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(749, 22);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(395, 290);
            this.dgvProductos.TabIndex = 22;
            // 
            // Operacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 555);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnBuscaProducto);
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
            this.Text = "Operacion";
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
        private System.Windows.Forms.Button btnBuscaProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}
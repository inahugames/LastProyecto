namespace LastProyecto
{
    partial class FormFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFactura));
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.btnGuardarFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFactura
            // 
            resources.ApplyResources(this.txtFactura, "txtFactura");
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.ReadOnly = true;
            // 
            // btnGuardarFactura
            // 
            resources.ApplyResources(this.btnGuardarFactura, "btnGuardarFactura");
            this.btnGuardarFactura.Name = "btnGuardarFactura";
            this.btnGuardarFactura.UseVisualStyleBackColor = true;
            this.btnGuardarFactura.Click += new System.EventHandler(this.btnGuardarFactura_Click);
            // 
            // FormFactura
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGuardarFactura);
            this.Controls.Add(this.txtFactura);
            this.Name = "FormFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Button btnGuardarFactura;
    }
}
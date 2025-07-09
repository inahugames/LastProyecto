namespace LastProyecto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaOperaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureboxUS = new System.Windows.Forms.PictureBox();
            this.pictureboxAR = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxUS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxAR)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listasToolStripMenuItem,
            this.nuevaOperaciónToolStripMenuItem,
            this.listarOperacionesToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // listasToolStripMenuItem
            // 
            resources.ApplyResources(this.listasToolStripMenuItem, "listasToolStripMenuItem");
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Click += new System.EventHandler(this.listasToolStripMenuItem_Click);
            // 
            // nuevaOperaciónToolStripMenuItem
            // 
            resources.ApplyResources(this.nuevaOperaciónToolStripMenuItem, "nuevaOperaciónToolStripMenuItem");
            this.nuevaOperaciónToolStripMenuItem.Name = "nuevaOperaciónToolStripMenuItem";
            this.nuevaOperaciónToolStripMenuItem.Click += new System.EventHandler(this.nuevaOperaciónToolStripMenuItem_Click);
            // 
            // listarOperacionesToolStripMenuItem
            // 
            resources.ApplyResources(this.listarOperacionesToolStripMenuItem, "listarOperacionesToolStripMenuItem");
            this.listarOperacionesToolStripMenuItem.Name = "listarOperacionesToolStripMenuItem";
            this.listarOperacionesToolStripMenuItem.Click += new System.EventHandler(this.listarOperacionesToolStripMenuItem_Click);
            // 
            // txtUser
            // 
            resources.ApplyResources(this.txtUser, "txtUser");
            this.txtUser.Name = "txtUser";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pictureboxUS
            // 
            resources.ApplyResources(this.pictureboxUS, "pictureboxUS");
            this.pictureboxUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureboxUS.Image = global::LastProyecto.Properties.Resources.flag_us;
            this.pictureboxUS.Name = "pictureboxUS";
            this.pictureboxUS.TabStop = false;
            this.pictureboxUS.Click += new System.EventHandler(this.pictureboxUS_Click);
            // 
            // pictureboxAR
            // 
            resources.ApplyResources(this.pictureboxAR, "pictureboxAR");
            this.pictureboxAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureboxAR.Image = global::LastProyecto.Properties.Resources.flag_ar;
            this.pictureboxAR.Name = "pictureboxAR";
            this.pictureboxAR.TabStop = false;
            this.pictureboxAR.Click += new System.EventHandler(this.pictureboxAR_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureboxUS);
            this.Controls.Add(this.pictureboxAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxUS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaOperaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarOperacionesToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureboxAR;
        private System.Windows.Forms.PictureBox pictureboxUS;
    }
}
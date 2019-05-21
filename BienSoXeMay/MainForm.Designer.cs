namespace NhậnDiệnBiểnSốXe
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.quảnLýVéXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýXeVàoBãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýXeRaBãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinXeRaVàoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quảnLýVéXeToolStripMenuItem
            // 
            this.quảnLýVéXeToolStripMenuItem.Name = "quảnLýVéXeToolStripMenuItem";
            this.quảnLýVéXeToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.quảnLýVéXeToolStripMenuItem.Text = "Quản lý vé xe";
            this.quảnLýVéXeToolStripMenuItem.Click += new System.EventHandler(this.quảnLýVéXeToolStripMenuItem_Click);
            // 
            // quảnLýXeVàoBãiToolStripMenuItem
            // 
            this.quảnLýXeVàoBãiToolStripMenuItem.Name = "quảnLýXeVàoBãiToolStripMenuItem";
            this.quảnLýXeVàoBãiToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.quảnLýXeVàoBãiToolStripMenuItem.Text = "Quản lý xe vào bãi";
            this.quảnLýXeVàoBãiToolStripMenuItem.Click += new System.EventHandler(this.quảnLýXeVàoBãiToolStripMenuItem_Click);
            // 
            // quảnLýXeRaBãiToolStripMenuItem
            // 
            this.quảnLýXeRaBãiToolStripMenuItem.Name = "quảnLýXeRaBãiToolStripMenuItem";
            this.quảnLýXeRaBãiToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.quảnLýXeRaBãiToolStripMenuItem.Text = "Quản lý xe ra bãi";
            this.quảnLýXeRaBãiToolStripMenuItem.Click += new System.EventHandler(this.quảnLýXeRaBãiToolStripMenuItem_Click);
            // 
            // thôngTinXeRaVàoToolStripMenuItem
            // 
            this.thôngTinXeRaVàoToolStripMenuItem.Name = "thôngTinXeRaVàoToolStripMenuItem";
            this.thôngTinXeRaVàoToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.thôngTinXeRaVàoToolStripMenuItem.Text = "Thông tin xe ra vào";
            this.thôngTinXeRaVàoToolStripMenuItem.Click += new System.EventHandler(this.thôngTinXeRaVàoToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýAdminToolStripMenuItem,
            this.quảnLýVéXeToolStripMenuItem,
            this.quảnLýXeVàoBãiToolStripMenuItem,
            this.quảnLýXeRaBãiToolStripMenuItem,
            this.thôngTinXeRaVàoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1410, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýAdminToolStripMenuItem
            // 
            this.quảnLýAdminToolStripMenuItem.Name = "quảnLýAdminToolStripMenuItem";
            this.quảnLýAdminToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.quảnLýAdminToolStripMenuItem.Text = "Quản lý Admin";
            this.quảnLýAdminToolStripMenuItem.Click += new System.EventHandler(this.quảnLýAdminToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 724);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý xe ra vào Big C";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem quảnLýVéXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýXeVàoBãiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýXeRaBãiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinXeRaVàoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýAdminToolStripMenuItem;
    }
}
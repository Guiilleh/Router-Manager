namespace Router_Manager
{
    partial class RouterM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouterM));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileM = new System.Windows.Forms.ToolStripMenuItem();
            this.F_ChangeIPM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.F_ExitM = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.H_AboutM = new System.Windows.Forms.ToolStripMenuItem();
            this.IP1 = new System.Windows.Forms.ToolStripTextBox();
            this.defaultIPb = new System.Windows.Forms.Button();
            this.actualaddress = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.gotob = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 27);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(784, 535);
            this.webBrowser1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileM,
            this.HelpM,
            this.IP1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileM
            // 
            this.FileM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.F_ChangeIPM,
            this.toolStripSeparator2,
            this.F_ExitM});
            this.FileM.Name = "FileM";
            this.FileM.Size = new System.Drawing.Size(37, 23);
            this.FileM.Text = "&File";
            // 
            // F_ChangeIPM
            // 
            this.F_ChangeIPM.Name = "F_ChangeIPM";
            this.F_ChangeIPM.Size = new System.Drawing.Size(168, 22);
            this.F_ChangeIPM.Text = "&Change default IP";
            this.F_ChangeIPM.Click += new System.EventHandler(this.F_ChangeIPM_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // F_ExitM
            // 
            this.F_ExitM.Name = "F_ExitM";
            this.F_ExitM.Size = new System.Drawing.Size(168, 22);
            this.F_ExitM.Text = "E&xit";
            this.F_ExitM.Click += new System.EventHandler(this.F_ExitM_Click);
            // 
            // HelpM
            // 
            this.HelpM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.H_AboutM});
            this.HelpM.Name = "HelpM";
            this.HelpM.Size = new System.Drawing.Size(44, 23);
            this.HelpM.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(113, 6);
            // 
            // H_AboutM
            // 
            this.H_AboutM.Name = "H_AboutM";
            this.H_AboutM.Size = new System.Drawing.Size(116, 22);
            this.H_AboutM.Text = "&About...";
            this.H_AboutM.Click += new System.EventHandler(this.H_AboutM_Click);
            // 
            // IP1
            // 
            this.IP1.Name = "IP1";
            this.IP1.Size = new System.Drawing.Size(100, 23);
            this.IP1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IP1_KeyDown);
            // 
            // defaultIPb
            // 
            this.defaultIPb.Location = new System.Drawing.Point(323, 1);
            this.defaultIPb.Name = "defaultIPb";
            this.defaultIPb.Size = new System.Drawing.Size(60, 21);
            this.defaultIPb.TabIndex = 4;
            this.defaultIPb.Text = "&Default IP";
            this.defaultIPb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.defaultIPb.UseVisualStyleBackColor = true;
            this.defaultIPb.Click += new System.EventHandler(this.defaultIPb_Click);
            // 
            // actualaddress
            // 
            this.actualaddress.AutoSize = true;
            this.actualaddress.BackColor = System.Drawing.SystemColors.Control;
            this.actualaddress.Location = new System.Drawing.Point(470, 5);
            this.actualaddress.Name = "actualaddress";
            this.actualaddress.Size = new System.Drawing.Size(38, 13);
            this.actualaddress.TabIndex = 0;
            this.actualaddress.Text = "http://";
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(394, 1);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(60, 21);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "&Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // gotob
            // 
            this.gotob.Location = new System.Drawing.Point(265, 1);
            this.gotob.Name = "gotob";
            this.gotob.Size = new System.Drawing.Size(45, 21);
            this.gotob.TabIndex = 3;
            this.gotob.Text = "&Go to";
            this.gotob.UseVisualStyleBackColor = true;
            this.gotob.Click += new System.EventHandler(this.gotoB_Click);
            // 
            // RouterM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.gotob);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.actualaddress);
            this.Controls.Add(this.defaultIPb);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "RouterM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Router Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.gotoB_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button defaultIPb;
        private System.Windows.Forms.Label actualaddress;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ToolStripMenuItem FileM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem F_ExitM;
        private System.Windows.Forms.ToolStripMenuItem HelpM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem H_AboutM;
        private System.Windows.Forms.ToolStripMenuItem F_ChangeIPM;
        private System.Windows.Forms.Button gotob;
        private System.Windows.Forms.ToolStripTextBox IP1;
    }
}


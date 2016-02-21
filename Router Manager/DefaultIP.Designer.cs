namespace Router_Manager
{
    partial class DefaultIP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultIP));
            this.IPbox = new System.Windows.Forms.TextBox();
            this.changeb = new System.Windows.Forms.Button();
            this.cancelb = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IPbox
            // 
            this.IPbox.Location = new System.Drawing.Point(25, 20);
            this.IPbox.Name = "IPbox";
            this.IPbox.Size = new System.Drawing.Size(200, 20);
            this.IPbox.TabIndex = 0;
            this.IPbox.Text = "192.168.1.1";
            this.IPbox.WordWrap = false;
            this.IPbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IPbox_KeyDown);
            // 
            // changeb
            // 
            this.changeb.Location = new System.Drawing.Point(56, 55);
            this.changeb.Name = "changeb";
            this.changeb.Size = new System.Drawing.Size(75, 23);
            this.changeb.TabIndex = 1;
            this.changeb.Text = "&Change";
            this.changeb.UseVisualStyleBackColor = true;
            this.changeb.Click += new System.EventHandler(this.changeb_Click);
            // 
            // cancelb
            // 
            this.cancelb.Location = new System.Drawing.Point(150, 55);
            this.cancelb.Name = "cancelb";
            this.cancelb.Size = new System.Drawing.Size(75, 23);
            this.cancelb.TabIndex = 2;
            this.cancelb.Text = "C&ancel";
            this.cancelb.UseVisualStyleBackColor = true;
            this.cancelb.Click += new System.EventHandler(this.cancelb_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 65);
            this.textBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(58, 69);
            this.listBox1.TabIndex = 4;
            // 
            // DefaultIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 91);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancelb);
            this.Controls.Add(this.changeb);
            this.Controls.Add(this.IPbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "DefaultIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DefaultIP";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DefaultIP_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPbox;
        private System.Windows.Forms.Button changeb;
        private System.Windows.Forms.Button cancelb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}
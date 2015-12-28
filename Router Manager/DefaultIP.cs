using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Router_Manager
{
    public partial class DefaultIP : Form
    {
        public DefaultIP()
        {
            InitializeComponent();
            // Setting Default.IP to the TextBox IPbox
            System.IO.StreamReader File = new System.IO.StreamReader(@"Default.IP");
            String IPtxt = File.ReadLine();
            IPbox.Text = IPtxt;
            File.Close();
        }

        private void IPbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateIPMethod();
            }
        }

        private void changeb_Click(object sender, EventArgs e)
        {
            UpdateIPMethod();            
        }

        private void cancelb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateIPMethod()
        {
            var confirmResult = MessageBox.Show("Are you sure you want to change the default IP?",
                                     "Confirm Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                String newIP = IPbox.Text;
                System.IO.File.WriteAllText(@"Default.IP", newIP);
                Close();
            }
            else
            {
                Close();
            }
        }
        private void DefaultIP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.C)
            {
                this.changeb.Focus();
            }
            else if (e.Alt && e.KeyCode == Keys.A)
            {
                this.cancelb.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
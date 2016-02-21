using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Router_Manager
{
    public partial class DefaultIP : Form
    {
        public DefaultIP()
        {
            InitializeComponent();
            // Setting Default.IP to the TextBox IPbox
            //System.IO.StreamWriter Filu = new System.IO.StreamWriter(@"Default.IP");
            //System.IO.StreamReader File = new System.IO.StreamReader(@"Default.IP");
            //String IPtxt = File.ReadLine();
            //IPbox.Text = IPtxt;
            //File.Close();
            
            //StreamReader sr = new StreamReader(@"Data\Default.IP");
            //string ur = sr.ReadLine();
            //IPbox.Text = ur;
            string ar = File.ReadAllLines(@"Data\Default.IP").Skip(1).Take(1).First();
            char[] w = new char[ar.Length];
            using (StringReader sr = new StringReader(ar))
            {
                sr.Read(w, 0, 5);
                //textBox1.Text = b;
                string s = new string(w);
                System.Diagnostics.Debug.WriteLine(s);
                Array[] rr = new Array[ar.Length];
                //listBox1.Items.AddRange(rr) = rr;
            }
            

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
            if (e.Alt && (e.KeyCode == Keys.C))
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
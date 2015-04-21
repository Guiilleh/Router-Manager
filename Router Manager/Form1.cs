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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void IPChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String IPs = IP1.Text;
                var address = "http://" + IPs;
                webBrowser1.Navigate(new Uri(address));
                String URLv = address.ToString();
                label2.Text = URLv;
            }
        }
        private void IPChanged(object sender, EventArgs e)
        {
                String IPs = IP1.Text;
                var address = "http://" + IPs;
                webBrowser1.Navigate(new Uri(address));
                String URLv = address.ToString();
                label2.Text = URLv;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            IP1.Text = "192.168.1.1";
            String IPs = IP1.Text;
            var address = "http://" + IPs;
            webBrowser1.Navigate(new Uri(address));
            String URLv = address.ToString();
            label2.Text = URLv;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (!webBrowser1.Url.Equals("about:blank"))
            {
                webBrowser1.Refresh();
            }
        }
    }
}
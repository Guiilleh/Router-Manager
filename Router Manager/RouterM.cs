using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Router_Manager
{
    //test
    public partial class RouterM : Form
    {
        public RouterM()
        {
            InitializeComponent();
            webBrowser1.Navigate(new Uri("http://google.com"));
        }
        public static void setorgetvalues()         // re-do
        {
            //do

        }
        public static void setvalueoflabel()        // re-do
        {
            //do

        }
        private void defaultIPb_Click(object sender, EventArgs e)
        {
            // This is supposed to take you to the address specified by Default.IP
            // Gotta re-do
        }
        private void gotoB_Click(object sender, EventArgs e)        // Appears to be working
        {
            String IPs = IP1.Text;
            var address = "http://" + IPs;
            webBrowser1.Navigate(new Uri(address));
        }
        private void IP1_KeyDown(object sender, KeyEventArgs e)     // Working
        {
            if (e.KeyCode == Keys.Enter)
            {
                gotoB_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F1)
            {
                var About = new About();
                About.ShowDialog();
            }
        }
        private void refresh_Click(object sender, EventArgs e)          // Working
        {
            if (!webBrowser1.Url.Equals("about:blank"))
            {
                webBrowser1.Refresh();
            }
        }
        private void F_ExitM_Click(object sender, EventArgs e)          // Working
        {
            Close();
        }
        private void F_ChangeIPM_Click(object sender, EventArgs e)      // Working
        {
            var DefaultIP = new DefaultIP();
            DefaultIP.ShowDialog();
        }
        private void H_AboutM_Click(object sender, EventArgs e)         // Working
        {
            var About = new About();
            About.ShowDialog();
        }
        private void showURL_1(object sender, WebBrowserNavigatedEventArgs e)   // Working
        {
            actualaddress.Text = webBrowser1.Url.ToString();
        }
        private void showURL_2(object sender, WebBrowserDocumentCompletedEventArgs e)   // Working
        {
            actualaddress.Text = webBrowser1.Url.ToString();
        }

        private void webBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gotoB_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F6)
            {
                IP1.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                refresh_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F1)
            {
                var asd2 = new About();
                asd2.ShowDialog(); 
            }
        }
    }
}
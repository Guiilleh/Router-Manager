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
    public partial class RouterM : Form
    {
        public RouterM()
        {
            InitializeComponent();                                                      // Start
            System.IO.StreamReader File = new System.IO.StreamReader(@"Default.IP");    // Renders IP from file
            String IPtxt = File.ReadLine();                                             // Converts IP to String
            IP1.Text = IPtxt;                                                      // Sets IP box to IP from file
            File.Close();                                                               // Closes used IP file
            
        }
        private void gotoB_Click(object sender, EventArgs e)
        {
            String IPs = IP1.Text;                              // Renders IP from box to String
            var address = "http://" + IPs;                      // Converts String to URL
            webBrowser1.Navigate(new Uri(address));             // Opens new URL
            actualaddress.Text = address;                       // Shows opened URL
        }
        private void IP1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gotoB_Click(sender, e);                         // Executes gotoB_Click
            }
        }
        private void defaultIPb_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader File = new System.IO.StreamReader(@"Default.IP");    // Renders IP from file
            String IPtxt = File.ReadLine();                                             // Converts IP to String
            var address = "http://" + IPtxt;                                            // Converts String to URL
            webBrowser1.Navigate(new Uri(address));                                     // Opens new URL
            actualaddress.Text = address;                                               // Shows opened URL
            //actualaddress.Text = webBrowser1.Url.ToString();                            // Shows ACTUAL URL
            IP1.Text = IPtxt;                                                           // Default IP to box
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            if (!webBrowser1.Url.Equals("about:blank"))             // Refresh method
            {                                                       // Refresh method
                webBrowser1.Refresh();                              // Refresh method
                actualaddress.Text = webBrowser1.Url.ToString();    // Shows ACTUAL URL
            }                                                       // Refresh method
        }
        private void F_ExitM_Click(object sender, EventArgs e)
        {
            Close(); // Closes main window
        }
        private void F_ChangeIPM_Click(object sender, EventArgs e)
        {
            DefaultIP asd1 = new DefaultIP();   // Creates new DefaultIP window
            asd1.ShowDialog();                  // Opens new DefaultIP window
        }
        private void H_AboutM_Click(object sender, EventArgs e)
        {
            About asd2 = new About();   // Creates new About window
            asd2.ShowDialog();          // Opens new About window
        }
    }
}
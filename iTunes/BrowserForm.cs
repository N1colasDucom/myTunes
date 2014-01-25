using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTunes
{
    public partial class BrowserForm : Form
    {
        public BrowserForm()
        {
            InitializeComponent();
        }


        private void BtnGO_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(TxtBoxURL.Text);
        }


        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            TxtBoxURL.Text = webBrowser1.Url.ToString();
        }

        private void TxtBoxURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) { webBrowser1.Navigate(TxtBoxURL.Text); }
        }

        private void BtnSuivant_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void BtnPrecedent_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }



    }
}

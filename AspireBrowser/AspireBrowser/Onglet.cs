using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspireBrowser
{
    public partial class Onglet : Form
    {

        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                TheAspireBrowser.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        public Onglet()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void retourButton_Click(object sender, EventArgs e)
        {
            TheAspireBrowser.GoBack();
        }

        private void suivantButton_Click(object sender, EventArgs e)
        {
            TheAspireBrowser.GoForward();
        }

        private void rafraichirButton_Click(object sender, EventArgs e)
        {
            TheAspireBrowser.Refresh();
        }
    

        private void TheAspireBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void barreDeRecherche_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(barredeRecherche.Text);
            }
        }

        private void barredeRecherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void theAspireBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            barredeRecherche.Text = TheAspireBrowser.Url.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendrier1
{
    public partial class registerwithgoogle : Form
    {
        public registerwithgoogle()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void registerwithgoogle_Load(object sender, EventArgs e)
        {
            String url = @"http://localhost/php/google.html";
            webgoogle.Navigate(url);
        }
    }
}

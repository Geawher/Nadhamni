using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendrier
{
    public partial class details_jour : Form
    {
        public details_jour()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            calendrier f1 = new calendrier();
            f1.Show();
            this.Close();
        }
    }
}

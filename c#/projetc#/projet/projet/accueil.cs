using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet
{
    public partial class accueil : Form
    {
        public accueil()
        {
            InitializeComponent();

            
        }
        private void generateDaypanel(int totaleDay )
        { 
        for(int i = 0; i<=totaleDay;i++) {
                FlowLayoutPanel f1 = new FlowLayoutPanel();
                f1.Name = $"f1Day{i}"; 
                f1.Size = new Size(113, 88);
                f1.BackColor = Color.White;
                f1.BorderStyle = BorderStyle.FixedSingle;
                f1Day.Controls.Add(f1);
               

            }
        
        
        
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void accueil_Load(object sender, EventArgs e)
        {
            generateDaypanel(30); 

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}

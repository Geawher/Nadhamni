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
    public partial class calendrier : Form
    {
        private List<FlowLayoutPanel> listf1Days = new List<FlowLayoutPanel>();
        private DateTime date = DateTime.Today;
        details_jour f1 = new details_jour();

        public calendrier()
        {
            InitializeComponent();
        }

        public  void moisannee() {
            calendrierdate.Text = date.ToString("MMMM, yyyy"); 
        
        }
        public void moispres() {
            date= date.AddMonths(-1);
            moisannee(); }

        public void moissuiv()
        {
            date= date.AddMonths(1);
            moisannee();
        }



        private void generateDays(int Days)
        {
            f1Days.Controls.Clear();
            listf1Days.Clear();
         
            

            for (int i = 0; i <= Days; i++)
            {
                FlowLayoutPanel f1 = new FlowLayoutPanel();
                f1.Name = $"f1Day{i}";
                f1.Size = new Size(113, 88);
                f1.BackColor = Color.Transparent; 
                f1.BorderStyle = BorderStyle.FixedSingle;
               f1Days.Controls.Add(f1);
                listf1Days.Add(f1); 


            }}



        private void Ajouterjour(int jour) {
            int jr = 1;
            for (int i = jour; i <= listf1Days.Count()-1; i++) {
                Label l1 = new Label();
                l1.Name= $"lblDay{i}";
                l1.AutoSize = false;
                l1.TextAlign = ContentAlignment.TopRight; 
                l1.ForeColor = Color.White;
                l1.Size = new Size(100,22) ;
                l1.Text = jr.ToString();  
                listf1Days[i].Controls.Add(l1);
                jr++; }
            LinkLabel l2 = new LinkLabel();
            l2.Text = "Activité de jour ";
            l2.AutoSize = true;
            l2.Click += new EventHandler(l2_Onclick);
            l2.LinkColor = Color.White;
            listf1Days[1].Controls.Add(l2);
            








        }

        private void l2_Onclick(object sender, EventArgs e)
        {
            f1.Show();
            
          
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void calendrier_Load(object sender, EventArgs e)
        {
            generateDays(31);
            Ajouterjour(1);
            moisannee(); 

            }
      
        private void button_WOC1_Click(object sender, EventArgs e)
        {
           
            moissuiv(); 
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            moispres();
        }

       

        private void button_WOC1_Click_2(object sender, EventArgs e)
        {
            details_jour f1 = new details_jour();
            f1.Show();
            this.Close(); 
        }

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {

        }

    

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
       
    }
}

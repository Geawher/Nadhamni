using calendrier1;
using EO.Internal;
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
        private List<FlowLayoutPanel> listtemps = new List<FlowLayoutPanel>();
        DateTime date; 
        public details_jour()
        {
            InitializeComponent();
        }



            private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
            calendrier f1 = new calendrier();
            f1.Show(); 
            
        }

        private void details_jour_Load(object sender, EventArgs e)
        {
            affichage.ClearSelection(); 
            int nbr = calendrier.list_act.Count();
            int i;
            for (i = 0; i <= nbr-1; i++)
            {
                if (calendrier.list_act[i].Date_act.ToString("MM/dd/yyyy").Equals(calendrier.dateselect.Date_act.ToString("MM/dd/yyyy")) && calendrier.list_act[i].Personne.Equals(Form2.p.Username) == true)
                    affichage.Rows.Add(calendrier.list_act[i].Nom, calendrier.list_act[i].Date_act.ToString("MM/dd/yyyy"),calendrier.list_act[i].Temps_act,
                        calendrier.list_act[i].Nom_categorie,calendrier.list_act[i].Nom_adr, calendrier.list_act[i].Recurrence);
            }
            
           
             
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void printPreviewDialog1_Load(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = ActiveForm.CreateGraphics();
            bmp = new Bitmap(ActiveForm.Size.Width, ActiveForm.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(ActiveForm.Location.X, ActiveForm.Location.Y, 0, 0, ActiveForm.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
    }


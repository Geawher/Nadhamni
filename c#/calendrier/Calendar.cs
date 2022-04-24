using calendrier1;
using EO.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendrier
{
    public partial class calendrier : Form
    {

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private List<FlowLayoutPanel> listf1Days = new List<FlowLayoutPanel>();
        private DateTime date = DateTime.Today;
        MouseEventArgs e; 
        details_jour f1 = new details_jour();
        static internal List<activité> list_act = new List<activité>();
        static internal activité dateselect = new activité();
        static internal List<activité> list_act3 = new List<activité>();
        internal List<activité> List_act { get => list_act; set => list_act = value; }


       public void notification() {
            list_act3.Clear(); 
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-NK1C49G\\SQLEXPRESS01; Initial Catalog = db_nadhamni; Integrated Security = True";
            con.Open();
            String req = "Select * from activity2 ;";
            SqlCommand cmd = new SqlCommand(req, con);
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            int nbr; 
            while (reader.Read())
            {

                activité a = new activité();
                a.Nom = reader.GetString(1);
                a.Date_act = reader.GetDateTime(2);
                a.Temps_act = reader.GetString(3) + "-" + reader.GetString(8);
                a.Recurrence = reader.GetString(5);
                a.Nom_categorie = reader.GetString(5);
                a.Personne = reader.GetString(6);
                a.Nom_adr = reader.GetString(7);
                list_act3.Add(a);
            }
            DateTime datesystem = new DateTime();
            datesystem = DateTime.Now; 
            nbr = list_act3.Count();
            for (i = 0; i <= nbr - 1; i++)
            {
                if (list_act3[i].Date_act.ToString("MM/dd/yyyy").Equals(datesystem.ToString("MM/dd/yyyy"))){
                    String act = list_act3[i].Nom + " " + list_act3[i].Temps_act;
                    this.Alert(act, Form_Alert.enmType.Info);
                }
            }}



    







        public calendrier()
        {
            InitializeComponent();
         
        }

        public  void moisannee() {
            calendrierdate.Text = date.ToString("MMMM, yyyy");
            Ajouterjour(premierjourdusemaine(), dernierjourdusemaine());





        }
        public void moispres() {
            date= date.AddMonths(-1);
            moisannee(); }

        public void moissuiv()
        {
            date= date.AddMonths(1);
            moisannee();
        }
        public void ajourdhuidate() {
            date = date.AddMonths(-1);
            moisannee();

        }

        public int premierjourdusemaine()
        {
            DateTime jour = new DateTime(date.Year, date.Month,1);
            return (int) jour.DayOfWeek +1 ; 
         }


        public int dernierjourdusemaine()
        {
            DateTime jour = new DateTime(date.Year, date.Month, 1);
            return (int)jour.AddMonths(1).AddDays(-1).Day; 
        }





        private void generateDays(int Days)
        {
            f1Days.Controls.Clear();
            listf1Days.Clear();
         
            for (int i = 1; i <= Days; i++)
            {
                FlowLayoutPanel f1 = new FlowLayoutPanel();
                f1.Name = $"f1Day{i}";
                f1.Size = new Size(113, 80);
                f1.BackColor = Color.Transparent; 
                f1.BorderStyle = BorderStyle.FixedSingle;
                f1Days.Controls.Add(f1);
                listf1Days.Add(f1);
                



            }
        }



        private void Ajouterjour(int jour , int nbrjourmois) {
            notification();

            for (int i =0; i <= 31; i++) {
                listf1Days[i].Controls.Clear(); 
            }


                for (int i = 1 ; i <= nbrjourmois ; i++) {
                Label l1 = new Label();
                l1.Name= $"lblDay{i}";
                l1.AutoSize = false;
                l1.TextAlign = ContentAlignment.TopRight; 
                l1.ForeColor = Color.White;
                l1.Size = new Size(100,22) ;
                l1.Text = i.ToString();
                listf1Days[(i - 1) + (jour - 1)].Controls.Clear();
                listf1Days[(i - 1) + (jour - 1)].Tag = i; 
                listf1Days[(i-1) + (jour-1)  ].Controls.Add(l1);
                FlowLayoutPanel l2 = new FlowLayoutPanel();
               DateTime d=new DateTime (date.Year, date.Month, i);
                l2.Click += l2_Onclick; 
                listf1Days[(i - 1) + (jour - 1)].Controls.Add(l2);
                 void l2_Onclick(object sender, EventArgs e)
                {
                    list_act.Clear(); 
                    dateselect.Date_act = d; 
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=DESKTOP-NK1C49G\\SQLEXPRESS01; Initial Catalog = db_nadhamni; Integrated Security = True";
                    con.Open();
                    String req = "Select * from activity2 ;"; 
                    SqlCommand cmd = new SqlCommand(req, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    while (reader.Read()){

                        activité a = new activité();
                        a.Nom = reader.GetString(1);
                        a.Date_act = reader.GetDateTime(2);
                        a.Temps_act = reader.GetString(3) + "-" + reader.GetString(8);
                        a.Recurrence = reader.GetString(5);
                        a.Nom_categorie = reader.GetString(5);
                        a.Personne = reader.GetString(6);
                        a.Nom_adr = reader.GetString(7);
                        List_act.Add(a);}
                   
                   
                    this.Close();
                    f1.Show();


                }




            } }

       

        



        

      

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void calendrier_Load(object sender, EventArgs e)
        {
            

            generateDays(45);
            moisannee();
        }


        private void AddnewAppointment(object sender, EventArgs e) { 
        
        
        
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
            this.Close(); 
            details_jour f1 = new details_jour();
            f1.Show();
             
        }


        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            AddEvent f1 = new AddEvent();
            f1.Show(); 

        }

    

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddEvent addevent = new AddEvent();
            addevent.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stat f1 = new stat();
            f1.Show();
            done f2 = new done();
            f2.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            updateact f1 = new updateact();
            f1.Show();
          
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            notification();
            
        }
    }
}

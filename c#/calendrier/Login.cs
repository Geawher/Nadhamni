using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calendrier1;
using Facebook; 
namespace calendrier
{
    public partial class Form1 : Form
    {
        static internal Personne p1 = new Personne();
       
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int trouve = 0; 
            
            
                
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-NK1C49G\\SQLEXPRESS01; Initial Catalog = db_nadhamni; Integrated Security = True"; 
                con.Open();
                String req = "Select username,mdp from personne;";
                SqlCommand cmd = new SqlCommand(req, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while ((reader.Read())&&(trouve==0))
                { if ((reader.GetString(0).Equals(login.Text.ToString())) && (reader.GetString(1).Equals(pass.Text.ToString()))) 
                    {
                        calendrier f1 = new calendrier();
                    p1.Username = login.Text;
                    f1.Show();
                    this.Alert("Success ", Form_Alert.enmType.Success);
                    this.Hide();
                        trouve = 1;
                    Form2.p.Username = reader.GetString(0); 
                      
                    }

                 
                     }



            if (trouve == 0)
            {
                this.Alert("Error Alert", Form_Alert.enmType.Error);
                MessageBox.Show("CHECK YOU USERNAME OR PASSWORD");
            }
          
        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
             

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
          /*  registerwithfb f1 = new registerwithfb();
            f1.Show();*/
          
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
           
            Form2 inscrit = new Form2();
            inscrit.Show();
            
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
            /*registerwithgoogle f1 = new registerwithgoogle();
            f1.Show();*/
            
        }
    }
}

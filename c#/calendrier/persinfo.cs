using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calendrier1;
using System.Data.SqlClient;

namespace calendrier
{
    public partial class Form3 : Form
    {
        

        public Form3()
        {
            
        InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-NK1C49G\\SQLEXPRESS01;Initial Catalog=db_nadhamni;Integrated Security=True";
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {   if (rd1.Checked)
                Form2.p.Occupation = "BussinessMan";
            else if (rd2.Checked)
                Form2.p.Occupation = "Student";
            else if (rd3.Checked)
                Form2.p.Occupation = "Freelancer";
            else
                Form2.p.Occupation = "DailyWorker";
            if (sp.Checked)
                Form2.p.Hobby = "Sport";
            else if (gaming.Checked)
                Form2.p.Hobby = "Gaming";
            else if (cam.Checked)
                Form2.p.Hobby = "Camping";
            else if (tv.Checked)
                Form2.p.Hobby = "Tv";
            else if (read.Checked)
                Form2.p.Hobby = "Reading";
            else
                Form2.p.Hobby = other.Text;
            Form2.p.Situation = sit.selectedValue; 
                decimal value = child.Value;
            Form2.p.N_kids = (int)value;
           
            SqlConnection activity = new SqlConnection(conString);
            
            activity.Open();
            SqlCommand comm = new SqlCommand("update personne set occupation=@occupation,kids=@kids,hobby=@hobby,situation=@situation where username=@username",activity);
            comm.Parameters.AddWithValue("@occupation", Form2.p.Occupation.ToString());
            comm.Parameters.AddWithValue("@situation", Form2.p.Situation.ToString());
            comm.Parameters.AddWithValue("@kids", Form2.p.N_kids);
            comm.Parameters.AddWithValue("@hobby", Form2.p.Hobby.ToString());
            comm.Parameters.AddWithValue("@username", Form2.p.Username.ToString()); 
            comm.ExecuteNonQuery(); 
            calendrier calen = new calendrier();
            calen.Show();
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {       
            if (child.Value != 0)
           
                {
                    enfant f4 = new enfant();
                    f4.Show();

                }
            
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

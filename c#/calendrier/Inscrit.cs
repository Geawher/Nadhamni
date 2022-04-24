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
   
    public partial class Form2 : Form
    {
       static internal Personne p = new Personne();

        public Form2()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox7_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        { 
            p.Nom = Last_name.Text.ToString()+ Firstname.Text.ToString();
            p.Mail = Mail.Text;
            p.Password = Password.Text;
            p.Date_naiss = Date_naiss.Value;
            p.Username = Username.Text;
            if (r1.Checked)
                p.Sexe = 'h';
            else
                p.Sexe = 'f';
            SqlConnection con  = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-NK1C49G\\SQLEXPRESS01;Initial Catalog=db_nadhamni;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection=con;
            cmd.CommandText = "insert into personne(nom_pers,mdp,mail,username,date_naiss,sexe) values(@nom_pers,@mdp,@mail,@username,@date_naiss,@sexe)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@nom_pers", p.Nom.ToString());
            cmd.Parameters.AddWithValue("@mdp", p.Password.ToString());
            cmd.Parameters.AddWithValue("@date_naiss", p.Date_naiss);
            cmd.Parameters.AddWithValue("@username", p.Username.ToString());
            cmd.Parameters.AddWithValue("@sexe", p.Sexe.ToString());
            cmd.Parameters.AddWithValue("@mail", p.Mail.ToString());
            cmd.ExecuteNonQuery(); 
            Form3 f = new Form3();
            f.Show();
         
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}

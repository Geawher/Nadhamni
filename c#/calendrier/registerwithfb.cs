using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using System.Data.SqlClient;
using calendrier;
using EO.Internal;
using System.Messaging;

namespace calendrier1
{
    public partial class registerwithfb : Form
    {
        Personne p = new Personne(); 
        public registerwithfb()
        {
            InitializeComponent();
        }

        private void loginwithfb_Load(object sender, EventArgs e)
        {
            String url = @"http://localhost/php/API/login.php";
            webfacebook.Navigate(url);

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            String html = webfacebook.DocumentText;
            FacebookClient fb = new FacebookClient(html);
            dynamic data = fb.Get("/me?fields=id,name,birthday,first_name,last_name,gender,email");
           
            p.Nom = data.first_name + data.last_name; 
            p.Mail = data.email;
            p.Password = data.name;
            Form2.p.Username = data.name; 
            p.Username = data.name;
            if (data.gender == "female" )
                p.Sexe = 'f';
            else
                p.Sexe = 'h';
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-7399T5A\\SQLEXPRESS;Initial Catalog=bd_nadhamni;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into personne(nom_pers,mdp,mail,username) values(@nom_pers,@mdp,@mail,@username)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@nom_pers", p.Nom.ToString());
            cmd.Parameters.AddWithValue("@mdp", p.Password.ToString());
            cmd.Parameters.AddWithValue("@username", p.Username.ToString());
            cmd.Parameters.AddWithValue("@mail", p.Mail.ToString());
            cmd.ExecuteNonQuery();
            Form3 f1 = new Form3();
            f1.Show();
            
            




        }
    }
}

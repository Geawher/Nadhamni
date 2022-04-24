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
using calendrier;

namespace calendrier1
{
    public partial class enfant : Form
    {
        public string conString = "Data Source=DESKTOP-HORS9I9\\SQLEXPRESS;Initial Catalog=db_nadhamni;Integrated Security=True";

        public enfant()
        {
            InitializeComponent();
        }

        private void enfant_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            Enf enf= new Enf();
            enf.Name = firstname.Text+lastname.Text;
            enf.Father_name = Form2.p.Nom;
            enf.Age = age.Text;
            enf.Occupation = acd.selectedValue;

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand comm = new SqlCommand("insert into enfant(nom_enfant,father_name,age,occupation,Username_father)values(@nom_enfant,@father_name,@age,@occupation,@username_father)",conn);
            comm.Parameters.AddWithValue("@nom_enfant", enf.Name.ToString());
            comm.Parameters.AddWithValue("@father_name", enf.Father_name.ToString());
            comm.Parameters.AddWithValue("@occupation", enf.Occupation.ToString());
            comm.Parameters.AddWithValue("@age", enf.Age.ToString());
            comm.Parameters.AddWithValue("Username_father", Form2.p.Username.ToString());
            comm.ExecuteNonQuery();
            MessageBox.Show("ajout avec succés"); 






           
            
      
            enfant f = new enfant();
            f.Hide(); 




















        }
    }
}

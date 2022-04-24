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

namespace calendrier
{
    public partial class done : Form
    {
        SqlDataAdapter ad;
        DataSet ds = new DataSet();
        public done()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void done_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-NK1C49G\\SQLEXPRESS01;Initial Catalog=db_nadhamni;Integrated Security=True";
            conn.Open();
            ad = new SqlDataAdapter();
            SqlCommand comm = new SqlCommand("SELECT id_act,name_act,nom_categorie,done  FROM activity2 " +
 "WHERE id_personne = @id_personne", conn);
            comm.Parameters.AddWithValue("@id_personne", Form2.p.Username);

            ad.SelectCommand = comm;

            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void btn_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmd = new SqlCommandBuilder(ad);
            ad.Update(ds);
            done d = new done();
            d.Hide();
        }
    }
}

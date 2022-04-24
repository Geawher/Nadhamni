using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.CodeDom;
using calendrier1;

namespace calendrier
{
    public partial class AddEvent : Form
    {
        int row;
        private List<activité> list_act1 = new List<activité>();
        public AddEvent()
        {
            InitializeComponent();
        }

        public bool verifecxit()
        {  bool trouve = true;
            int i;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-NK1C49G\\SQLEXPRESS01; Initial Catalog = db_nadhamni; Integrated Security = True";
            con.Open();
            String req = "Select * from activity2 ;";
            SqlCommand cmd = new SqlCommand(req, con);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                activité a = new activité();
                a.Nom = reader.GetString(1);
                a.Date_act = reader.GetDateTime(2);
                a.Temps_act = reader.GetString(3) + "-" + reader.GetString(8);
                a.Recurrence = reader.GetString(4);
                a.Nom_categorie = reader.GetString(5);
                a.Personne = reader.GetString(7);
                a.Nom_adr = reader.GetString(8);
                list_act1.Add(a);
            }
            
           String temps_act = date_d.selectedValue + ":" + date_d1.selectedValue + "-" + date_f.selectedValue + ":" + date_f2.selectedValue;
            int nbr = list_act1.Count;
            for (i = 0; i <= nbr - 1; i++) {
                MessageBox.Show(list_act1[i].Temps_act);
                if (list_act1[i].Temps_act.Equals(temps_act) && list_act1[i].Date_act.ToString().Equals(date.Value.ToString())){ 
                    trouve = false; }}
            return trouve;
        }
        private void AddEvent_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            {
                DateTime dt = Convert.ToDateTime(date.Value);
                int x = DateTime.Compare(dt, DateTime.Now);
                DateTime datesys = new DateTime();
                datesys = DateTime.Now;
                bool verif = datesys.ToString("MM/dd/yyyy").Equals(dt.ToString("MM/dd/yyyy")); 


                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-NK1C49G\\SQLEXPRESS01; Initial Catalog = db_nadhamni; Integrated Security = True";
                conn.Open();
                if (label1.Text.Equals("ADD EVENT"))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "insert into activity2(id_act,name_act,date_d,tempsd,nom_categorie,nom_adr,tempsf,recurrence,id_personne) values (@id_act,@name_act,@date_d,@tempsd,@nom_categorie,@nom_adr,@tempsf,@recc,@id_personne)";
                        if (name.Text == "")
                            MessageBox.Show("Vous devez Saisir un Nom ");
                        else if (x < 0 && verif == false)
                            MessageBox.Show("Vous devez Choisir  une Date correcte");
                        else if (date_d.selectedIndex >= date_f.selectedIndex && (date_d1.selectedIndex == -1 && date_f2.selectedIndex == -1))
                            MessageBox.Show("Verfifier le Temps de l'activité");
                        else if (!R1.Checked && !R2.Checked && !R3.Checked && !R3.Checked && !R4.Checked && !R5.Checked)
                            MessageBox.Show("Vous devez choisir une Categorie ");
                        else if (location.Text == "")
                            MessageBox.Show("Vous devez Saisir une Adresse ");
                        else if (verifecxit() == false)
                        {
                            MessageBox.Show("Vous avez déja une Activité : Veuillez Changer le Temps  ");
                        }

                        else
                        {
                            cmd.Parameters.AddWithValue("@id_act", txt_id.Text);
                            cmd.Parameters.AddWithValue("@name_act", name.Text);
                            cmd.Parameters.AddWithValue("@date_d", date.Value);
                            cmd.Parameters.AddWithValue("@recc", recc.selectedValue);
                            cmd.Parameters.AddWithValue("@tempsd", date_d.selectedValue.ToString() + ":" + date_d1.selectedValue.ToString());
                            cmd.Parameters.AddWithValue("@tempsf", date_f.selectedValue.ToString() + ":" + date_f2.selectedValue.ToString());
                            cmd.Parameters.AddWithValue("@id_personne", Form1.p1.Username);

                            if (R1.Checked == true)
                                cmd.Parameters.AddWithValue("@nom_categorie", R1.Text);
                            else if (R2.Checked)
                                cmd.Parameters.AddWithValue("@nom_categorie", R2.Text);
                            else if (R3.Checked)
                                cmd.Parameters.AddWithValue("@nom_categorie", R3.Text);

                            else if (R4.Checked)
                                cmd.Parameters.AddWithValue("@nom_categorie", R4.Text);
                            else if (R5.Checked)
                                cmd.Parameters.AddWithValue("@nom_categorie", R5.Text);
                            cmd.Parameters.AddWithValue("@nom_adr", location.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("activité Ajouté ");
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                            conn.Close();
                        else
                            MessageBox.Show("Probleme de connexion base");
                    }

                }
                else if (label1.Text.Equals("DELETE EVENT"))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "DELETE FROM activity2 WHERE id_act=" + row;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Activity deleted ");

                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                            conn.Close();
                        else
                            MessageBox.Show("Probleme de connexion base");
                    }
                }
                else if (label1.Text.Equals("MODIFY EVENT"))
                { 
                    
                    
                    try
                    { SqlCommand cmd = new SqlCommand("update activity2 set name_act=@name_act ,nom_categorie=@nom_categorie,tempsd=@tempsd,tempsf=@tempsf,date_d=@date_d where id_act=@id_act",conn);
                        cmd.Parameters.AddWithValue("@name_act", name.Text);
                        cmd.Parameters.AddWithValue("@id_act", int.Parse(txt_id.Text));
                        cmd.Parameters.AddWithValue("@tempsd", date_d.selectedValue + ":" + date_d1.selectedValue);
                        cmd.Parameters.AddWithValue("@tempsf", date_f.selectedValue + ":" + date_f2.selectedValue);
                        cmd.Parameters.AddWithValue("@date_d", date.Value);

                        if (R1.Checked)
                            cmd.Parameters.AddWithValue("@nom_categorie", R1.Text);
                        else if (R2.Checked)
                            cmd.Parameters.AddWithValue("@nom_categorie", R2.Text);
                        else if (R3.Checked)
                            cmd.Parameters.AddWithValue("@nom_categorie", R3.Text);
                        else if (R4.Checked)
                            cmd.Parameters.AddWithValue("@nom_categorie", R4.Text);
    
                        else if (R5.Checked)
                            cmd.Parameters.AddWithValue("@nom_categorie", R5.Text);
                        else
                            MessageBox.Show("Vous devez Choisir une categorie ");
                        cmd.Parameters.AddWithValue("@nom_adr",location.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("activité  modifié");
                    }
                    catch ( Exception ex) { MessageBox.Show(ex.Message); }
                        finally
                    {
                        if (conn.State == ConnectionState.Open)
                            conn.Close();
                        else
                            MessageBox.Show("Probleme de connexion base");
                    }

                }
                }


        }

        private void recc_onItemSelected(object sender, EventArgs e)
        {
          
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reccc.Visible = true;
            hd.Visible = false;
            hf.Visible = false;
            md.Visible = false;
            mf.Visible = false;
            this.Text = "MODIFY EVENT";
            label1.Text = "MODIFY EVENT";
            btn2.Visible = true;
            txt_id.Visible = true;
            id_lbl.Visible = true;
            foreach (Control x in groupBox1.Controls)
            {

                x.Enabled = true;
            }
            btn.ButtonText = "Modify";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reccc.Visible = false;
            hd.Visible = false;
            hf.Visible = false;
            md.Visible = false;
            mf.Visible = false;
            btn2.Visible = true;
            label1.Text = "DELETE EVENT";
            this.Text = "DELETE EVENT";
            btn.ButtonText = "Delete";
            txt_id.Visible = true;
            id_lbl.Visible = true;
            foreach (Control x in groupBox1.Controls)
            {
                if (!(x is Label))
                { x.Enabled = false; }
            }
            btn2.Enabled = true;

        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reccc.Visible = false;
            hd.Visible = false;
            hf.Visible = false;
            md.Visible = false;
            mf.Visible = false;
            btn2.Visible = false;
            label1.Text = "ADD EVENT";
            this.Text = "ADD EVENT";
            btn.ButtonText = "ADD IT";
            txt_id.Visible = true;
            id_lbl.Visible = false;
            foreach (Control x in groupBox1.Controls)
            {

                x.Enabled = true;
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-NK1C49G\\SQLEXPRESS01; Initial Catalog = db_nadhamni; Integrated Security = True";
            con.Open();
            String req = "Select * from activity2;";
            SqlCommand cmd = new SqlCommand(req, con);
            SqlDataReader reader = cmd.ExecuteReader();
            int trouve = 0;
            int id1;
            String id2;
            String cat;
            String tempsd, tempsf,day;
            DateTime date1;
            while ((reader.Read()) && (trouve == 0))
            {
                id1 = (int)reader["id_act"];
                id2 = id1.ToString();
                if (id2.Equals(txt_id.Text.ToString()))
                {
                    trouve = 1;
                    row = id1;
                    name.Text = reader.GetString(1);
                    location.Text = reader.GetString(7);
                    date1 = reader.GetDateTime(2);
                    day = date1.ToString();
                    dayy.Text = day.Substring(0, 10);
                    dayy.Visible=true;
                    tempsd = reader.GetString(3);
                    tempsf = reader.GetString(8);
                    hd.Text = tempsd.Substring(0, 2);
                    hd.Visible = true;
                    hf.Text = tempsf.Substring(0, 2);
                    hf.Visible = true;
                    md.Text = tempsd.Substring(3, 2);
                    md.Visible = true;
                    mf.Text = tempsf.Substring(3, 2);
                    mf.Visible = true;
                    // n7ot awel 2 lettre min tempsd fi date_d w lettre 4 w 5 fi date_d1 (22:50) --> 22 fi date_d w 50 fi date_d1
                    reccc.Text = reader.GetString(4);
                    reccc.Visible = true;
                    cat = reader.GetString(5);
                    if(cat.Equals("Family"))
                    { R1.Checked = true; R1.BackColor = System.Drawing.Color.Fuchsia; }
                    else if (cat.Equals("Health"))
                    { R2.Checked = true; R2.BackColor = System.Drawing.Color.Fuchsia; }
                    else if (cat.Equals("Hobbies"))
                    { R3.Checked = true; R3.BackColor = System.Drawing.Color.Fuchsia; }
                    else if (cat.Equals("Work"))
                    { R4.Checked = true; R4.BackColor = System.Drawing.Color.Fuchsia; }
                    else
                    { R5.Checked = true; R5.BackColor = System.Drawing.Color.Fuchsia; }
                    break;
                } 
               
               
            }
            if(trouve==0) { MessageBox.Show("No activity found"); }
        }

        private void addWithVoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Voice a = new Voice();
            a.Show();
        }
    }
    }


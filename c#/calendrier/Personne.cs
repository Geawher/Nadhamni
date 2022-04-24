using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendrier1
{
    class Personne
    {
        private String nom;
        private String username;
        private String first_name;
        private char sexe;
        private String password;
        private String occupation;
        private String hobby;
        private DateTime date_naiss;
        private String mail;
        private String situation;
        private int n_kids;

       
        

        public string Nom { get => nom; set => nom = value; }
        public string Username { get => username; set => username = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public char Sexe { get => sexe; set => sexe = value; }
        public string Password { get => password; set => password = value; }
        public string Occupation { get => occupation; set => occupation = value; }
        public string Hobby { get => hobby; set => hobby = value; }
        public DateTime Date_naiss { get => date_naiss; set => date_naiss = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Situation { get => situation; set => situation = value; }
        public int N_kids { get => n_kids; set => n_kids = value; }
    }
}

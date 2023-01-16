using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Informatique_A3
{
    abstract class Personne
    {
        int numero_ss;
        string nom;
        string prenom;
        DateTime date_de_naissance;
        string adresse_postale;
        string adresse_mail;
        string telephone;

        public int Numero_ss
        {
            get { return numero_ss; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
        }

        public DateTime Date_de_naissance
        {
            get { return date_de_naissance; }
        }


        public string Adresse_postale
        {
            get { return adresse_postale; }
            set { adresse_postale = value; }
        }

        public string Ville
        {
            get { return adresse_postale.Split(',')[3]; }
            
        }

        public string Adresse_mail
        {
            get { return adresse_mail; }
            set { adresse_mail = value; }
           
        }

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        




        public Personne(int numero_ss, string nom, string prenom, DateTime date_de_naissance, string adresse_postale, string adresse_mail, string telephone)
        {
            this.numero_ss = numero_ss;
            this.nom = nom;
            this.prenom = prenom;
            this.date_de_naissance = date_de_naissance;
            this.adresse_postale = adresse_postale;
            this.adresse_mail = adresse_mail;
            this.telephone = telephone;
        }





       
    }
}

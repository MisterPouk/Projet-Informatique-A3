using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Informatique_A3
{
    internal class Client : Personne
    {
       
        

        public Client(int numero_ss, string nom, string prenom,
            DateTime date_de_naissance, string adresse_postale, string adresse_mail, string telephone)
            : base(numero_ss, nom, prenom, date_de_naissance, adresse_postale, adresse_mail, telephone)
        {
            
      

        }







        public override string ToString()
        {
            return "Nom : "+ Nom + " Prénom : " + Prenom + " Date de naissance : " + Date_de_naissance;
            
        }







    }
}

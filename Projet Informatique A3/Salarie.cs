using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Informatique_A3
{
    internal class Salarie : Personne
    {

        DateTime date_entree_entreprise;
        string poste;
        int salaire;

        public string Poste
        {
            get { return poste; }
            set { poste = value; }
        }

        public int Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }

        public Salarie(int numero_ss, string nom, string prenom, 
            DateTime date_de_naissance, string adresse_postale, string adresse_mail, string telephone, DateTime date_entree_entreprise, string poste, int salaire)
            : base(numero_ss, nom, prenom,date_de_naissance, adresse_postale, adresse_mail, telephone)
        {

            this.date_entree_entreprise = date_entree_entreprise;
            this.poste = poste;
            this.salaire = salaire;




        }








    }
}

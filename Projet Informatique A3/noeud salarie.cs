using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Informatique_A3
{
    internal class noeud_salarie
    {
        Salarie salarie_entreprise;
        noeud_salarie frere;
        noeud_salarie fils;

        public Salarie Salarie_entreprise
        {
            get { return salarie_entreprise; }
            set { salarie_entreprise = value; }
        }

        public noeud_salarie Frere
        {
            get { return this.frere; }
            set { this.frere = value; }
        }

        public noeud_salarie Fils
        {
            get { return this.fils; }
            set
            {
                this.fils = value;
            }

        }

        public noeud_salarie(Salarie salarie)
        {
            this.salarie_entreprise=salarie;
        }

        public void AjouterFils(Salarie salarie)
        {
            noeud_salarie noeud_salarie = new noeud_salarie(salarie);
            if (this.fils == null) this.fils = noeud_salarie;
            else this.fils.AjouterFrere(noeud_salarie);
            
        }

        public void AjouterFrere(noeud_salarie frere)
        {
            if (this.frere == null) this.frere = frere;
            else this.frere.AjouterFrere(frere);
        }







    }
}

using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Projet_Informatique_A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================");
            Console.WriteLine("Logiciel de gestion Transconnect");
            Console.WriteLine("================================");

            // Initialisation des clients depuis un fichier .txt

            #region Lecture des clients

            List<Client> liste_clients = new List<Client>();

            StreamReader lire = new StreamReader("Clients.txt");
            string ligne = lire.ReadLine();
            

            try
            {
                while (ligne != null)
                {
                    string[] caracteristiques_clients = ligne.Split(';');
                    

                    Client client = new Client(Convert.ToInt32(caracteristiques_clients[0]), caracteristiques_clients[1], caracteristiques_clients[2], DateTime.Parse(caracteristiques_clients[3]), caracteristiques_clients[4], caracteristiques_clients[5], caracteristiques_clients[6]);

                    liste_clients.Add(client);

                    ligne = lire.ReadLine();
                }

                


            }
            catch (Exception exception) /// évite de faire planter le programme 
            {
                Console.WriteLine("L'erreur est : " + exception.Message);
            }


            #endregion


            bool fin = false;

            int selection;

            Console.Clear();


            while(fin != true)
            {
                

                Console.WriteLine("Sélectionnez une option: \n" + "1) Gestion des clients \n" + "9) Quitter le programme \n");

                selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        Afficher_Clients(liste_clients);
                        Supprimer_Client(liste_clients, "Dupond");





                        break;

                    case 9:
                        fin = true;


                        break;
                }


            }

            





















        }












        public static void Afficher_Clients(List<Client> liste_clients)
        {
            Console.WriteLine("Voici la liste des clients de l'enterprise : \n");
            foreach (Client client in liste_clients)
            {
                Console.WriteLine(client.ToString() + "\n --------------------------");
            }
        }

        public static void Supprimer_Client(List<Client> liste_clients, string nom)
        {
            for(int i = 0; i < liste_clients.Count; i++)
            {
                if (liste_clients[i].Nom == nom) liste_clients.Remove(liste_clients[i]);

            }
            
        }

        public static void Ajouter_Client(List<Client> liste_clients)
        {

        }











    }
}
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Projet_Informatique_A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

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
            lire.Close();


            #endregion








            bool fin = false;

            int selection;
            int selection_menu_client;

            string nom_client_supp;

            int numero_ss;
            string nom;
            string prenom;
            DateTime date_de_naissance;
            string adresse_postale;
            string adresse_mail;
            string telephone;

        

            Console.Clear();


            while(fin != true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("==================================");
                Console.WriteLine("=Logiciel de gestion Transconnect=");
                Console.WriteLine("==================================");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Sélectionnez une option: \n" + "1) Gestion des clients \n" + "9) Quitter le programme \n");

                selection = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (selection)
                {
                    case 1:
                        Afficher_Clients(liste_clients);

                        Console.WriteLine("Voulez vous ajouter un client ? \n1) Oui \n2) Non");
                        selection_menu_client = Convert.ToInt32(Console.ReadLine());
                        if(selection_menu_client == 1)
                        {
                            Console.WriteLine("Entrez le numéro de SS du client :");
                            numero_ss = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Entrez le nom du client :");
                            nom = Console.ReadLine();
                            Console.WriteLine("Entrez le prénom du client :");
                            prenom = Console.ReadLine();
                            Console.WriteLine("Entrez la date de naissance du client (Format JJ-MM-AAAA):");
                            date_de_naissance = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Entrez l'adresse du client :");
                            adresse_postale = Console.ReadLine();
                            Console.WriteLine("Entrez l'adresse mail du client :");
                            adresse_mail = Console.ReadLine();
                            Console.WriteLine("Entrez le téléphone du client :");
                            telephone = Console.ReadLine();

                            Ajouter_Client(liste_clients, numero_ss, nom, prenom, date_de_naissance, adresse_postale, adresse_mail,telephone);
                            
                            
                            
                        }


                        Console.Clear();
                        Afficher_Clients(liste_clients);



                        Console.WriteLine("Voulez vous supprimer un client ? \n1) Oui \n2) Non");
                        selection_menu_client = Convert.ToInt32(Console.ReadLine());
                        if(selection_menu_client == 1)
                        {
                            Console.WriteLine("Entrez le nom du client à supprimer :");
                            nom_client_supp = Console.ReadLine();
                            Supprimer_Client(liste_clients, nom_client_supp);
                            
                            
                        }

                        
                        Console.Clear();
                        Afficher_Clients(liste_clients);

                        Console.WriteLine("Voulez vous trier les clients par ordre alphabétique de nom ? \n1) Oui \n2) Non");
                        selection_menu_client = Convert.ToInt32(Console.ReadLine());
                        if (selection_menu_client == 1)
                        {
                            Afficher_Clients_Tri_Nom(liste_clients);


                        }

                        

                        Console.Clear();
                        Afficher_Clients(liste_clients);

                        Console.WriteLine("Voulez vous trier les clients par ordre alphabétique de ville ? \n1) Oui \n2) Non");
                        selection_menu_client = Convert.ToInt32(Console.ReadLine());
                        if (selection_menu_client == 1)
                        {
                            Afficher_Clients_Tri_Ville(liste_clients);


                        }

                        Console.Clear();
                        Afficher_Clients(liste_clients);




                        break;

                    case 9:
                        fin = true;


                        break;
                }


            }
            // Sauvegarde des modifications apportées au clients




            try
            {
                using (StreamWriter writer = new StreamWriter("Clients.txt"))
                {
                    writer.Write(Sauvegarder_Clients(liste_clients));
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }

            








        }












        public static void Afficher_Clients(List<Client> liste_clients)
        {
            Console.WriteLine("Voici la liste des clients de l'enterprise : \n");
            foreach (Client client in liste_clients)
            {
                Console.WriteLine(client.ToString() + "\n--------------------------");
            }
        }

        public static void Supprimer_Client(List<Client> liste_clients, string nom)
        {
            for(int i = 0; i < liste_clients.Count; i++)
            {
                if (liste_clients[i].Nom == nom) liste_clients.Remove(liste_clients[i]);

            }
            
        }

        public static void Ajouter_Client(List<Client> liste_clients,int numero_ss, string nom, string prenom,
            DateTime date_de_naissance, string adresse_postale, string adresse_mail, string telephone)
        {
            Client nouveau_client = new Client(numero_ss,nom,prenom,date_de_naissance,adresse_postale,adresse_mail,telephone);
            liste_clients.Add(nouveau_client);

        }


        public static void Afficher_Clients_Tri_Nom(List<Client> liste_clients)
        {
            liste_clients.Sort();

            Afficher_Clients(liste_clients);
        }

        public static void Afficher_Clients_Tri_Ville(List<Client> liste_clients)
        {
            liste_clients.Sort((x,y) => x.Ville.CompareTo(y.Ville));
            
        }

        public static string Sauvegarder_Clients(List<Client> liste_clients)
        {
            string save = "";

            foreach (Client client in liste_clients)
            {
                save += client.Numero_ss + ";" + client.Nom + ";" + client.Prenom + ";" + client.Date_de_naissance + ";" + client.Adresse_postale + ";" + client.Adresse_mail + ";" + client.Telephone + ";\n";
                
            }
            return save;
        }









    }
}
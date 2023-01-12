using System.Security.Cryptography.X509Certificates;

namespace Projet_Informatique_A3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Logiciel de gestion Transconnect");
            Console.WriteLine("================================");

            // Initialisation des clients depuis un fichier .txt

            


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



            Afficher_Clients(liste_clients);









            



            





        }



        public static void Afficher_Clients(List<Client> liste_clients)
        {
            Console.WriteLine("Voici la liste des clients de l'enterprise : \n");
            foreach (Client client in liste_clients)
            {
                Console.WriteLine(client.ToString() + "\n --------------------------");
            }
        }








    }
}
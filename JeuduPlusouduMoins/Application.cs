using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace JeuduPlusouduMoins
{
    class Application
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("********** JEU DU PLUS OU DU MOINS ***********" + "\n"); 

            //  Instanciation d'une class Random random
            Random random = new Random();
            int randomNumber = random.Next(0, 1000);     //  On défini les bornes entre lequels le nombre aléatoire sera choisit



            Console.WriteLine("Génération du nombre aléatoire...");
            Console.WriteLine("Génération du nombre aléatoire effectué");
            
            int nombreUtilisateur = 0;
            int count = 0;

            // Ajout de la boucle
            do
            {
                Console.WriteLine("\n" + "Saisir un nombre entre 1 et 1000 : ");
                nombreUtilisateur = Int16.Parse(Console.ReadLine());
                if (nombreUtilisateur == randomNumber)
                {
                    Console.WriteLine(nombreUtilisateur + " est le bon chiffre !");
                    Console.WriteLine("\t" + "BRAVO !");
                }
                else if (nombreUtilisateur < randomNumber)
                {
                    Console.WriteLine(nombreUtilisateur + " est trop petit !");
                    count++;
                }
                else if (nombreUtilisateur > randomNumber)
                {
                    Console.WriteLine(nombreUtilisateur + " est trop grand !");
                    count++;
                }
            }
            while (nombreUtilisateur != randomNumber);

            Console.WriteLine("Vous avez trouver le nombre " + "{0}" + " en " + "{1}" + " fois.", randomNumber, count); // Phrase finale



            Console.ReadLine(); // Laisse la console ouverte
        }
    }
}

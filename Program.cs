/**
 * Jeu du nombre caché.
 * L'utilisateur rentre un entier qu'il convient de deviner.
 * Le programme effectue de comparaisons successives pour comparer chaque essai avec la valeur à deviner
 * 
 * Optimisation du programme du nombre caché en module.
 * 
 */

using System;

namespace NombreCache
{
    class Program
    {

        static int saisie(string message)
        {
            int nombre;
            do
            {
                Console.Write(message);//Changement du mot essai par le mot nombre
                nombre = int.Parse(Console.ReadLine());
            } while (nombre < 0 || nombre > 100);
            return nombre;
        }
        static void Main(string[] args)
        {
            int valeur, essai, nbre = 1;
            int borneHaute = 100, borneBasse=0 ;
            int difference;
            int moitieDifference;

            //Contrôle de la valeur saisie pour le nombre caché
            valeur = saisie("Entrer le nombre caché (entre 0 et 100) : ");
            Console.Clear();
            Console.WriteLine("Pour deviner le nombre caché, utilisez la méthode de dichotomie.");
            Console.WriteLine("https://fr.wikipedia.org/wiki/Méthode_de_dichotomie");
            //Saisie du premier essai et contrôle
            essai = saisie("Entrer un essai (entre 0 et 100) : ");

            while (essai != valeur)
            {
                if (essai > valeur)
                {
                    borneHaute = essai;
                    Console.WriteLine(essai + " est plus grand que le nombre caché, essayez entre la moitié de "+borneBasse+" et "+borneHaute+".");
                    difference = borneHaute - borneBasse;
                    moitieDifference = difference/2;
                    Console.WriteLine("Essayez " + (borneBasse + moitieDifference));
                }
                else
                {
                    borneBasse = essai;
                    Console.WriteLine(essai + " est plus petit que le nombre caché.");
                    difference = borneHaute - borneBasse;
                    moitieDifference = difference / 2;
                    Console.WriteLine("Essayez " + (borneBasse + moitieDifference));
                }

                essai = saisie("Entrer un essai (entre 0 et 100) : ");

                nbre += 1;
            }
            Console.Clear();
            Console.WriteLine("Bravo, vous avez trouvé en " + nbre + " fois !");

            Console.ReadLine();
        }
    }
}





using System;

namespace Partie3Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result=0;
            int nbr=0;
            Boolean choix = false;


            String rep;

        

          
            while (!choix ) {
                Console.WriteLine("Voulez vous ajouter un nombre o/n ");
                rep = Console.ReadLine();
                if (rep == "o")
                {

                    Console.WriteLine("Entrer un nombre ");
                    nbr = Int32.Parse(Console.ReadLine());
                    choix = false;
                    result += nbr;
                }
                else
                {
                    choix = true;
                }
            }
           
            Console.WriteLine($"la somme des valeur ajoute est {result} ");



        }
    }
}

using System;
using System.Collections.Immutable;
using System.Linq;

namespace TP3OC_Tirage_du_loto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[7] { 0, 0, 0, 0, 0, 0, 0 };

            Random aleatoire = new Random();
            int entier;

            for (int i = 0; i < 7; i++)
            {
                do
                {
                  entier = aleatoire.Next(49) + 1;
                } while (tab.Contains(entier));

                tab[i] = entier;
            }
            Array.Sort(tab);

            static void afficherTab(int[] tableau)
            {
                foreach(int elem in tableau)
                {
                    Console.WriteLine(elem);
                }
            }

            afficherTab(tab);
        }
    }
}

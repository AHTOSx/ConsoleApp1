using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez la longueur du rectangle :");
            double longueur = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entrez la largeur du rectangle :");
            double largeur = Convert.ToDouble(Console.ReadLine());

            double aire = CalculerAire(longueur, largeur);
            Console.WriteLine("L'aire vaut " + aire);

        }

        static double CalculerAire(double longueur, double largeur)
        {
            return longueur * largeur;
        }

        static double CalculerLongueur(double aire, double largeur)
        {
            return aire / largeur;
        }
    }
}

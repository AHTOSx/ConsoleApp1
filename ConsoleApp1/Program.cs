using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez la longueur du rectangle :");
            double longueurRectangle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entrez la largeur du rectangle :");
            double largeurRectangle = Convert.ToDouble(Console.ReadLine());

            double aireRectangle = CalculerAireRectangle(longueurRectangle, largeurRectangle);
            Console.WriteLine("L'aire du rectangle vaut " + aireRectangle);

            Console.WriteLine("Entrez la longueur de l'hexagone :");
            double longueurHexagone = Convert.ToDouble(Console.ReadLine());

            double aireHexagone = CalculerAireHexagone(longueurHexagone);
            Console.WriteLine("L'aire de l'hexagone vaut " + aireHexagone);

            Console.WriteLine("Entrez le rayon du cercle :");
            double rayonCercle = Convert.ToDouble(Console.ReadLine());

            double aireCercle = CalculerAireCercle(rayonCercle);
            Console.WriteLine("L'aire du cercle vaut " + aireCercle);
        }

        private static double CalculerAireHexagone(double longueurHexagone)
        {
            // Aire de l'hexagone = (3 * √3 * c^2) / 2
            return (3 * Math.Sqrt(3) * Math.Pow(longueurHexagone, 2)) / 2;
        }

        private static double CalculerAireRectangle(double longueurRectangle, double largeurRectangle)
        {
            // Aire du rectangle = longueur x largeur
            return longueurRectangle * largeurRectangle;
        }
        //calcul aire cercle
        private static double CalculerAireCercle(double rayon)
        {
            // Aire du cercle = π * r^2
            return Math.PI * Math.Pow(rayon, 2);
        }
    }
}

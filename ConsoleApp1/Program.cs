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
        }

        static double CalculerAireRectangle(double longueur, double largeur)
        {
            return longueur * largeur;
        }

        static double CalculerAireHexagone(double longueur)
        {
            double aire = ((3 * Math.Sqrt(3)) / 2) * longueur * longueur;
            return aire;
        }
    }
}

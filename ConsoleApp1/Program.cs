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

        private static double CalculerAireHexagone(double longueurHexagone)
        {
            throw new NotImplementedException();
        }

        private static double CalculerAireRectangle(double longueurRectangle, double largeurRectangle)
        {
            throw new NotImplementedException();
        }

        //Calcul de l'aire du rectangle en faisant longueur x largeur
        //longueur
        //largeur
        //Valeur de retour
        static double CalculerAire(double longueur, double largeur)
        {
            
            return longueur * largeur;
        }

       
    }
}

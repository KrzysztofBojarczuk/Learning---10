using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double hits;
                double atBat;
                double battingAverage;

                Console.WriteLine("Wprowadź liczbę udanych odbić zawodnika.");
                hits = int.Parse(Console.ReadLine());

                Console.WriteLine("Wprowadź liczbę wszystkich prób odbicia piłki przez zawodnika.");
                atBat = int.Parse(Console.ReadLine());

                battingAverage = hits / atBat;


                Console.WriteLine($"Skutecznośc odbijania piłki przez zawodnika wynosi {battingAverage}.");
            }
            catch (Exception)
            {
                Console.WriteLine("Wprowadź poprawne dane.");
            }

        }
    }
}

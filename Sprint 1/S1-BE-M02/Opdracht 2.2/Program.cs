using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer Lengte in (m):");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Voer Gewicht in (kg):");
            double kg = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();

            double BMI = kg / (m * m);
            Console.WriteLine("Uw BMI is: " + BMI);
            Console.ReadKey();
        }
    }
}

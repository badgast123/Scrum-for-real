using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_BE_MO3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef de hoogte");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geef de breedte");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geef de lente");
            double l = Convert.ToDouble(Console.ReadLine());

            double inhoud = l * b * h;

            inhoud = Math.Round(inhoud, 2);

            Console.WriteLine("De inhoud van de kubus is " + inhoud + "cm3");
            Console.ReadKey();
        }
    }
}

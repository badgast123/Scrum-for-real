using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer Getal 1 in: ");
            double getal1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Voer Getal 2 in: ");
            double getal2 = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();

            double Berekening1 = getal1 + getal2;
            Console.WriteLine("Getal 1 + Getal 2 = " + Berekening1);
            Console.ReadKey();

            double Berekening2 = getal1 - getal2;
            Console.WriteLine("Getal 1 - Getal 2 = " + Berekening2);
            Console.ReadKey();

            double Berekening3 = getal2 - getal1;
            Console.WriteLine("Getal 2 - Getal 1 = " + Berekening3);
            Console.ReadKey();

            double Berekening4 = getal1 * getal2;
            Console.WriteLine("Getal 1 * Getal 2 = " + Berekening4);
            Console.ReadKey();

            double Berekening5 = getal1 / getal2;
            Console.WriteLine("Getal 1 / Getal 1 = " + Berekening5);
            Console.ReadKey();

            double Berekening6 = getal2 / getal1;
            Console.WriteLine("Getal 2 / Getal 1 = " + Berekening6);
            Console.ReadKey();

            double Berekening7 = getal1 % getal2;
            Console.WriteLine("Getal 1 % Getal 2 = " + Berekening7);
            Console.ReadKey();

            double Berekening8 = getal2 % getal1;
            Console.WriteLine("Getal 2 % Getal 1 = " + Berekening8);
            Console.ReadKey();
        }
    }
}

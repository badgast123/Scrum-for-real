using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef getal 1 op:");
            int Getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef getal 2 op:");
            int Getal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Antwoorden:");
            Console.WriteLine(Getal1 - Getal2);
            Console.WriteLine(Getal2 - Getal1);
            Console.WriteLine(Getal1 * Getal2);
            Console.WriteLine(Getal1 / Getal2);
            Console.WriteLine(Getal2 / Getal1);
            Console.WriteLine(Getal1 % Getal2);
            Console.WriteLine(Getal2 % Getal1);
            Console.ReadLine();
        }
    }
}

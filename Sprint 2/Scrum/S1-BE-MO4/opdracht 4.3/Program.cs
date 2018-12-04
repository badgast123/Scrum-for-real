using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het getal 1, 2, 3 of 4 in:");
            double getal = Convert.ToDouble(Console.ReadLine());
            if (getal > 4)
            {
                Console.WriteLine("Geen geldige waarde");
                Console.ReadKey();
            }
            else if (getal == 1)
            {
                Console.WriteLine("U heeft klaveren");
                Console.ReadKey();
            }
            else if (getal == 2)
            {
                Console.WriteLine("U heeft ruiten");
                Console.ReadKey();
            }
            else if (getal == 3)
            {
                Console.WriteLine("U heeft harten");
                Console.ReadKey();
            }
            else if (getal == 4)
            {
                Console.WriteLine("U heeft schoppen");
                Console.ReadKey();
            }

        }
    }
}

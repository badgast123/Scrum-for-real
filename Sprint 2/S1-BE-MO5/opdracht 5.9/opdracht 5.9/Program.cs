using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            double optel = 0;
            double kwadraat = 0;
            Console.WriteLine("Geef een getal tussen de 10 en 20");
            double getal = Convert.ToDouble(Console.ReadLine());

            while (optel < getal)
            {
                optel = optel + 1;
                kwadraat = optel * optel;
                Console.WriteLine(optel + " het kwadraat hiervan is " +kwadraat );
                Console.ReadLine();

            }
            if (getal == optel)
            {
                Console.WriteLine("done");
                Console.ReadKey();
            }
        }
    }
}

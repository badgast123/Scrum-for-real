﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_4._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("een automorf getal is een getal dat in het kwadraait eindigt op dezelfde cijfers van het getal zelf. 5 is een voorbeeld van een automorf getal, 5 in het kwardaat is 25 en eindigd dus op 5.");
            Console.ReadKey();

            Console.WriteLine("****Voer nu zelf een getal in en zie of het een automorf getal is.****");
            double automorf = Convert.ToDouble(Console.ReadLine());

            double kwadraat = automorf * automorf;
            double lastdigit = (kwadraat % 10);

            if (lastdigit == automorf)
            {
                Console.WriteLine(+automorf + " is een automorf getal want " + automorf + " in het kwadraat = " + kwadraat + " het laatste getal hiervan is " + lastdigit);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(+automorf + " is geen automorf getal want " + automorf + " in het kwadraat = " + kwadraat + " het laatste getal hier van is " + lastdigit);
                Console.ReadKey();
            }
        }
    }
}

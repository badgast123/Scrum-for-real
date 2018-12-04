using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int prijs = 0;
            int Metallic = 0;
            Console.WriteLine("Geef uw naam");
            string naam = Convert.ToString(Console.ReadLine());
            Console.ReadKey();

            Console.WriteLine ( naam + " Geef de standaarprijs ");
            prijs = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            Console.WriteLine("Inclusief Metallic lak komt er 5% bij de standaardprijs op is 1250 + " + prijs + " 26250");
            Console.ReadKey();

            Console.WriteLine("Inclusief leren bekleding komt er 5% bij de standaardprijs op is 1250 + " + prijs + " 27500");
            Console.ReadKey();

            Console.WriteLine("Inclusief automatische schakkeling komt er 1000 euro bij de prijs tot nu toe op is 1000 + " + prijs + " = 28500");
            Console.ReadKey();

            Console.WriteLine("Inclusief 21% BTW bovenop de totaal prijs is 21% * 28500 = 34485");
            Console.ReadKey();

            Console.WriteLine("de totaalprijs word 34485 euro");
            Console.ReadKey();
        }
    }
}
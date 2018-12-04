using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer uw naam in:");
            string Naam = Console.ReadLine();
            Console.WriteLine(Naam);
            Console.Clear();
            Console.WriteLine("Voer de standaardprijs in:");
            int Prijs = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(Prijs);
            Console.Clear();
            Console.WriteLine("Standaardprijs: $25000");
            Console.WriteLine("Metallic lak: +$1250");
            Console.WriteLine("Leren bekleding: +$1250");
            Console.WriteLine("Automatische versnellingsbak: +$1000");
            Console.WriteLine("BTW +21%: +$5985");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Totaalprijs: $34485");
            Console.ReadLine();
        }
    }
}

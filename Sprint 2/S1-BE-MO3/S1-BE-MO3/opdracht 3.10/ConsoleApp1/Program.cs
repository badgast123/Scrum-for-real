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
            double verschil = 0;
            DateTime t = DateTime.Now;

            Console.WriteLine("Geef uw naam:");
            Console.ReadLine();
            
            DateTime n = DateTime.Now;
            verschil = (n - t).TotalSeconds;

            verschil = Math.Round(verschil, 2);

            Console.WriteLine("uw snelheid was " + verschil + " seconden");
            Console.ReadKey();
        }
    }
}

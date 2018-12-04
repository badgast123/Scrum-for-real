using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Opdracht2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer je voornaam in:");
            string Voornaam = (Console.ReadLine());

            DateTime Geboortedatum;
            DateTime today = DateTime.Now;
            Console.WriteLine("Voer je geboortedatum in dd/mm/jjjj");
            Geboortedatum = Convert.ToDateTime(Console.ReadLine()).Date;
            TimeSpan difference = today.Subtract(Geboortedatum); 

            Console.WriteLine(Voornaam + " is " + (difference.Days/365) + " jaar oud ");
            Console.ReadLine();
        }
    }
}

 
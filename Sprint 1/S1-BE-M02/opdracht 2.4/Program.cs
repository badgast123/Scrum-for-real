using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dob;
            DateTime today = DateTime.Now;
            Console.WriteLine("Geef uw naam: ");
            string naam = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Geef uw geboortedatum (dd/mm/jjjj): ");
            dob = Convert.ToDateTime(Console.ReadLine()).Date;

            TimeSpan difference = today.Subtract(dob);
 
            Console.WriteLine( naam+ " is " + difference.Days / 365 + " jaar oud");
            Console.ReadLine();
        }
    }
}

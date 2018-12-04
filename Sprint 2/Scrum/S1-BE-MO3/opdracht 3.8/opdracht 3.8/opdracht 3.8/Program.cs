using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string som;

            Console.WriteLine("Geef uw voornaam");
            string voornaam = Convert.ToString(Console.ReadLine());
            string voorletter = Convert.ToString(voornaam[0]);


            Console.WriteLine("Geef eventuele tussenvoegsels");
            string tussenvoegsel = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Geef uw achternaam");
            string achternaam = Convert.ToString(Console.ReadLine());

            som = voornaam + tussenvoegsel + achternaam;
            int len = som.Length;

            Console.WriteLine("uw username is " + voorletter  + achternaam + + len);
            Console.ReadKey();
        }
    }
}

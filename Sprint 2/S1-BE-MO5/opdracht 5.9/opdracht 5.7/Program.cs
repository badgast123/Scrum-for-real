using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double aantal = 0;
            double dobbel = 0;
            Random rnd = new Random();

            Console.WriteLine("druk op enter om te beginnen!");
            Console.ReadKey();

            while (dobbel < 1000)
            {
                dobbel = dobbel + rnd.Next(1, 6);
                aantal = aantal + 1;
                Console.WriteLine(aantal);
            }
            if (dobbel > 1000)
            {
                Console.WriteLine("het programma heeft " + aantal + " x gegooit");
                Console.ReadKey();
                Console.WriteLine("de uiteindelijke dobbelscore is " + dobbel);
                Console.ReadKey();
            }
        }
    }
}

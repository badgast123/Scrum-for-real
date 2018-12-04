using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_5._22
{
    class Program
    {
        static void Main(string[] args)
        {
            double mil = 0;
            double fib = 0;
            double num2 = 1;
            double num3 = 0;

            Console.WriteLine("druk op een toets");
            Console.ReadKey();

            while (mil <= 4000000) 
            {
                fib = num2 + num3;
                num3 = num2;
                num2 = fib;
                mil= mil + 1;
                mil = fib + fib;

                Console.WriteLine(fib);
                Console.ReadKey();
            }






        }
    }
}

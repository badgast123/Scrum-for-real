using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_5._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers separated by ", "");

            var numbers = Console.ReadLine();
            var splitNumber = numbers.Split(',');
            var maxNumber = splitNumber.Max();
            var minNumber = splitNumber.Min();

            Console.WriteLine(maxNumber);
            Console.WriteLine(minNumber);
            Console.ReadKey();

            
            Console.WriteLine(numbers + "Substring: {0} ", maxNumber);
            Console.ReadKey();
        
        }
    }
}

    
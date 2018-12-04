using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je Gewicht op in KG");
            double Gewicht = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geef je lengte in meters");
            double Lengte = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();
            double BMI =  Gewicht / (Lengte*Lengte);
            Console.WriteLine("Je BMI is:" + BMI);
            Console.ReadLine();
        }
    }
}

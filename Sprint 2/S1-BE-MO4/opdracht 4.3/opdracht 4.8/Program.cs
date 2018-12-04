using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kies uw taal:" + System.Environment.NewLine +
            "1 = Nederlands" + System.Environment.NewLine +
                "2 = Duits" + System.Environment.NewLine +
                "3 = Engels" + System.Environment.NewLine +
                "4 = Frans" + System.Environment.NewLine +
                "5 = Spaans" + System.Environment.NewLine +
                "6 = Twents");
            int keuze = Convert.ToInt32(Console.ReadLine());

            DateTime getMonth = DateTime.Now;

            if (keuze == 1)
            {
                Console.WriteLine("De huidige maand is " + getMonth.ToString("MMMMMMMMMM"));
                Console.ReadKey();

            }
            else if (keuze == 2)
            {
                Console.WriteLine("Der aktuelle Monat is " + getMonth.ToString("MMMMMMMMMM"));
                Console.ReadKey();
            }
            else if (keuze == 3)
            {
                Console.WriteLine("The current month is " + getMonth.ToString("MMMMMMMMMM"));
                Console.ReadKey();
            }
            else if (keuze == 4)
            {
                Console.WriteLine("Le mois en cours est " + getMonth.ToString("MMMMMMMMMM"));
                Console.ReadKey();
            }
            else if (keuze == 5)
            {
                Console.WriteLine("El mes actual es " + getMonth.ToString("MMMMMMMMMM"));
                Console.ReadKey();
            }
            else if (keuze == 6)
            {
                Console.WriteLine("de hoedige moand is " + getMonth.ToString("MMMMMMMMMM"));
                Console.ReadKey();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_4._16
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            DayOfWeek day = DateTime.Now.DayOfWeek;

            if ((day >= DayOfWeek.Monday) && (day <= DayOfWeek.Friday))
            {

                Console.WriteLine(myValue.Year);

                Console.WriteLine(myValue.ToString("MMMMMMMMMMMMMMMMM"));

                Console.WriteLine(myValue.DayOfWeek);

                Console.WriteLine(myValue.Day);

                if (myValue.Year % 4 == 0)
                {
                    Console.WriteLine(+myValue.Year + " is een schikkeljaar");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(+myValue.Year + " is geen schikkeljaar");
                    Console.ReadKey();
                }
                if ((day >= DayOfWeek.Monday) && (day <= DayOfWeek.Friday))
                {
                    Console.WriteLine(day + " is een werkdag");
                    Console.ReadKey();
                }
                var d = DateTime.Now;
                CultureInfo cul = CultureInfo.CurrentCulture;

                var firstDayWeek = cul.Calendar.GetWeekOfYear(
                    d,
                    CalendarWeekRule.FirstDay,
                    DayOfWeek.Monday);

                int weekNum = cul.Calendar.GetWeekOfYear(
                    d,
                    CalendarWeekRule.FirstDay,
                    DayOfWeek.Monday);

                int year = weekNum == 52 && d.Month == 1 ? d.Year - 1 : d.Year;
                Console.WriteLine("Week: {1}", year, weekNum);

                Console.WriteLine(myValue.DayOfYear);

                Console.ReadLine();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(myValue.Year);

                Console.WriteLine(myValue.ToString("MMMMMMMMMMMMMMMMM"));

                Console.WriteLine(myValue.DayOfWeek);

                Console.WriteLine(myValue.Day);

                if (myValue.Year % 4 == 0)
                {
                    Console.WriteLine(+myValue.Year + " is een schikkeljaar");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(+myValue.Year + " is geen schikkeljaar");
                    Console.ReadKey();
                }
                if ((day >= DayOfWeek.Monday) && (day <= DayOfWeek.Friday))
                {
                    Console.WriteLine(day + " is een werkdag");
                    Console.ReadKey();
                }
            }
        }
    }
}

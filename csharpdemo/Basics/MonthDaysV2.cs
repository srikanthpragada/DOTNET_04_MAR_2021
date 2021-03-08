using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class MonthDaysV2
    {
        static void Main(string[] args)
        {
            int month, days;

            Console.Write("Enter Month Number :");
            month = Int32.Parse(Console.ReadLine());

            days = month switch
            {
                2 => 28,
                4 or 6 or 9 or 11 => 30,
                _ => 31
            };

            Console.WriteLine(days);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class MonthDays
    {
        static void Main(string[] args)
        {
            int month, days;

            Console.Write("Enter Month Number :");
            month = Int32.Parse(Console.ReadLine());

            switch (month)
            {
                case 2: days = 28; break;
                case 4:
                case 6:
                case 9:
                case 11: days = 30; break;
                default: days = 31; break;
            }

            Console.WriteLine(days);

        }
    }
}

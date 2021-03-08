using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int year;

            Console.Write("Enter year :");
            year = Int32.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                Console.WriteLine($"{year} is a leap year");
            else
                Console.WriteLine($"{year} is not a leap year");
        }
    }
}

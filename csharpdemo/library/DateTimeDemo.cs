using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Library
{
    class DateTimeDemo
    {
        static void Main(string[] args)
        {
            var sd = DateTime.Parse("01-03-2021");
            var cd = DateTime.Now;
            Console.WriteLine(cd); // cd.ToString()
            var period = cd.Subtract(sd);
            Console.WriteLine(period.Days);
        }
    }
}

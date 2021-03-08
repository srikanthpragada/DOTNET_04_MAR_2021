using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Assignments
{
    class LargestInArray
    {
        static void Main(string[] args)
        {
            int[] marks = { 70, 80, 95, 45, 67, 84, 30, 67, 86, 59 };

            var largest = marks[0];

            foreach (var n in marks)
                if (n > largest)
                    largest = n;

            Console.WriteLine($"Largest = {largest}");


        }
    }
}

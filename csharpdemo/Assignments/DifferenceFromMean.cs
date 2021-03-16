using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Assignments
{
    class DifferenceFromMean
    {
        static void Main(string[] args)
        {
            var a = new int[10];

            var random = new Random();
            var total = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(100);
                total += a[i];
                Console.Write($"{a[i]} ");
            }

            var avg = total / a.Length;
            Console.WriteLine($"\nDifference between value and {avg}");
            foreach(int n in a)
                Console.Write($"{n - avg} ");


        }
    }
}

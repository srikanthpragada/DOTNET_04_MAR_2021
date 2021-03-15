using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.library
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            var a = new int[10];

            var random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(100);
                Console.Write($"{a[i]} ");
            }

            Array.Sort(a);
            Console.WriteLine("\nArray After Sorting");
            foreach (var n in a)
            {
               Console.Write($"{n} ");
            }
            Console.WriteLine($"\nFound 30 at : {Array.BinarySearch(a,30)} ");
        }
    }
}

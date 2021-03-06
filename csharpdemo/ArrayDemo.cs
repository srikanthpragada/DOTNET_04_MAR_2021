using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            int [] a = { 10, 20, 30, 50, 60, 70 };

            foreach (var n in a)
            {
                Console.WriteLine(n);
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Advanced
{
    class AnonymousType
    {
        static void Main(string[] args)
        {
            var p1 = new { X = 10, Y = 20 };
            Console.WriteLine(p1.X);

        }
    }
}

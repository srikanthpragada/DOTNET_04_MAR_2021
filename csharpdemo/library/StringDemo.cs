using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Library
{
    class StringDemo
    {
        static void Main(string[] args)
        {
            var st = "How do you do";
            var s1 = "C#";
            var s2 = "CSharp";

            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1.CompareTo(s2));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Advanced
{
    class ArrayAndDelegate
    {
        static void Main(string[] args)
        {
            string[] names = { "Java", "Python", "C", "C#", "JavaScript" };
            int[] marks = { 98, 56, 78, 85, 67 };

            // var selectedNames = Array.FindAll(names, LongName);
            var selectedNames = Array.FindAll(names, name => name.Length > 4);
            foreach (var n in selectedNames)
                Console.WriteLine(n);

            var selectedMarks = Array.FindAll(marks, m => m > 80);

            foreach (var m in selectedMarks)
                Console.WriteLine(m);

        }

        static bool LongName(string name)
        {
            return name.Length > 4;
        }
    }
}

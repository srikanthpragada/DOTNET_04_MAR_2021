using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Assignments
{
    class LargestName
    {
        static void Main(string[] args)
        {
            var input = "Java,C#, XML, Python,JavaScript,TypeScript";

            var names = input.Split(",");

            var largest = "";
            foreach (var name in names)
            {
                //if (name.CompareTo(largest) > 0)
                //    largest = name;

                if (name.Length > largest.Length)
                    largest = name;
            }

            Console.WriteLine(largest);
        }
    }
}

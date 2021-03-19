using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Library
{
    class SortNames
    {
        static void Main(string[] args)
        {
            var names = new List<String>();

            names.Add("C#");
            names.Add("Java");
            names.Insert(0, "JavaScript");
            names.Add("Python");
            names.Add("Java");

            names.Sort();

            foreach(var name in names)
                Console.WriteLine(name);

        }
    }
}

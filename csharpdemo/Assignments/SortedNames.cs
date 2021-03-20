using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Assignments
{
    class SortedNames
    {
        static void Main(string[] args)
        {
            var names = new SortedSet<string>();

            while(true)
            {
                Console.Write("Enter name [end to stop]:");
                var name = Console.ReadLine();
                if (name == "end")
                    break;

                names.Add(name);
            }

            foreach(var name in names)
                Console.WriteLine(name);
        }
    }
}

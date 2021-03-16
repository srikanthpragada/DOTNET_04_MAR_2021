using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Library
{
    record OnePerson(string Name, int Age)
    {

    }

    class RecordDemo
    {
        static void Main(string[] args)
        {
            var p1 = new OnePerson("Abc", 20);
            var p2 = new OnePerson("Abc", 20);

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.ToString());
            
        }
    }
}

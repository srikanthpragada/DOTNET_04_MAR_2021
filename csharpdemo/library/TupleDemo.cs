using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Library
{
    class TupleDemo
    {
        static void Main(string[] args)
        {
            Tuple<string,int> t = Tuple.Create("Abc", 2);
            Console.WriteLine(t.Item1);
                        
        }
    }
}

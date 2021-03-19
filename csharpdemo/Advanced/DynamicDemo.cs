using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Advanced
{
    class DynamicDemo
    {
        static void Main(string[] args)
        {
            dynamic obj = 100;

            Console.WriteLine(obj.ToUpper());
            
        }
    }
}

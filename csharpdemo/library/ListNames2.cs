using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Library
{
    class ListNames2
    {
        static void Main(string[] args)
        {
            using (var sr = new StreamReader
                (@"d:\classroom\mar4\csharpdemo\Library\names.txt"))
            {
                    foreach (var s in sr.ReadToEnd().Split(","))
                        Console.WriteLine(s.Trim());               
            } // using 
        } // main()
    } // class
}

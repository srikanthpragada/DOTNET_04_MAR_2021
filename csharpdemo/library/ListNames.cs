using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Library
{
    class ListNames
    {
        static void Main(string[] args)
        {
            using (var sr = new StreamReader
                (@"d:\classroom\mar4\csharpdemo\Library\names.txt"))
            {
                while (true)
                {
                    var line = sr.ReadLine();
                    if (line == null) // EOF
                        break;

                    // split line into names
                    foreach (var s in line.Split(","))
                        Console.WriteLine(s.Trim());
                }
            } // using 
        } // main()
    } // class
}

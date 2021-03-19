using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Library
{
    class UnionOfFiles
    {
        static void Main(string[] args)
        {
            var lines = new HashSet<string>();

            var firstLines = File.ReadAllLines(@"d:\classroom\mar4\csharpdemo\library\file1.txt");
            foreach (var line in firstLines)
                lines.Add(line);

            var secondLines = File.ReadAllLines(@"d:\classroom\mar4\csharpdemo\library\file2.txt");
            foreach (var line in secondLines)
                lines.Add(line);


            foreach (var line in lines)
                Console.WriteLine(line);

        }
    }
}

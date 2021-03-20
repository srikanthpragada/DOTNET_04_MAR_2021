using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Assignments
{
    class UniqueWords
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(@"d:\classroom\mar4\csharpdemo\text.txt");

            var sortedWords = new SortedSet<String>();
            foreach(var line in lines)
            {
                var words = line.Split(" ");
                sortedWords.UnionWith(words);
            }

            foreach(var word in sortedWords)
                Console.WriteLine(word);

        }
    }
}

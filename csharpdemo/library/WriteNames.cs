using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Library
{
    class WriteNames
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(@"d:\classroom\mar4\csharpdemo\Library\names.txt");
            var sw = new StreamWriter(@"d:\classroom\mar4\csharpdemo\Library\allnames.txt");
            foreach (var s in sr.ReadToEnd().Split(","))
                        sw.WriteLine(s.Trim());
            sw.Close();
            sr.Close();
        } // main()
    } // class
} // namespace 

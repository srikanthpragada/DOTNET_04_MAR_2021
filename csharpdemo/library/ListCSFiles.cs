using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Library
{
    class ListCSFiles
    {
        static void Main(string[] args)
        {
            try
            {
                var dinfo = new DirectoryInfo(@"d:\classroom\mar\csharpdemo\library");
                foreach (var finfo in dinfo.GetFiles())
                {
                    if (finfo.Name.EndsWith(".cs"))
                        Console.WriteLine(finfo.Name);
                }
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Advanced
{
    class Customer
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
    }

    static class MyExtensionMethods
    {
        // Extension method for Customer class 
        public static void Print(this Customer cust)
        {
            Console.WriteLine(cust.Name);
            Console.WriteLine(cust.Mobile);
        }
    }

    class ExtensionMethods
    {
        static void Main(string[] args)
        {
            var c = new Customer { Name = "Tom", Mobile = "393944334" };
            c.Print();
        }
    }
}

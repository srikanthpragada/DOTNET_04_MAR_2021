using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Library
{
    class DictDemo
    {
        static void Main(string[] args)
        {
            var accounts = new Dictionary<int, string>();

            accounts.Add(1, "Andy");
            accounts.Add(2, "Joe");
            accounts.Add(3, "Scott");

            Console.WriteLine(accounts[2]);
            accounts.Remove(2);

            foreach(var acno in accounts.Keys)
                Console.WriteLine($"{acno}  - {accounts[acno]}");

        }
    }
}

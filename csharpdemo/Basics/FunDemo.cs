using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class FunDemo
    {
        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        static void Wish(string name = "Guest", string message = "Hello")
        {
            Console.WriteLine($"{message} {name}");
        }

        static void Greet(string message, params string[] names)
        {
             foreach(var name in names)
                Console.WriteLine($"{message} {name}");
        }

        static void Main(string[] args)
        {
            //Wish("Scott", "Good Morning!");
            //Wish("Tom");     // Second parameter takes default value 
            //Wish();
            //Wish(message : "Good Bye");  // Named parameter

            //Greet("Hello", "Joe", "Andy");

            int x = 10, y = 20;
            Swap(ref x, ref y);
            Console.WriteLine($"{x}, {y}");
        }

        static void Swap(ref int a, ref int b)
        {
            var t = a;
            a = b;
            b = t; 
        }
    }
}

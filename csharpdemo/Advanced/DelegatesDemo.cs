using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Advanced
{
    delegate void PrintDelegate(string message); // Declare
    class DelegatesDemo
    {
        static void Main(string[] args)
        {
            PrintDelegate d = new PrintDelegate(PrintMessage); // Make it point to a function 
            d("Hello");  // call function through delegate 

            d = Console.WriteLine; // Method group conversion 
            d("Good Morning!");

            // Anonymous function 
            d = delegate (string msg)
            {
                Console.WriteLine("Message : " + msg);
            };

            d("Hellooo");

            // Lambda Expression 
            d = (string message) => Console.WriteLine("Lambda : " + message);
            d("Hi");

        }

        private static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        private static void PrintUpper(string message)
        {
            Console.WriteLine(message.ToUpper());
        }
    }
}

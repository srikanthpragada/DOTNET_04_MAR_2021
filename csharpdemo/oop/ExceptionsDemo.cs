using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.oop
{
    class ExceptionsDemo
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter number :");
            try
            {
                num = Int32.Parse(Console.ReadLine());
                Console.WriteLine(10 / num);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Sorry! Invalid Number!");
            }
            finally
            {
                Console.WriteLine("Finally!");
            }

            Console.WriteLine("Goodbye!");
        }
    }
}

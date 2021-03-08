using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class AverageNumbers
    {
        static void Main(string[] args)
        {
            int sum, count, num;

            count = sum = 0;
            while(true)
            {
                Console.Write("Enter number [0 to stop] : ");
                num = Int32.Parse(Console.ReadLine());
                if (num == 0)
                    break;

                count++;
                sum += num;
            }

            Console.WriteLine($"Average = {sum/count}");
        }
    }
}

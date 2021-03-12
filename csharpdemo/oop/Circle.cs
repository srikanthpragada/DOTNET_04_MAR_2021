using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.oop
{
    class MyCircle
    {
        // Automatically implemented properties 
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; init; }
        
        public double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }
    }

    class TestCircle
    {
        static void Main(string[] args)
        {
            var c = new MyCircle();
            c.X = 10;
            c.Y = 20;
            // c.Radius = 40;

            // Object initializer 
            var c2 = new MyCircle { X = 1, Y = 10, Radius = 10 };
            Console.WriteLine(c2.Area);
           
        }
    }
}

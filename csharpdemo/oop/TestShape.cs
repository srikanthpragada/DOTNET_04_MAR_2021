using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.oop
{
    abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }

        public abstract double Area();

    }

    class Circle : Shape
    {
        public int Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override void Print()
        {
            Console.WriteLine($"X = {X}, Y = {Y}, Radius = {Radius}");
        }
    }

    class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Length { get; set; }

        public override double Area()
        {
            return Width * Length;
        }
        public override void Print()
        {
            Console.WriteLine($"X = {X}, Y = {Y}, Length = {Length}, Width = {Width}");
        }
    }

    class Square : Shape
    {
        public int Side { get; set; }

        public override double Area()
        {
            return Side * Side;
        }

        public override void Print()
        {
            Console.WriteLine($"X = {X}, Y = {Y}, Side = {Side}");
        }
    }


    class TestShape
    {
        static void Main(string[] args)
        {
            Shape s;

            //  s = new Shape { X = 10, Y = 20 };

            s = new Circle { X = 10, Y = 20, Radius = 15 };
            s.Print();  // Runtime Polymorphism 
            Console.WriteLine(s.Area());

            s = new Square { X = 10, Y = 20, Side = 10 };
            s.Print();
            Console.WriteLine(s.Area());
            // Console.WriteLine(10);  // Compile-time polymorphism 
        }
    }
}

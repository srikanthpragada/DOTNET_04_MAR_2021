using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Library
{

    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} - {this.Age}";
        }

        public override bool Equals(object obj)
        {
            Person other = obj as Person; // Downcasting 
            return this.Name == other.Name && this.Age == other.Age;
        }

        public int CompareTo(Person other)
        {
            return this.Age - other.Age;
        }
    }
    class TestPerson
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Abc", Age = 25 };
            Person p2 = new Person { Name = "Abc", Age = 30 };

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.ToString());

            Console.WriteLine(p1.CompareTo(p2));


        }
    }
}

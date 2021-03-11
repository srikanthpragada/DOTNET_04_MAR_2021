using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.oop
{
    class Person
    {
        protected string name, email;
        public Person(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        public virtual void Print()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.email);
        }
    }


    class Employee : Person
    {
        protected string job;
        public Employee(string name, string email, string job) : base(name, email)
        {
            this.job = job;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(this.job);
        }

    }
    class TestPerson
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Scott", "scott@gmail.com", "Programmer");
            e.Print();

        }
    }
}

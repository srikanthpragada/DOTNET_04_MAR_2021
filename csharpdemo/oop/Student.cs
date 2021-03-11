using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.oop
{
    class Student
    {
        private string name, course;
        private int feepaid;
        // class variables
        private static double taxrate = 12.5;

        public string Fullname
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public static double TaxRate
        {
            get
            {
                return taxrate;
            }
        }
        public Student(string name, string course = ".NET", int feepaid = 0)
        {
            this.name = name;
            this.course = course;
            this.feepaid = feepaid;
        }

        public void Print()
        {
            Console.WriteLine($"Name      : {this.name}");
            Console.WriteLine($"Course    : {this.course}");
            Console.WriteLine($"Fee Paid  : {this.feepaid}");
            Console.WriteLine($"Total Fee : {this.TotalFee}");
        }

        public int TotalFee
        {
            get
            {
                int total = 15000;

                if (this.course == ".NET")
                    total = 10000;

                return (int)(total + total * taxrate / 100);
            }
        }
        public int DueAmount
        {
            get
            {
                return TotalFee - this.feepaid;
            }
        }
        public void Payment(int amount)
        {
            if (this.feepaid + amount > TotalFee)
                Console.WriteLine("Excess fee being paid!");
            else
                this.feepaid += amount;
        }
    }

    class TestStudent
    {
        static void Main(string[] args)
        {
            Student s = new Student("Andy", "Java");
            s.Payment(5000);
            s.Print();
            Console.WriteLine(s.DueAmount);

            Console.WriteLine(Student.TaxRate);
        }
    }
}

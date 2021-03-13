using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.oop
{
    abstract class Doctor
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Dept { get; set; }
        public virtual void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Mobile);
            Console.WriteLine(Dept);
        }
        public abstract int GetRemuneration();
    }

    class ResidentDoctor : Doctor
    {
        public int Salary { get; set; }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(Salary);
        }

        public override int GetRemuneration()
        {
            return this.Salary;
        }
    }

    class Consultant : Doctor
    {
        public int Visits { get; set; }
        public int Charge { get; set; }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(Visits);
            Console.WriteLine(Charge);
        }

        public override int GetRemuneration()
        {
            return this.Visits * this.Charge;
        }
    }

    class ConsultantSurgeon : Consultant
    {
        public int Surgeries { get; set; }
        public int SurgeryCharge { get; set; }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(Surgeries);
            Console.WriteLine(SurgeryCharge);
        }

        public override int GetRemuneration()
        {
            return base.GetRemuneration() + this.SurgeryCharge * this.Surgeries;
        }
    }
    class TestDoctor
    {
        static void Main(string[] args)
        {
            Doctor d = new Consultant { Name = "Dr. Andy", Dept = "Ped", Mobile = "292929222", Visits = 20, Charge = 300 };
            //d.Print();
            //Console.WriteLine(d.GetRemuneration());

            //d = new ConsultantSurgeon { Name = "Dr. Tom", Dept = "Neu", Mobile = "292929222", Visits = 20, Charge = 600, Surgeries = 3, SurgeryCharge = 20000 };
            //d.Print();
            //Console.WriteLine(d.GetRemuneration());

            d = new ResidentDoctor { Name = "Dr. Joe", Dept = "Orth", Mobile = "34343434", Salary = 300000 };

            Console.WriteLine(d is ResidentDoctor);
            Console.WriteLine(d is Consultant);
            
            Consultant c = d as Consultant; // Downcasting 
            // c = (Consultant)d;

            Console.WriteLine(c);
        }
    }
}

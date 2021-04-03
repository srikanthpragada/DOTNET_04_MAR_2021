using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoredemo.Model.Sqlite
{
    class AddPeople
    {
        static void Main(string[] args)
        {
            var ctx = new CatalogContext();

            var s1 = new Student{  Name = "student1", Email = "s1@gmail.com", Course = "Java"};
            var s2 = new Student { Name = "student2", Email = "s2@gmail.com", Course = ".NET" };
            var e1 = new Employee { Name = "employee1", Email = "e1@gmail.com", Job = "Prog" };
            var e2 = new Employee { Name = "employee2", Email = "e2@gmail.com", Job = "DBA" };

            ctx.Students.Add(s1);
            ctx.Students.Add(s2);
            ctx.Employees.Add(e1);
            ctx.Employees.Add(e2);

            ctx.SaveChanges();


        }
    }
}

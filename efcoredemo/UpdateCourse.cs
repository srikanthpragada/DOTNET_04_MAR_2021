using efcoredemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoredemo
{
    class UpdateCourse
    {
        static void Main(string[] args)
        {
            var ctx = new CatalogContext();

            var course1 = new Course { Title = "new course", Prereq = "Nothing" };
            Console.WriteLine(ctx.Entry(course1).State); 

            var course = (from c in ctx.Courses
                          where c.Title == "JAVA EE"
                          select c).FirstOrDefault();

            Console.WriteLine(ctx.Entry(course).State); // Unchanged 

            if (course != null)
            {
                course.Prereq = "Java + SQL + HTML"; // Modified 
                Console.WriteLine(ctx.Entry(course).State);
                ctx.SaveChanges();
            }
            else
                Console.WriteLine("Course Not Found!");

        }
    }
}

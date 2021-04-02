using efcoredemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoredemo
{
    class DeleteCourse
    {
        static void Main(string[] args)
        {
            var ctx = new CatalogContext();

            var course = ctx.Courses.Find(2); // Find entity by Primary key 2 

            if (course != null)
            {
                ctx.Courses.Remove(course);
                ctx.SaveChanges();
            }
            else
                Console.WriteLine("Course Not Found!");

        }
    }
}

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
            var ctx = new TrainingContext();

            var course = (from c in ctx.Courses
                          where c.Title == "JAVA EE"
                          select c).FirstOrDefault();

            if (course != null)
            {
                course.Prereq = "Java + SQL";
                ctx.SaveChanges();
            }
            else
                Console.WriteLine("Course Not Found!");

        }
    }
}

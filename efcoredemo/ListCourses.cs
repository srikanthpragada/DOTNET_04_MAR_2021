using efcoredemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoredemo
{
    class ListCourses
    {
        static void Main(string[] args)
        {
            var ctx = new CatalogContext();
            //// Display all courses
            //foreach(var course in ctx.Courses)
            //{
            //    Console.WriteLine($"{course.Title}  - {course.Prereq}");
            //}

            // List courses that contain Java in title using LINQ to Entities 
            var courses = from c in ctx.Courses
                          where c.Title.Contains("Java")
                          select c;

            foreach(var c in courses)
                Console.WriteLine(c.Title);
        }
    }
}

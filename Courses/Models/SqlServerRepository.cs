using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Models
{
    public class SqlServerRepository : ICourseRepository
    {
        public CoursesDbContext Context { get; set; }
        public SqlServerRepository(CoursesDbContext context)
        {
            Context = context;
        }
        public void AddCourse(Course course)
        {
            Context.Courses.Add(course);
            Context.SaveChanges();
        }

        public void DeleteCourse(int id)
        {
            var course = Context.Courses.Find(id);
            Context.Courses.Remove(course);
            Context.SaveChanges();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return Context.Courses;
        }

        public Course GetCourse(int id)
        {
            var course = Context.Courses.Find(id);
            return course;
        }
    }
}

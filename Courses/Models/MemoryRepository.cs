using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Models
{
    public class MemoryRepository : ICourseRepository
    {
        private List<Course> courses = new List<Course> 
           { new Course {  Id = 1, Title = ".NET Core", Duration = 40, Fee = 4500},
             new Course {  Id = 2, Title = "Python Programming", Duration = 36, Fee = 4000},
             new Course {  Id = 3, Title = "Data Science", Duration = 36, Fee = 5000}
           };

        public void AddCourse(Course course)
        {
            this.courses.Add(course);
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return courses; 
        }

        public Course GetCourse(int Id)
        {
            return this.courses.SingleOrDefault(c => c.Id == Id);
        }
    }
}

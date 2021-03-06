using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Models
{
    public class MemoryRepository : ICourseRepository
    {
        private List<Course> courses = new()
           { new Course {  Id = 1, Title = ".NET Core", Duration = 40, Fee = 4500},
             new Course {  Id = 2, Title = "Python Programming", Duration = 36, Fee = 4000},
             new Course {  Id = 3, Title = "Data Science", Duration = 36, Fee = 5000}
           };

        public void AddCourse(Course course)
        {
            // Get max id and add 1 to that 
            var id = GetAllCourses().Max(c => c.Id) + 1;
            course.Id = id;
            this.courses.Add(course);
        }

        public void DeleteCourse(int id)
        {
            var course = GetCourse(id);
            this.courses.Remove(course);
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

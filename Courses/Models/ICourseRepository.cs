using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Models
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAllCourses();
        Course GetCourse(int id);
        void AddCourse(Course course);

        void DeleteCourse(int id);
    }
}

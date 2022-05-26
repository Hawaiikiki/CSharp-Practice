using Day6School.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6School.Repository
{
    public interface ICourseService
    {
        public List<Student> GetStudents(Course course)
        {
            return course.StudentsEnrolled;
        }
    }
}

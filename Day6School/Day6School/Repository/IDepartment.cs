using Day6School.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6School.Repository
{
    public interface IDepartment
    {
        public Instructor GetHead(Department dept)
        {
            return dept.Head;
        }
        public decimal GetBudget(Department dept)
        {
            return dept.Budget;
        }
        public List<Course> GetCourse(Department dept)
        {
            return dept.Courses;
        }
    }
}

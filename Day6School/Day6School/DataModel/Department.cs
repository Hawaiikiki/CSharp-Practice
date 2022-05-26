using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6School.DataModel
{
    public class Department
    {
        public Instructor Head { get; set; }
        public decimal Budget { get; set; }
        public List<Course> Courses { get; set; }
    }
}

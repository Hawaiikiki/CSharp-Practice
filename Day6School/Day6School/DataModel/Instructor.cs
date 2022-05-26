using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6School.DataModel
{
    public class Instructor:Person
    {
        public string Department { get; set; }
        public DateTime JoinDate { get; set; }

    }
}

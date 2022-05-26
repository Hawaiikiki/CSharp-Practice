using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6School.DataModel
{
    public class Student:Person
    {
        public Dictionary<string,string> Course { get; set; }

    }
}

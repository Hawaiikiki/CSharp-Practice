using Day6School.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6School.Repository
{
    public interface IStudentService:IPersonService<Student>
    {
        int GetAge(Student stu);
        string GetName(Student stu);
        decimal GetSalary(Student stu);
        List<string> GetAddress(Student stu);
        double GetGPA(Student stu)
        {
            double gpaTotal= 0;
            int length = stu.Course.Count;
            foreach(string gpa in stu.Course.Values)
            {
                switch (gpa)
                {
                    case "F": { gpaTotal += 0.7; break; }
                    case "E": { gpaTotal += 1.3; break; }
                    case "D": { gpaTotal += 2.0; break; }
                    case "C": { gpaTotal += 2.7; break; }
                    case "B": { gpaTotal += 3.3; break; }
                    case "A": { gpaTotal += 4.0; break; }
                    default: { gpaTotal += 0; break; }
                }
                
            }
            return gpaTotal / (double)length;
        }

    }
}

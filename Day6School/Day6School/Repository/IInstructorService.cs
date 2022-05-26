using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day6School.DataModel;

namespace Day6School.Repository
{
    public interface IInstructorService: IPersonService<Instructor>
    {
        int GetAge(Instructor inst)
        {
            return inst.Age;
        } 
        string GetName(Instructor inst)
        {
            return inst.Name;
        }
        int YOE(Instructor inst)
        {
            return (DateTime.Today.Year-inst.JoinDate.Year);
        }

        decimal GetSalary(Instructor inst)
        {
            return inst.Salary + (decimal)(YOE(inst) * 7000);
           
        }
        List<string> GetAddress(Instructor inst)
        {
            return inst.Address;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6School.Repository
{
    public interface IPersonService<T> where T: class
    {
        // abstract and public by default
        int GetAge(T obj); // return type is integer because if successful it will return 1
        string GetName(T obj);
        decimal GetSalary(T obj);
        List<string> GetAddress(T obj);

    }
}

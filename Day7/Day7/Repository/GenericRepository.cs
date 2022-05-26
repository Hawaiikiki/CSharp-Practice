using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        List<T> genericRepo;
        readonly IRepository<T> repository;
        public GenericRepository()
        {
            repository = this;
            genericRepo = new List<T>();
        }   

        public void Add(T item)
        {
            genericRepo.Add(item); 
        }

        public void Remove(T item)
        {
            genericRepo.Remove(item);
        }

        public void Save() // not sure what we are supposed to implement for this method
        {
            Console.WriteLine("Generic Repo saved");
        }

        public IEnumerable<T> GetAll()
        {
            List<T> list = new List<T>();
            foreach (T item in genericRepo)
            {
                list.Add(item);
            }
            return list;
        }

        public T GetById(int id)
        {
            return genericRepo[id];
        }
    }
}

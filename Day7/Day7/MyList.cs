using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class MyList<T> : List<T>
    {
        private IList<T> listData;
        public MyList()
        {
            listData = new List<T>();
        }
        public void Add(T obj)
        {
            listData.Add(obj);
        }
        public T Remove(int index)
        {
            T res = listData[index];
            listData.RemoveAt(index);
            return res;
        }

        public bool Contains(T obj)
        {
            return listData.Contains(obj);
        }
        public void Clear()
        {
            listData.Clear();
        }
        public void InsertAt(T obj, int index)
        {
            listData.Insert(index, obj);
        }
        public void DeleteAt(int index)
        {
            listData.RemoveAt(index);
        }
        public T Find(int index)
        {
            return listData[index];
        }

        public void GetAll()
        {
            foreach(T obj in listData)
            {
                Console.Write(obj+" ");
            }
            Console.WriteLine();
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class MyStack<T>: Stack<T> // last in first out
    {
        private IList<T> stackData;
        public MyStack()
        {
            stackData = new List<T>();
        }



        public int Count()
        {
            int cnt = 0;
            foreach(T item in this)
            {
                cnt++;
            }

            return cnt;
        }



        public T Pop()
        {
            int size = this.Count();
            Console.WriteLine("popped");
            return stackData[size-1];
            
        }

        public void Push(T obj)
        {
            stackData.Add(obj);
            Console.WriteLine("added to stack");
        }
        public void Get()
        {
            Console.WriteLine(stackData.Count());
        }
    }
}

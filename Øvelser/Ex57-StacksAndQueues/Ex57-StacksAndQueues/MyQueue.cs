using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex57_StacksAndQueues
{
    public class MyQueue<T>
    {
        private List<T> myList = new List<T>();

        public MyQueue()
        {
           
        }

        public void Enqueue(T item)
        {
            myList.Add(item);
        }

        public T Dequeue()
        {
            T item = myList[0];
            myList.RemoveAt(0);
            return item;
        }

        public int Count()
        {
            return myList.Count;
        }

        public Boolean IsEmpty()
        {
            if (myList.Count == 0)
            {
                return true;
            }
            else return false;
        }
    }

}

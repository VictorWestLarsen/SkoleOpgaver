using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex57_StacksAndQueues
{

    public class MyStack<T>
    {
        private List<T> myStack = new List<T>();

        public MyStack()
        {
        }

        public void Push(T item)
        {
            myStack.Insert(0, item);
        }

        public T Pop()
        {
            T item = myStack[0];
            myStack.RemoveAt(0);
            return item;
        }

         public T Peek()
         {
            return myStack[0];

         }

         public int Count()
         {
            return myStack.Count;
         }

         public Boolean IsEmpty()
         {
            if (myStack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
         }
    }

}

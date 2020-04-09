using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex52_DesignPatterns
{
    public class MyLinkedList<T> : IEnumerable<T>
    {
        public IEnumerator GetEnumerator()
        {
            return new MyLinkedListEnumerator(head);
        }
        private class MyLinkedListEnumerator : IEnumerator
        {

            private Node _head;
            private Node _current;

            public MyLinkedListEnumerator(Node head)
            {
                _head = head;
                _current = null;
            }

            public bool MoveNext()
            {

                if(_current == null)
                {
                    _current = _head;
                    return true;
                }
                else if(_current.Next != null)
                {
                    _current = _current.Next;
                    return true;
                }
                return false;
                
            }

            public T Current
            {
                get
                {
                    return _current.Data;
                }
            }
            object IEnumerator.Current => Current;

            public void Reset()
            {
                _current = null;
            }

        }
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }

            public Node(T data)
            {
                Data = data;
            }
        }

        private Node head;

        public int Count { get; private set; } = 0;
        public T First
        {
            get { return ItemAt(0); }
        }
        public T Last
        {
            get { return ItemAt(Count - 1); }
        }
        public void Insert(T data, int index = 0)
        {
            Node n = new Node(data);

            if (index > Count)
                index = Count;

            if (Count == 0 || index < 1)
            {
                n.Next = head;
                head = n;
            }
            else
            {
                Node position = head;
                for (int i = 0; i < index - 1; i++)
                {
                    position = position.Next;
                }
                n.Next = position.Next;
                position.Next = n;
            }

            Count++;
        }
        public void Append(T data)
        {
            Insert(data, Count);
        }

        public void Delete(int index = 0)
        {
            if (Count > 0)
            {
                if (index > Count)
                    index = Count;

                if (index < 1)
                    head = head.Next;
                else
                {
                    Node position = head;
                    for (int i = 0; i < index - 1; i++)
                    {
                        position = position.Next;
                    }
                    position.Next = position.Next.Next;
                }

                Count--;
            }
        }

        public T ItemAt(int index)
        {
            T result = default(T);
            if (index < Count && index >= 0)
            {
                Node position = head;
                for (int i = 0; i < index; i++)
                {
                    position = position.Next;
                }
                result = position.Data;
            }
            return result;
        }
        public override string ToString()
        {
            string result = "";
            Node pointernode = head;
            while (pointernode != null)
            {
                result = result + pointernode.Data.ToString() + "\n";

                pointernode = pointernode.Next;
            }
            return result;
        }

        public void Sort()
        {

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex60ExtensionMethods;
using System.Collections;

namespace Ex60ExtensionMethods
{
    public static class ListExtension
    {
        public static void ForEach<T>(this MyLinkedList<T> linkedList, Action<T> listAction) where T : IComparable<T>
        {
            foreach (T item in linkedList)
            {
                listAction(item);
            }
        }
    }
}

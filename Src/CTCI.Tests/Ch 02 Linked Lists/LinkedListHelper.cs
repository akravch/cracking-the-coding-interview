using System.Collections.Generic;

namespace CTCI.Tests.Ch_02_Linked_Lists
{
    public static class LinkedListHelper
    {
        public static CTCI.Ch_02_Linked_Lists.LinkedListNode<T> FromCollection<T>(IEnumerable<T> collection)
        {
            CTCI.Ch_02_Linked_Lists.LinkedListNode<T> head = null;
            CTCI.Ch_02_Linked_Lists.LinkedListNode<T> previous = null;

            foreach (var item in collection)
            {
                var current = new CTCI.Ch_02_Linked_Lists.LinkedListNode<T>(item);

                if (previous != null)
                {
                    previous.Next = current;
                }

                previous = current;
                head ??= current;
            }

            return head;
        }

        public static List<T> ToList<T>(CTCI.Ch_02_Linked_Lists.LinkedListNode<T> head)
        {
            var list = new List<T>();
            var current = head;

            while (current != null)
            {
                list.Add(current.Value);
                current = current.Next;
            }

            return list;
        }
    }
}
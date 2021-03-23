using System.Collections.Generic;

namespace CTCI.Ch_02_Linked_Lists.Task_01_Delete_Duplicates
{
    public class DeleteDuplicates
    {
        public LinkedListNode<int> Delete1(LinkedListNode<int> head)
        {
            var hashSet = new HashSet<int>();
            var current = head;

            while (current != null)
            {
                hashSet.Add(current.Value);
                current = current.Next;
            }

            LinkedListNode<int> uniqueHead = null;
            LinkedListNode<int> previous = null;

            foreach (var item in hashSet)
            {
                var uniqueCurrent = new LinkedListNode<int>(item);

                if (previous != null)
                {
                    previous.Next = uniqueCurrent;
                }

                previous = uniqueCurrent;
                uniqueHead ??= uniqueCurrent;
            }

            return uniqueHead;
        }

        public LinkedListNode<int> Delete2(LinkedListNode<int> head)
        {
            var current = head;

            while (current != null)
            {
                DeleteDuplicatesAhead(current);
                current = current.Next;

            }

            return head;
        }

        private static void DeleteDuplicatesAhead(LinkedListNode<int> head)
        {
            var value = head.Value;
            var previous = head;
            var current = head.Next;

            while (current != null)
            {
                if (current.Value == value)
                {
                    previous.Next = current.Next;
                }
                else
                {
                    previous = current;
                }

                current = current.Next;
            }
        }
    }
}
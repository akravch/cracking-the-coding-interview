using System.Collections.Generic;

namespace CTCI.Ch_02_Linked_Lists.Task_02_Index_from_End
{
    public class IndexFromEnd
    {
        public LinkedListNode<int> ElementByIndexFromEnd1(LinkedListNode<int> head, int index)
        {
            var count = 0;
            var current = head;

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            var indexFromStart = count - index - 1;
            var node = head;

            for (var i = 0; i < indexFromStart; i++)
            {
                node = node.Next;
            }

            return node;
        }

        public LinkedListNode<int> ElementByIndexFromEnd2(LinkedListNode<int> head, int index)
        {
            var current = head;
            var orderedNodes = new List<LinkedListNode<int>>();

            while (current != null)
            {
                orderedNodes.Add(current);
                current = current.Next;
            }

            var indexFromStart = orderedNodes.Count - index - 1;
            return orderedNodes[indexFromStart];
        }
    }
}
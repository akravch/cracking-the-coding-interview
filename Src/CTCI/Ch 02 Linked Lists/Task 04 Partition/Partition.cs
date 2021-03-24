namespace CTCI.Ch_02_Linked_Lists.Task_04_Partition
{
    public class Partition
    {
        public LinkedListNode<int> PartitionAround(LinkedListNode<int> head, int around)
        {
            LinkedListNode<int> lesserListHead = null;
            LinkedListNode<int> lesserListTail = null;

            LinkedListNode<int> largerListHead = null;
            LinkedListNode<int> largerListTail = null;

            var currentHead = head;

            while (currentHead != null)
            {
                var currentNode = currentHead;

                currentHead = currentHead.Next;
                currentNode.Next = null;

                if (currentNode.Value < around)
                {
                    if (lesserListTail != null)
                    {
                        lesserListTail.Next = currentNode;
                    }

                    lesserListHead ??= currentNode;
                    lesserListTail = currentNode;
                }
                else
                {
                    if (largerListTail != null)
                    {
                        largerListTail.Next = currentNode;
                    }

                    largerListHead ??= currentNode;
                    largerListTail = currentNode;
                }
            }

            if (lesserListTail == null)
            {
                return largerListHead;
            }

            lesserListTail.Next = largerListHead;

            return lesserListHead;
        }
    }
}
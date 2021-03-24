namespace CTCI.Ch_02_Linked_Lists.Task_03_Delete_Node
{
    public class DeleteNode
    {
        public void Delete1(LinkedListNode<int> head, LinkedListNode<int> node)
        {
            var previous = head;
            var current = previous.Next;

            while (current != null)
            {
                if (current == node)
                {
                    previous.Next = current.Next;
                    break;
                }

                previous = current;
                current = current.Next;
            }
        }

        public void Delete2(LinkedListNode<int> head, LinkedListNode<int> node)
        {
            var next = node.Next;
            node.Value = next.Value;
            node.Next = next.Next;
        }
    }
}
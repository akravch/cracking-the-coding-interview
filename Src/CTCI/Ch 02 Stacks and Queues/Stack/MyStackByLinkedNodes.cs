namespace CTCI.Ch_02_Stacks_and_Queues.Stack
{
    public class MyStackByLinkedNodes<T> : IStack<T>
    {
        private sealed class Node
        {
            public readonly T Value;
            public readonly Node Next;

            public Node(T value, Node next)
            {
                Value = value;
                Next = next;
            }
        }

        private Node _head;

        public int Count { get; private set; }

        public void Push(T item)
        {
            _head = new Node(item, _head);
            Count++;
        }

        public T Pop()
        {
            var item = _head;
            _head = _head.Next;
            Count--;
            return item.Value;
        }

        public T Peek()
        {
            return _head.Value;
        }
    }
}
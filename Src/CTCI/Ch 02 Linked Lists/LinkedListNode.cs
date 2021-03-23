namespace CTCI.Ch_02_Linked_Lists
{
    public class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T value, LinkedListNode<T> next = null)
        {
            Value = value;
            Next = next;
        }
    }

    public class DoubleLinkedListNode<T>
    {
        public T Value { get; set; }
        public DoubleLinkedListNode<T> Previous { get; set; }
        public DoubleLinkedListNode<T> Next { get; set; }

        public DoubleLinkedListNode(
            T value,
            DoubleLinkedListNode<T> previous = null,
            DoubleLinkedListNode<T> next = null)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }
    }
}
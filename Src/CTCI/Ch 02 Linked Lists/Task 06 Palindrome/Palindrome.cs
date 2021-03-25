namespace CTCI.Ch_02_Linked_Lists.Task_06_Palindrome
{
    public class Palindrome
    {
        public bool IsPalindrome1(LinkedListNode<char> head)
        {
            LinkedListNode<char> reversedHead = null;
            var current = head;
            var length = 0;

            while (current != null)
            {
                var newReversedHead = new LinkedListNode<char>(current.Value, reversedHead);
                reversedHead = newReversedHead;
                current = current.Next;
                length++;
            }

            var currentForward = head;
            var currentBack = reversedHead;
            var currentIteration = 0;

            while (currentForward != null && currentBack != null && currentIteration < length / 2)
            {
                if (currentForward.Value != currentBack.Value)
                {
                    return false;
                }

                currentForward = currentForward.Next;
                currentBack = currentBack.Next;
                currentIteration++;
            }

            return true;
        }

        public bool IsPalindrome2(LinkedListNode<char> head)
        {
            var length = GetLength(head);
            var current = head;

            for (var i = 0; i < length / 2; i++)
            {
                var currentFromEnd = GetElementAt(head, length - i - 1);

                if (current.Value != currentFromEnd)
                {
                    return false;
                }

                current = current.Next;
            }

            return true;
        }

        public bool IsPalindrome3(LinkedListNode<char> head)
        {
            var length = GetLength(head);
            var result =  IsPalindromeRecursive(head, length - 1);

            return result.Success;
        }

        private static RecursiveResult IsPalindromeRecursive(LinkedListNode<char> head, int length)
        {
            if (length == 0)
            {
                return new RecursiveResult(true, head.Next);
            }

            if (length == 1)
            {
                return new RecursiveResult(head.Value == head.Next.Value, head.Next.Next);
            }

            var result = IsPalindromeRecursive(head.Next, length - 2);

            if (!result.Success)
            {
                return new RecursiveResult(false, null);
            }

            if (head.Value != result.Node.Value)
            {
                return new RecursiveResult(false, null);
            }

            return new RecursiveResult(true, result.Node.Next);
        }

        private readonly struct RecursiveResult
        {
            public readonly bool Success;
            public readonly LinkedListNode<char> Node;

            public RecursiveResult(bool success, LinkedListNode<char> node)
            {
                Success = success;
                Node = node;
            }
        }

        private static int GetLength(LinkedListNode<char> head)
        {
            var length = 0;
            var current = head;

            while (current != null)
            {
                length++;
                current = current.Next;
            }

            return length;
        }

        private static char GetElementAt(LinkedListNode<char> head, int index)
        {
            var current = head;

            for (var i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Value;
        }
    }
}
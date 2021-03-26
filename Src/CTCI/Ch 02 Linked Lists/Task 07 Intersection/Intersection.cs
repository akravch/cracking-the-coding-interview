using System;
using System.Collections.Generic;

namespace CTCI.Ch_02_Linked_Lists.Task_07_Intersection
{
    public class Intersection
    {
        public LinkedListNode<int> GetIntersectionNode1(LinkedListNode<int> firstHead, LinkedListNode<int> secondHead)
        {
            var firstResult = GetIterationResult(firstHead);
            var secondResult = GetIterationResult(secondHead);

            if (firstResult.Last != secondResult.Last)
            {
                return null;
            }

            LinkedListNode<int> longerHead;
            LinkedListNode<int> shorterHead;

            if (firstResult.Length > secondResult.Length)
            {
                longerHead = firstHead;
                shorterHead = secondHead;
            }
            else
            {
                longerHead = secondHead;
                shorterHead = firstHead;
            }

            var lengthDiff = Math.Abs(firstResult.Length - secondResult.Length);

            var currentLonger = longerHead;
            var currentShorter = shorterHead;

            for (var i = 0; i < lengthDiff; i++)
            {
                currentLonger = currentLonger.Next;
            }

            while (currentLonger != currentShorter)
            {
                currentLonger = currentLonger.Next;
                currentShorter = currentShorter.Next;
            }

            return currentLonger;
        }

        public LinkedListNode<int> GetIntersectionNode2(LinkedListNode<int> firstHead, LinkedListNode<int> secondHead)
        {
            if (firstHead == secondHead)
            {
                return firstHead;
            }

            var firstStack = ToStack(firstHead);
            var secondStack = ToStack(secondHead);

            if (firstStack.Peek() != secondStack.Peek())
            {
                return null;
            }

            var firstCurrentTail = firstStack.Pop();
            var secondCurrentTail = secondStack.Pop();

            if (firstCurrentTail != secondCurrentTail)
            {
                return null;
            }

            while (firstCurrentTail == secondCurrentTail &&
                   firstStack.Count > 0 &&
                   secondStack.Count > 0)
            {
                firstCurrentTail = firstStack.Pop();
                secondCurrentTail = secondStack.Pop();
            }

            return firstCurrentTail.Next;
        }

        private static IterationResult GetIterationResult(LinkedListNode<int> head)
        {
            LinkedListNode<int> last = null;
            var current = head;
            var length = 0;

            while (current != null)
            {
                length++;
                last = current;
                current = current.Next;
            }

            return new IterationResult(last, length);
        }

        private readonly struct IterationResult
        {
            public readonly LinkedListNode<int> Last;
            public readonly int Length;

            public IterationResult(LinkedListNode<int> last, int length)
            {
                Last = last;
                Length = length;
            }
        }

        private static Stack<LinkedListNode<int>> ToStack(LinkedListNode<int> head)
        {
            var stack = new Stack<LinkedListNode<int>>();
            var current = head;

            while (current != null)
            {
                stack.Push(current);
                current = current.Next;
            }

            return stack;
        }
    }
}
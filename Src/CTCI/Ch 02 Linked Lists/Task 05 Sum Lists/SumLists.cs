using System;

namespace CTCI.Ch_02_Linked_Lists.Task_05_Sum_Lists
{
    public class SumLists
    {
        public LinkedListNode<int> SumReversed(LinkedListNode<int> first, LinkedListNode<int> second)
        {
            LinkedListNode<int> sumHead = null;
            LinkedListNode<int> sumTail = null;

            var firstCurrent = first;
            var secondCurrent = second;
            var carry = 0;

            while (firstCurrent != null && secondCurrent != null)
            {
                var sum = firstCurrent.Value + secondCurrent.Value + carry;
                carry = 0;

                if (sum > 9)
                {
                    sum -= 10;
                    carry = 1;
                }

                var sumNode = new LinkedListNode<int>(sum);

                sumHead ??= sumNode;

                if (sumTail != null)
                {
                    sumTail.Next = sumNode;
                }

                sumTail = sumNode;

                firstCurrent = firstCurrent.Next;
                secondCurrent = secondCurrent.Next;
            }

            LinkedListNode<int> current = null;

            if (firstCurrent != null)
            {
                current = firstCurrent;
            }
            else if (secondCurrent != null)
            {
                current = secondCurrent;
            }

            while (current != null)
            {
                var sum = current.Value + carry;
                carry = 0;

                if (sum > 9)
                {
                    sum -= 10;
                    carry = 1;
                }

                var sumNode = new LinkedListNode<int>(sum);

                sumTail.Next = sumNode;
                sumTail = sumNode;

                current = current.Next;
            }

            if (carry != 0)
            {
                sumTail.Next = new LinkedListNode<int>(carry);
            }

            return sumHead;
        }

        public LinkedListNode<int> SumStraight(LinkedListNode<int> first, LinkedListNode<int> second)
        {
            // Align the decimals
            var firstLength = GetLength(first);
            var secondLength = GetLength(second);

            LinkedListNode<int> longerHead;
            LinkedListNode<int> shorterHead;

            if (firstLength > secondLength)
            {
                longerHead = first;
                shorterHead = second;
            }
            else
            {
                longerHead = second;
                shorterHead = first;
            }

            // Skip the required number of decimal places
            var decimalsToSkip = Math.Abs(firstLength - secondLength);

            LinkedListNode<int> sumHead = null;
            LinkedListNode<int> sumTail = null;

            var currentLonger = longerHead;
            var currentShorter = shorterHead;

            // Start building a reversed linked list
            LinkedListNode<ReversedPair> reversedHead = null;

            for (var i = 0; i < decimalsToSkip; i++)
            {
                var sumNode = new LinkedListNode<int>(currentLonger.Value);

                sumHead ??= sumNode;

                if (sumTail != null)
                {
                    sumTail.Next = sumNode;
                }

                sumTail = sumNode;
                currentLonger = currentLonger.Next;

                var reversedPair = new ReversedPair(sumNode, hasCarry: false);
                var newReversedHead = new LinkedListNode<ReversedPair>(reversedPair, reversedHead);
                reversedHead = newReversedHead;
            }

            // Calculate a happy-path sum without carries, but mark them in the reversed list
            while (currentLonger != null && currentShorter != null)
            {
                var sum = currentLonger.Value + currentShorter.Value;
                var hasCarry = false;

                if (sum > 9)
                {
                    sum -= 10;
                    hasCarry = true;
                }

                var sumNode = new LinkedListNode<int>(sum);

                sumHead ??= sumNode;

                if (sumTail != null)
                {
                    sumTail.Next = sumNode;
                }

                sumTail = sumNode;

                var reversedPair = new ReversedPair(sumNode, hasCarry);
                var newReversedHead = new LinkedListNode<ReversedPair>(reversedPair, reversedHead);
                reversedHead = newReversedHead;

                currentLonger = currentLonger.Next;
                currentShorter = currentShorter.Next;
            }

            // Apply carries using the reversed list
            var currentReversedNode = reversedHead;
            var applyCarry = false;

            while (currentReversedNode != null)
            {
                var pair = currentReversedNode.Value;

                if (applyCarry)
                {
                    var node = pair.Node;
                    var newValue = node.Value + 1;

                    if (newValue > 9)
                    {
                        newValue -= 10;
                    }
                    else
                    {
                        applyCarry = false;
                    }

                    node.Value = newValue;
                }

                if (pair.HasCarry)
                {
                    applyCarry = true;
                }

                currentReversedNode = currentReversedNode.Next;
            }

            // Add an additional decimal place at the beginning if needed
            if (applyCarry)
            {
                sumHead = new LinkedListNode<int>(1, sumHead);
            }

            return sumHead;
        }

        private sealed class ReversedPair
        {
            public ReversedPair(LinkedListNode<int> node, bool hasCarry)
            {
                Node = node;
                HasCarry = hasCarry;
            }

            public LinkedListNode<int> Node { get; }
            public bool HasCarry { get; }
        }

        private static int GetLength(LinkedListNode<int> head)
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
    }
}
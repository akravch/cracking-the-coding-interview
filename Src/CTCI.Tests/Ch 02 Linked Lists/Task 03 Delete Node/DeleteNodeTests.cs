using System.Collections.Generic;
using CTCI.Ch_02_Linked_Lists.Task_03_Delete_Node;
using Xunit;

namespace CTCI.Tests.Ch_02_Linked_Lists.Task_03_Delete_Node
{
    public class DeleteNodeTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void Delete1(int[] input, int node, int[] expected)
        {
            var solution = new DeleteNode();
            var linkedListHead = LinkedListHelper.FromCollection(input);
            var linkedListNode = FindByValue(linkedListHead, node);

            solution.Delete1(linkedListHead, linkedListNode);

            Assert.Equal(expected, LinkedListHelper.ToList(linkedListHead));
        }

        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void Delete2(int[] input, int node, int[] expected)
        {
            var solution = new DeleteNode();
            var linkedListHead = LinkedListHelper.FromCollection(input);
            var linkedListNode = FindByValue(linkedListHead, node);

            solution.Delete2(linkedListHead, linkedListNode);

            Assert.Equal(expected, LinkedListHelper.ToList(linkedListHead));
        }

        public static IEnumerable<object[]> GetTestCases()
        {
            var input1 = new[] { 1, 2, 3, 4, 5, 6 };
            var node1 = 3;
            var expected1 = new[] { 1, 2, 4, 5, 6 };

            yield return new object[] { input1, node1, expected1 };
        }

        private static CTCI.Ch_02_Linked_Lists.LinkedListNode<int> FindByValue(CTCI.Ch_02_Linked_Lists.LinkedListNode<int> head, int value)
        {
            var current = head;

            while (current != null)
            {
                if (current.Value == value)
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }
    }
}
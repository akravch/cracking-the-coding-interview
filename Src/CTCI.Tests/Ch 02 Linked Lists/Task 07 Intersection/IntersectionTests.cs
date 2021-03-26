using System.Collections.Generic;
using CTCI.Ch_02_Linked_Lists.Task_07_Intersection;
using Xunit;

namespace CTCI.Tests.Ch_02_Linked_Lists.Task_07_Intersection
{
    public class IntersectionTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void GetIntersectionNode1(
            CTCI.Ch_02_Linked_Lists.LinkedListNode<int> firstHead,
            CTCI.Ch_02_Linked_Lists.LinkedListNode<int> secondHead,
            CTCI.Ch_02_Linked_Lists.LinkedListNode<int> expected)
        {
            var solution = new Intersection();

            var actual = solution.GetIntersectionNode1(firstHead, secondHead);

            Assert.Same(expected, actual);
        }

        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void GetIntersectionNode2(
            CTCI.Ch_02_Linked_Lists.LinkedListNode<int> firstHead,
            CTCI.Ch_02_Linked_Lists.LinkedListNode<int> secondHead,
            CTCI.Ch_02_Linked_Lists.LinkedListNode<int> expected)
        {
            var solution = new Intersection();

            var actual = solution.GetIntersectionNode2(firstHead, secondHead);

            Assert.Same(expected, actual);
        }

        public static IEnumerable<object[]> GetTestCases()
        {
            var firstHead1 = new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(1);
            var secondHead1 = firstHead1;
            var expected1 = firstHead1;

            var expected2 = new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(1,
                new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(2));
            var firstHead2 = new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(3,
                new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(4, expected2));
            var secondHead2 = new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(5, expected2);

            var expected3 = new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(1,
                new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(2,
                    new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(3)));
            var firstHead3 = new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(3,
                new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(4,
                    new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(5,
                        expected3)));
            var secondHead3 = new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(6, expected3);

            var firstHead4 = new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(1,
                new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(2));
            var secondHead4 = new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(3,
                new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(4));
            var expected4 = (CTCI.Ch_02_Linked_Lists.LinkedListNode<int>) null;

            yield return new object[] { firstHead1, secondHead1, expected1 };
            yield return new object[] { firstHead2, secondHead2, expected2 };
            yield return new object[] { firstHead3, secondHead3, expected3 };
            yield return new object[] { firstHead4, secondHead4, expected4 };
        }
    }
}
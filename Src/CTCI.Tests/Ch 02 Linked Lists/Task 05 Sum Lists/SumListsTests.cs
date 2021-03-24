using System;
using System.Collections.Generic;
using CTCI.Ch_02_Linked_Lists.Task_05_Sum_Lists;
using Xunit;

namespace CTCI.Tests.Ch_02_Linked_Lists.Task_05_Sum_Lists
{
    public class SumListsTests
    {
        [Theory]
        [MemberData(nameof(GetReversedTestCases))]
        public void SumReversed(int[] first, int[] second, int[] expected)
        {
            var solution = new SumLists();
            var firstLinkedList = LinkedListHelper.FromCollection(first);
            var secondLinkedList = LinkedListHelper.FromCollection(second);

            var actual = solution.SumReversed(firstLinkedList, secondLinkedList);

            Assert.Equal(expected, LinkedListHelper.ToList(actual));
        }

        [Theory]
        [MemberData(nameof(GetStraightTestCases))]
        public void SumStraight(int[] first, int[] second, int[] expected)
        {
            var solution = new SumLists();
            var firstLinkedList = LinkedListHelper.FromCollection(first);
            var secondLinkedList = LinkedListHelper.FromCollection(second);

            var actual = solution.SumStraight(firstLinkedList, secondLinkedList);

            Assert.Equal(expected, LinkedListHelper.ToList(actual));
        }

        public static IEnumerable<object[]> GetReversedTestCases()
        {
            var first1 = new[] { 2 };
            var second1 = new[] { 3 };
            var expected1 = new[] { 5 };

            var first2 = new[] { 7, 1, 6 };
            var second2 = new[] { 5, 9, 2 };
            var expected2 = new[] { 2, 1, 9 };

            var first3 = new[] { 7, 2, 9 };
            var second3 = new[] { 8, 2, 4 };
            var expected3 = new[] { 5, 5, 3, 1 };

            var first4 = new[] { 6, 3, 5, 1, 6, 8, 2, 0, 1, 6, 2 };
            var second4 = new[] { 1, 6, 2, 2, 1, 8 };
            var expected4 = new[] { 7, 9, 7, 3, 7, 6, 3, 0, 1, 6, 2 };

            var first5 = new[] { 0, 0, 2 };
            var second5 = new[] { 0, 0, 3 };
            var expected5 = new[] { 0, 0, 5 };

            var first6 = new[] { 1 };
            var second6 = new[] { 5, 2, 7, 8 };
            var expected6 = new[] { 6, 2, 7, 8 };

            var first7 = new[] { 5, 2, 7, 8 };
            var second7 = new[] { 1 };
            var expected7 = new[] { 6, 2, 7, 8 };

            yield return new object[] { first1, second1, expected1 };
            yield return new object[] { first2, second2, expected2 };
            yield return new object[] { first3, second3, expected3 };
            yield return new object[] { first4, second4, expected4 };
            yield return new object[] { first5, second5, expected5 };
            yield return new object[] { first6, second6, expected6 };
            yield return new object[] { first7, second7, expected7 };
        }

        public static IEnumerable<object[]> GetStraightTestCases()
        {
            foreach (var reversedTestCase in GetReversedTestCases())
            {
                var first = (int[]) reversedTestCase[0];
                var second = (int[]) reversedTestCase[1];
                var expected = (int[]) reversedTestCase[2];

                Array.Reverse(first);
                Array.Reverse(second);
                Array.Reverse(expected);

                yield return new object[] { first, second, expected };
            }
        }
    }
}
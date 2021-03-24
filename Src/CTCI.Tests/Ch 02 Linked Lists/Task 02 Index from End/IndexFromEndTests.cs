using System.Collections.Generic;
using CTCI.Ch_02_Linked_Lists.Task_02_Index_from_End;
using Xunit;

namespace CTCI.Tests.Ch_02_Linked_Lists.Task_02_Index_from_End
{
    public class IndexFromEndTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void ElementByIndexFromEnd1(int[] input, int index, int expected)
        {
            var solution = new IndexFromEnd();

            var actual = solution.ElementByIndexFromEnd1(
                LinkedListHelper.FromCollection(input),
                index);

            Assert.Equal(expected, actual.Value);
        }

        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void ElementByIndexFromEnd2(int[] input, int index, int expected)
        {
            var solution = new IndexFromEnd();

            var actual = solution.ElementByIndexFromEnd2(
                LinkedListHelper.FromCollection(input),
                index);

            Assert.Equal(expected, actual.Value);
        }

        public static IEnumerable<object[]> GetTestCases()
        {
            var input1 = new[] { 1, 2, 3 };
            var index1 = 1;
            var expected1 = 2;

            var input2 = new[] { 1, 2, 3, 3, 3, 3, 3, 3 };
            var index2 = 0;
            var expected2 = 3;

            var input3 = new[] { 1 };
            var index3 = 0;
            var expected3 = 1;

            var input4 = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var index4 = 6;
            var expected4 = 1;

            var input5 = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var index5 = 3;
            var expected5 = 4;

            yield return new object[] { input1, index1, expected1 };
            yield return new object[] { input2, index2, expected2 };
            yield return new object[] { input3, index3, expected3 };
            yield return new object[] { input4, index4, expected4 };
            yield return new object[] { input5, index5, expected5 };
        }
    }
}
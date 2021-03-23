using System.Collections.Generic;
using CTCI.Ch_02_Linked_Lists.Task_01_Delete_Duplicates;
using Xunit;

namespace CTCI.Tests.Ch_02_Linked_Lists.Task_01_Delete_Duplicates
{
    public class DeleteDuplicatesTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void Delete1(int[] input, int[] expected)
        {
            var solution = new DeleteDuplicates();

            var actual = solution.Delete1(LinkedListHelper.FromCollection(input));

            Assert.Equal(expected, LinkedListHelper.ToList(actual));
        }

        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void Delete2(int[] input, int[] expected)
        {
            var solution = new DeleteDuplicates();

            var actual = solution.Delete2(LinkedListHelper.FromCollection(input));

            Assert.Equal(expected, LinkedListHelper.ToList(actual));
        }

        public static IEnumerable<object[]> GetTestCases()
        {
            var input1 = new[] { 1, 2, 3, 3, 2, 1 };
            var expected1 = new[] { 1, 2, 3 };

            var input2 = new[] { 1, 2, 3 };
            var expected2 = new[] { 1, 2, 3 };

            var input3 = new[] { 1, 2, 3, 1, 4, 1, 5, 1, 1, 1, 1 };
            var expected3 = new[] { 1, 2, 3, 4, 5 };

            var input4 = new[] { 1, 1, 1 };
            var expected4 = new[] { 1 };

            var input5 = new[] { 1, 1, 1, 2, 2, 2, 1, 2 };
            var expected5 = new[] { 1, 2 };

            var input6 = new[] { 5, 4, 3, 2, 1, 1, 1, 5 };
            var expected6 = new[] { 5, 4, 3, 2, 1 };

            yield return new object[] { input1, expected1 };
            yield return new object[] { input2, expected2 };
            yield return new object[] { input3, expected3 };
            yield return new object[] { input4, expected4 };
            yield return new object[] { input5, expected5 };
            yield return new object[] { input6, expected6 };
        }
    }
}
using System.Collections.Generic;
using CTCI.Ch_02_Linked_Lists.Task_06_Palindrome;
using Xunit;

namespace CTCI.Tests.Ch_02_Linked_Lists.Task_06_Palindrome
{
    public class PalindromeTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void IsPalindrome1(char[] input, bool expected)
        {
            var solution = new Palindrome();

            var actual = solution.IsPalindrome1(LinkedListHelper.FromCollection(input));

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void IsPalindrome2(char[] input, bool expected)
        {
            var solution = new Palindrome();

            var actual = solution.IsPalindrome2(LinkedListHelper.FromCollection(input));

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void IsPalindrome3(char[] input, bool expected)
        {
            var solution = new Palindrome();

            var actual = solution.IsPalindrome3(LinkedListHelper.FromCollection(input));

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> GetTestCases()
        {
            var input1 = new[] { 'a' };
            var expected1 = true;

            var input2 = new[] { 'a', 'a', 'a' };
            var expected2 = true;

            var input3 = new[] { 'a', 'a', 'b' };
            var expected3 = false;

            var input4 = new[] { 'b', 'a', 'a' };
            var expected4 = false;

            var input5 = new[] { 'b', 'a', 'a', 'c', 'a', 'a', 'b' };
            var expected5 = true;

            var input6 = new[] { 'b', 'c', 'a', 'a', 'c', 'b' };
            var expected6 = true;

            var input7 = new[] { 'a', 'a' };
            var expected7 = true;

            var input8 = new[] { 'a', 'b' };
            var expected8 = false;

            yield return new object[] { input1, expected1 };
            yield return new object[] { input2, expected2 };
            yield return new object[] { input3, expected3 };
            yield return new object[] { input4, expected4 };
            yield return new object[] { input5, expected5 };
            yield return new object[] { input6, expected6 };
            yield return new object[] { input7, expected7 };
            yield return new object[] { input8, expected8 };
        }
    }
}
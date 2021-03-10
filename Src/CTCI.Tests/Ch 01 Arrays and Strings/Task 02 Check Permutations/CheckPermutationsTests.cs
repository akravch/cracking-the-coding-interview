using CTCI.Ch_01_Arrays_and_Strings.Task_02_Check_Permutations;
using Xunit;

namespace CTCI.Tests.Ch_01_Arrays_and_Strings.Task_02_Check_Permutations
{
    public class CheckPermutationsTests
    {
        [Theory]
        [InlineData("abcde", "cdbae", true)]
        [InlineData("abcde", "cdbaa", false)]
        [InlineData("a", "a", true)]
        [InlineData("abcd", "abcd", true)]
        [InlineData("qwerty", "qweqweqweqweqweqwe", false)]
        [InlineData("aaa", "a", false)]
        [InlineData("a", "aaa", false)]
        public void IsPermuted1(string str1, string str2, bool expected)
        {
            var solution = new CheckPermutations();

            var actual = solution.IsPermuted1(str1, str2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abcde", "cdbae", true)]
        [InlineData("abcde", "cdbaa", false)]
        [InlineData("a", "a", true)]
        [InlineData("abcd", "abcd", true)]
        [InlineData("qwerty", "qweqweqweqweqweqwe", false)]
        [InlineData("aaa", "a", false)]
        [InlineData("a", "aaa", false)]
        public void IsPermuted2(string str1, string str2, bool expected)
        {
            var solution = new CheckPermutations();

            var actual = solution.IsPermuted2(str1, str2);

            Assert.Equal(expected, actual);
        }
    }
}
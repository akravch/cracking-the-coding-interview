using CTCI.Ch_01_Arrays_and_Strings.Task_04_Palindrome_Permutation;
using Xunit;

namespace CTCI.Tests.Ch_01_Arrays_and_Strings.Task_04_Palindrome_Permutation
{
    public class PalindromePermutationTests
    {
        [Theory]
        [InlineData("Tact Coa", true)]
        [InlineData("AbCcB a", true)]
        [InlineData("a", true)]
        [InlineData("qwerty", false)]
        [InlineData("Tact Coaa", false)]
        public void IsPalindromePermutation1(string str, bool expected)
        {
            var solution = new PalindromePermutation();

            var actual = solution.IsPalindromePermutation1(str);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Tact Coa", true)]
        [InlineData("AbCcB a", true)]
        [InlineData("a", true)]
        [InlineData("qwerty", false)]
        [InlineData("Tact Coaa", false)]
        public void IsPalindromePermutation2(string str, bool expected)
        {
            var solution = new PalindromePermutation();

            var actual = solution.IsPalindromePermutation2(str);

            Assert.Equal(expected, actual);
        }
    }
}
using CTCI.Ch_01_Arrays_and_Strings.Task_06_String_Compression;
using Xunit;

namespace CTCI.Tests.Ch_01_Arrays_and_Strings.Task_06_String_Compression
{
    public class StringCompressorTests
    {
        [Theory]
        [InlineData("a", "a")]
        [InlineData("aa", "aa")]
        [InlineData("aaa", "a3")]
        [InlineData("aaabcc", "aaabcc")]
        [InlineData("aaabccc", "a3b1c3")]
        public void Compress(string input, string expected)
        {
            var solution = new StringCompressor();

            var actual = solution.Compress(input);

            Assert.Equal(expected, actual);
        }
    }
}
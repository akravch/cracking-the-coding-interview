using CTCI.Ch_01_Arrays_and_Strings.Task_01_Unique_Symbols;
using Xunit;

namespace CTCI.Tests.Ch_01_Arrays_and_Strings.Task_01_Unique_Symbols
{
    public class UniqueSymbolsTests
    {
        [Theory]
        [InlineData("abcdefg", true)]
        [InlineData("a", true)]
        [InlineData("aaaaaaa", false)]
        [InlineData("aghjklba", false)]
        public void IsUnique(string str, bool expected)
        {
            var solution = new UniqueSymbols();

            var isUnique = solution.IsUnique(str);

            Assert.Equal(expected, isUnique);
        }
    }
}
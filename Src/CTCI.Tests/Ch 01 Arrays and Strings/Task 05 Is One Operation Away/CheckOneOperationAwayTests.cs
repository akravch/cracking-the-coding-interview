using CTCI.Ch_01_Arrays_and_Strings.Task_05_Is_One_Operation_Away;
using Xunit;

namespace CTCI.Tests.Ch_01_Arrays_and_Strings.Task_05_Is_One_Operation_Away
{
    public class CheckOneOperationAwayTests
    {
        [Theory]
        [InlineData("pale", "ple", true)]
        [InlineData("pales", "pale", true)]
        [InlineData("pale", "bale", true)]
        [InlineData("pale", "bake", false)]
        [InlineData("pale", "pale", true)]
        [InlineData("pale", "paleeeeee", false)]
        [InlineData("p", "p", true)]
        public void IsOneAway(string str1, string str2, bool expected)
        {
            var solution = new CheckOneOperationAway();

            var actual = solution.IsOneAway(str1, str2);

            Assert.Equal(expected, actual);
        }
    }
}
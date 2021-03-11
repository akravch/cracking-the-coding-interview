using CTCI.Ch_01_Arrays_and_Strings.Task_09_Cyclic_Shift;
using Xunit;

namespace CTCI.Tests.Ch_01_Arrays_and_Strings.Task_09_Cyclic_Shift
{
    public class CyclicShiftTests
    {
        [Theory]
        [InlineData("waterbottle", "erbottlewat", true)]
        [InlineData("erbottlewat", "waterbottle", true)]
        [InlineData("waterwattle", "erbottlewat", false)]
        [InlineData("hello", "hello", true)]
        [InlineData("hello", "ohell", true)]
        [InlineData("hello", "ohelo", false)]
        [InlineData("a", "bbbbbbbb", false)]
        public void IsCyclicShift(string str1, string str2, bool expected)
        {
            var solution = new CyclicShift();

            var actual = solution.IsCyclicShift(str1, str2);

            Assert.Equal(expected, actual);
        }
    }
}
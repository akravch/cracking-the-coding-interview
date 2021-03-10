using System;
using System.Linq;
using CTCI.Ch_01_Arrays_and_Strings.Task_03_Urlify_Spaces;
using Xunit;

namespace CTCI.Tests.Ch_01_Arrays_and_Strings.Task_03_Urlify_Spaces
{
    public class UrlifySpacesTests
    {
        [Theory]
        [InlineData("Mr John Smith Jr", "Mr%20John%20Smith%20Jr")]
        public void Urlify1(string initial, string expected)
        {
            var solution = new UrlifySpaces();
            var textLength = initial.Length;
            var spacesCount = initial.Count(c => c == ' ');
            var initialArray = new char[textLength + spacesCount * 2];
            Array.Copy(initial.ToCharArray(), initialArray, textLength);

            var actual = solution.Urlify1(initialArray, textLength);

            Assert.Equal(expected, new string(actual));
        }

        [Theory]
        [InlineData("Mr John Smith Jr", "Mr%20John%20Smith%20Jr")]
        public void Urlify2(string initial, string expected)
        {
            var solution = new UrlifySpaces();
            var textLength = initial.Length;
            var spacesCount = initial.Count(c => c == ' ');
            var initialArray = new char[textLength + spacesCount * 2];
            Array.Copy(initial.ToCharArray(), initialArray, textLength);

            var actual = solution.Urlify2(initialArray, textLength);

            Assert.Equal(expected, new string(actual));
        }
    }
}
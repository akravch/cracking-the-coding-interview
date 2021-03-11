using System.Collections.Generic;
using CTCI.Ch_01_Arrays_and_Strings.Task_07_Matrix_Rotation;
using Xunit;

namespace CTCI.Tests.Ch_01_Arrays_and_Strings.Task_07_Matrix_Rotation
{
    public class RotationTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void Rotate(int[,] input, int[,] expected)
        {
            var solution = new Rotation();

            var actual = solution.Rotate(input);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> GetTestCases()
        {
            var input1 = new[,]
            {
                { 1 }
            };
            var expected1 = new[,]
            {
                { 1 }
            };

            var input2 = new[,]
            {
                { 1, 2 },
                { 3, 4 }
            };
            var expected2 = new[,]
            {
                { 3, 1 },
                { 4, 2 }
            };

            var input3 = new[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            var expected3 = new[,]
            {
                { 7, 4, 1 },
                { 8, 5, 2 },
                { 9, 6, 3 }
            };

            var input4 = new[,]
            {
                { 1,  2,  3,  4  },
                { 5,  6,  7,  8  },
                { 9,  10, 11, 12 },
                { 13, 14, 15, 16 }
            };
            var expected4 = new[,]
            {
                { 13, 9,  5,  1 },
                { 14, 10, 6,  2 },
                { 15, 11, 7,  3 },
                { 16, 12, 8,  4 }
            };

            var input5 = new[,]
            {
                { 1,  2,  3,  4,  5  },
                { 6,  7,  8,  9,  10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25 },
            };
            var expected5 = new[,]
            {
                { 21, 16, 11, 6,  1 },
                { 22, 17, 12, 7,  2 },
                { 23, 18, 13, 8,  3 },
                { 24, 19, 14, 9,  4 },
                { 25, 20, 15, 10, 5 },
            };

            yield return new object[] { input1, expected1 };
            yield return new object[] { input2, expected2 };
            yield return new object[] { input3, expected3 };
            yield return new object[] { input4, expected4 };
            yield return new object[] { input5, expected5 };
        }
    }
}
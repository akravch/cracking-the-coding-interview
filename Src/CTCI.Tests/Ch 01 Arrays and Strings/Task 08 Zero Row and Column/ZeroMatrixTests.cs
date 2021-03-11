using System.Collections.Generic;
using CTCI.Ch_01_Arrays_and_Strings.Task_08_Zero_Row_and_Column;
using Xunit;

namespace CTCI.Tests.Ch_01_Arrays_and_Strings.Task_08_Zero_Row_and_Column
{
    public class ZeroMatrixTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void Zero1(int[,] input, int[,] expected)
        {
            var solution = new ZeroMatrix();

            var actual = solution.Zero1(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void Zero2(int[,] input, int[,] expected)
        {
            var solution = new ZeroMatrix();

            var actual = solution.Zero2(input);

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
                { 0 }
            };
            var expected2 = new[,]
            {
                { 0 }
            };

            var input3 = new[,]
            {
                { 1, 0, 2 }
            };
            var expected3 = new[,]
            {
                { 0, 0, 0 }
            };

            var input4 = new[,]
            {
                { 1 },
                { 0 },
                { 2 }
            };
            var expected4 = new[,]
            {
                { 0 },
                { 0 },
                { 0 }
            };

            var input5 = new[,]
            {
                { 1, 2, 3 },
                { 4, 0, 5 },
                { 6, 7, 8 }
            };
            var expected5 = new[,]
            {
                { 1, 0, 3 },
                { 0, 0, 0 },
                { 6, 0, 8 }
            };

            var input6 = new[,]
            {
                { 0, 2, 3 },
                { 4, 0, 5 },
                { 6, 7, 8 }
            };
            var expected6 = new[,]
            {
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 8 }
            };

            var input7 = new[,]
            {
                { 1,  2,  3,  4,  5  },
                { 6,  7,  8,  0,  10 },
                { 11, 12, 13, 14, 15 },
                { 16, 0,  18, 19, 20 },
                { 21, 22, 23, 24, 0  },
            };
            var expected7 = new[,]
            {
                { 1,  0,  3,  0,  0 },
                { 0,  0,  0,  0,  0 },
                { 11, 0,  13, 0,  0 },
                { 0,  0,  0,  0,  0 },
                { 0,  0,  0,  0,  0 },
            };

            var input8 = new[,]
            {
                { 1,  0,  0,  4,  5  },
                { 6,  7,  8,  9,  10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25 },
            };
            var expected8 = new[,]
            {
                { 0,  0,  0,  0,  0  },
                { 6,  0,  0,  9,  10 },
                { 11, 0,  0,  14, 15 },
                { 16, 0,  0,  19, 20 },
                { 21, 0,  0,  24, 25 },
            };

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
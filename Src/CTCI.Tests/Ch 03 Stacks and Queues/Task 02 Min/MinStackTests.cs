using System.Collections.Generic;
using System.Linq;
using CTCI.Ch_03_Stacks_and_Queues.Task_02_Min;
using Xunit;

namespace CTCI.Tests.Ch_03_Stacks_and_Queues.Task_02_Min
{
    public class MinStackTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void MinStack(int[] array)
        {
            var minStack = new MinStack();
            var normalStack = new Stack<int>();

            foreach (var item in array)
            {
                minStack.Push(item);
                normalStack.Push(item);

                Assert.Equal(normalStack.Min(), minStack.Min);
            }

            while (minStack.Count > 1)
            {
                Assert.Equal(normalStack.Pop(), minStack.Pop());
                Assert.Equal(normalStack.Min(), minStack.Min);
            }
        }

        public static IEnumerable<object[]> GetTestCases()
        {
            yield return new object[] { new[] { 2 } };
            yield return new object[] { new[] { 2, 2, 2, 2 } };
            yield return new object[] { new[] { 4, 2, 5, 1, 9, 1 } };
            yield return new object[] { new[] { 7, 4, 6, 1, 6, 9, 9, 5, 1, 5, 1, 1, 5, 2, 7 } };
        }
    }
}
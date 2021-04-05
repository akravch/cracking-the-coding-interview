using System;
using System.Collections.Generic;
using CTCI.Ch_03_Stacks_and_Queues.Task_05_Sort_Stack;
using Xunit;

namespace CTCI.Tests.Ch_03_Stacks_and_Queues.Task_05_Sort_Stack
{
    public class SortStackTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void Sort1(int[] items)
        {
            var stack = StackFromArray(items);
            var solution = new SortStack();
            Array.Sort(items);

            solution.Sort1(stack);

            Assert.Equal(items, ArrayFromStack(stack));
        }

        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void Sort2(int[] items)
        {
            var stack = StackFromArray(items);
            var solution = new SortStack();
            Array.Sort(items);

            solution.Sort2(stack);

            Assert.Equal(items, ArrayFromStack(stack));
        }

        public static IEnumerable<object[]> GetTestCases()
        {
            yield return new object[] { new[] { 1, 3, 2, 4 } };
            yield return new object[] { new[] { 5, 2, 5 } };
            yield return new object[] { new[] { 1 } };
            yield return new object[] { new[] { 1, 2 } };
            yield return new object[] { new[] { 5, 2, 5, 2, 5, 2, 6, 2, 5, 2, 1, 6, 4, 6 } };
        }

        private static Stack<int> StackFromArray(int[] items)
        {
            var stack = new Stack<int>();

            foreach (var item in items)
            {
                stack.Push(item);
            }

            return stack;
        }

        private static int[] ArrayFromStack(Stack<int> stack)
        {
            var array = new int[stack.Count];

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = stack.Pop();
            }

            return array;
        }
    }
}
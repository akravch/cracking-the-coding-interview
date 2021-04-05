using System.Collections.Generic;
using CTCI.Ch_03_Stacks_and_Queues.Task_04_Queue_of_Two_Stacks;
using Xunit;

namespace CTCI.Tests.Ch_03_Stacks_and_Queues.Task_04_Queue_of_Two_Stacks
{
    public class QueueOfTwoStacksTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void QueueOfTwoStacks(int[] items)
        {
            var normalQueue = new Queue<int>();
            var customQueue = new QueueOfTwoStacks();

            foreach (var item in items)
            {
                normalQueue.Enqueue(item);
                customQueue.Enqueue(item);

                Assert.Equal(normalQueue.Count, customQueue.Count);
            }

            while (normalQueue.Count > 0)
            {
                Assert.Equal(normalQueue.Dequeue(), customQueue.Dequeue());
                Assert.Equal(normalQueue.Count, customQueue.Count);
            }
        }

        public static IEnumerable<object[]> GetTestCases()
        {
            yield return new object[] { new[] { 1 } };
            yield return new object[] { new[] { 1, 2 } };
            yield return new object[] { new[] { 5, 2, 5, 2, 5, 2, 6, 2, 5, 2, 1, 6, 4, 6 } };
        }
    }
}
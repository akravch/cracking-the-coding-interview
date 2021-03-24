using System.Collections.Generic;
using CTCI.Ch_02_Linked_Lists.Task_04_Partition;
using Xunit;

namespace CTCI.Tests.Ch_02_Linked_Lists.Task_04_Partition
{
    public class PartitionTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void PartitionAround(int[] input, int around)
        {
            var solution = new Partition();
            var head = LinkedListHelper.FromCollection(input);

            var partitioned = solution.PartitionAround(head, around);

            Assert.True(IsPartitionedAround(LinkedListHelper.ToList(partitioned), around));
        }

        public static IEnumerable<object[]> GetTestCases()
        {
            var input1 = new[] { 1, 2, 3, 4, 5 };
            var around1 = 3;

            var input2 = new[] { 3, 5, 8, 5, 10, 2, 1 };
            var around2 = 5;

            var input3 = new[] { 7, 3, 1, 8, 6, 1, 9 };
            var around3 = 7;

            var input4 = new[] { 7, 3, 1, 8, 6, 1, 9 };
            var around4 = 9;

            var input5 = new[] { 7, 3, 5, 8, 5, 10, 2, 1 };
            var around5 = 5;

            yield return new object[] { input1, around1 }; 
            yield return new object[] { input2, around2 }; 
            yield return new object[] { input3, around3 }; 
            yield return new object[] { input4, around4 }; 
            yield return new object[] { input5, around5 }; 
        }

        private static bool IsPartitionedAround(IReadOnlyList<int> array, int around)
        {
            for (var i = 0; i < array.Count; i++)
            {
                if (array[i] < around)
                {
                    for (var j = 0; j < i; j++)
                    {
                        if (array[j] >= around)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
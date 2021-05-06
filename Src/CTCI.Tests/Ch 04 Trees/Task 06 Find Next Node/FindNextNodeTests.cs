using System.Collections.Generic;
using CTCI.Ch_04_Trees;
using CTCI.Ch_04_Trees.Task_06_Find_Next_Node;
using Xunit;

namespace CTCI.Tests.Ch_04_Trees.Task_06_Find_Next_Node
{
    public class FindNextNodeTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void Next(BinaryTreeNodeWithParent<int> node, BinaryTreeNodeWithParent<int> expected)
        {
            var solution = new FindNextNode();

            var actual = solution.Next(node);

            Assert.Same(expected, actual);
        }

        public static IEnumerable<object[]> GetTestCases()
        {
            var root = new BinaryTreeNodeWithParent<int>(4);
            var level21 = root.CreateLeft(2);
            var level22 = root.CreateRight(6);
            var level31 = level21.CreateLeft(1);
            var level32 = level21.CreateRight(3);
            var level33 = level22.CreateLeft(5);
            var level34 = level22.CreateRight(7);

            var sortedNodes = new[]
            {
                level31, // 1
                level21, // 2
                level32, // 3
                root,    // 4
                level33, // 5
                level22, // 6
                level34, // 7
            };

            for (var i = 0; i < sortedNodes.Length - 1; i++)
            {
                yield return new object[] { sortedNodes[i], sortedNodes[i + 1] };
            }

            yield return new object[] { level34, null };
        }
    }
}
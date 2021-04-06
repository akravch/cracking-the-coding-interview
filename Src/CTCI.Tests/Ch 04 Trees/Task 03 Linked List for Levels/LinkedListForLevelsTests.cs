using CTCI.Ch_04_Trees;
using CTCI.Ch_04_Trees.Task_03_Linked_List_for_Levels;
using Xunit;

namespace CTCI.Tests.Ch_04_Trees.Task_03_Linked_List_for_Levels
{
    public class LinkedListForLevelsTests
    {
        [Fact]
        public void Create()
        {
            var nodes = CreateNodes();
            var root = nodes[0];
            var expectedLevels = new[]
            {
                new[] { nodes[0] },
                new[] { nodes[1], nodes[4] },
                new[] { nodes[2], nodes[3], nodes[5] },
                new[] { nodes[6], nodes[7] },
            };
            var solution = new LinkedListForLevels();

            var actual = solution.Create(root);

            Assert.Equal(expectedLevels.Length, actual.Count);

            for (var i = 0; i < expectedLevels.Length; i++)
            {
                Assert.Equal(expectedLevels[i], actual[i]);
            }
        }

        private static BinaryTreeNode<int>[] CreateNodes()
        {
            var node3 = new BinaryTreeNode<int>(3);
            var node4 = new BinaryTreeNode<int>(4);
            var node2 = new BinaryTreeNode<int>(2)
            {
                Left = node3,
                Right = node4,
            };
            var node7 = new BinaryTreeNode<int>(7);
            var node8 = new BinaryTreeNode<int>(8);
            var node6 = new BinaryTreeNode<int>(6)
            {
                Left = node7,
                Right = node8,
            };
            var node5 = new BinaryTreeNode<int>(5)
            {
                Left = node6
            };
            var node1 = new BinaryTreeNode<int>(1)
            {
                Left = node2,
                Right = node5,
            };

            return new[]
            {
                node1,
                node2,
                node3,
                node4,
                node5,
                node6,
                node7,
                node8
            };
        }
    }
}
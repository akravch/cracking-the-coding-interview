using System.Collections.Generic;
using CTCI.Ch_04_Trees;
using CTCI.Ch_04_Trees.Task_04_Check_Tree_Balanced;
using Xunit;

namespace CTCI.Tests.Ch_04_Trees.Task_04_Check_Tree_Balanced
{
    public class CheckTreeBalancedTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void IsBalanced(BinaryTreeNode<int> root, bool expected)
        {
            var solution = new CheckTreeBalanced();

            var actual = solution.IsBalanced(root);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> GetTestCases()
        {
            var root1 = new BinaryTreeNode<int>(1)
            {
                Left = new BinaryTreeNode<int>(2)
                {
                    Left = new BinaryTreeNode<int>(4),
                    Right = new BinaryTreeNode<int>(5),
                },
                Right = new BinaryTreeNode<int>(3)
                {
                    Left = new BinaryTreeNode<int>(6),
                    Right = new BinaryTreeNode<int>(7),
                },
            };
            var expected1 = true;

            var root2 = new BinaryTreeNode<int>(1);
            var expected2 = true;

            var root3 = new BinaryTreeNode<int>(1)
            {
                Left = new BinaryTreeNode<int>(2)
                {
                    Right = new BinaryTreeNode<int>(5),
                },
                Right = new BinaryTreeNode<int>(3)
                {
                    Left = new BinaryTreeNode<int>(6),
                },
            };
            var expected3 = true;

            var root4 = new BinaryTreeNode<int>(1)
            {
                Left = new BinaryTreeNode<int>(2)
                {
                    Left = new BinaryTreeNode<int>(4),
                    Right = new BinaryTreeNode<int>(5),
                }
            };
            var expected4 = false;

            var root5 = new BinaryTreeNode<int>(1)
            {
                Right = new BinaryTreeNode<int>(3)
                {
                    Left = new BinaryTreeNode<int>(6),
                },
            };
            var expected5 = false;

            var root6 = new BinaryTreeNode<int>(1)
            {
                Left = new BinaryTreeNode<int>(2)
                {
                    Left = new BinaryTreeNode<int>(4)
                    {
                        Left = new BinaryTreeNode<int>(8),
                        Right = new BinaryTreeNode<int>(10),
                    },
                },
                Right = new BinaryTreeNode<int>(3)
                {
                    Right = new BinaryTreeNode<int>(7)
                    {
                        Right = new BinaryTreeNode<int>(9)
                    },
                },
            };
            var expected6 = false;

            yield return new object[] { root1, expected1 };
            yield return new object[] { root2, expected2 };
            yield return new object[] { root3, expected3 };
            yield return new object[] { root4, expected4 };
            yield return new object[] { root5, expected5 };
            yield return new object[] { root6, expected6 };
        }
    }
}
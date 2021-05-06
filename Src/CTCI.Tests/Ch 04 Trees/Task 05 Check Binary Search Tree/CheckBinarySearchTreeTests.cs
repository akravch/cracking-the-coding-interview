using System.Collections.Generic;
using CTCI.Ch_04_Trees;
using CTCI.Ch_04_Trees.Task_05_Check_Binary_Search_Tree;
using Xunit;

namespace CTCI.Tests.Ch_04_Trees.Task_05_Check_Binary_Search_Tree
{
    public class CheckBinarySearchTreeTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void IsBinarySearchTree1(BinaryTreeNode<int> root, bool expected)
        {
            var solution = new CheckBinarySearchTree();

            var actual = solution.IsBinarySearchTree1(root);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void IsBinarySearchTree2(BinaryTreeNode<int> root, bool expected)
        {
            var solution = new CheckBinarySearchTree();

            var actual = solution.IsBinarySearchTree2(root);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> GetTestCases()
        {
            var root1 = new BinaryTreeNode<int>(4)
            {
                Left = new BinaryTreeNode<int>(2)
                {
                    Left = new BinaryTreeNode<int>(1),
                    Right = new BinaryTreeNode<int>(3)
                },
                Right = new BinaryTreeNode<int>(6)
                {
                    Left = new BinaryTreeNode<int>(5),
                    Right = new BinaryTreeNode<int>(7)
                }
            };
            var expected1 = true;

            var root2 = new BinaryTreeNode<int>(1)
            {
                Left = new BinaryTreeNode<int>(2)
                {
                    Left = new BinaryTreeNode<int>(4),
                    Right = new BinaryTreeNode<int>(6)
                },
                Right = new BinaryTreeNode<int>(3)
                {
                    Left = new BinaryTreeNode<int>(5),
                    Right = new BinaryTreeNode<int>(7)
                }
            };
            var expected2 = false;

            var root3 = new BinaryTreeNode<int>(4)
            {
                Left = new BinaryTreeNode<int>(3)
                {
                    Left = new BinaryTreeNode<int>(2)
                    {
                        Left = new BinaryTreeNode<int>(1)
                    }
                }
            };
            var expected3 = true;

            var root4 = new BinaryTreeNode<int>(42);
            var expected4 = true;

            var root5 = new BinaryTreeNode<int>(4)
            {
                Left = new BinaryTreeNode<int>(2)
                {
                    Left = new BinaryTreeNode<int>(1),
                    Right = new BinaryTreeNode<int>(3)
                }
            };
            var expected5 = true;

            var root6 = new BinaryTreeNode<int>(4)
            {
                Left = new BinaryTreeNode<int>(3)
                {
                    Left = new BinaryTreeNode<int>(2)
                    {
                        Left = new BinaryTreeNode<int>(1)
                    }
                },
                Right = new BinaryTreeNode<int>(5)
                {
                    Right = new BinaryTreeNode<int>(6)
                }
            };
            var expected6 = true;

            var root7 = new BinaryTreeNode<int>(20)
            {
                Left = new BinaryTreeNode<int>(10)
                {
                    Right = new BinaryTreeNode<int>(25)
                },
                Right = new BinaryTreeNode<int>(30)
            };
            var expected7 = false;

            yield return new object[] { root1, expected1 };
            yield return new object[] { root2, expected2 };
            yield return new object[] { root3, expected3 };
            yield return new object[] { root4, expected4 };
            yield return new object[] { root5, expected5 };
            yield return new object[] { root6, expected6 };
            yield return new object[] { root7, expected7 };
        }
    }
}
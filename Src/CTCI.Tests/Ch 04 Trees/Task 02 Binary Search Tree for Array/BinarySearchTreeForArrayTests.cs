using System;
using System.Collections.Generic;
using CTCI.Ch_04_Trees;
using CTCI.Ch_04_Trees.Task_02_Binary_Search_Tree_for_Array;
using Xunit;

namespace CTCI.Tests.Ch_04_Trees.Task_02_Binary_Search_Tree_for_Array
{
    public class BinarySearchTreeForArrayTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void Create(int[] array)
        {
            var solution = new BinarySearchTreeForArray();

            var actual = solution.Create(array);

            Assert.Equal(array, ArrayFromTree(actual));
            Assert.True(IsBalanced(actual, array.Length));
        }

        public static IEnumerable<object[]> GetTestCases()
        {
            yield return new object[]
            {
                new[] { 1, 2, 3, 4, 5, 6, 7 }
            };
            yield return new object[]
            {
                new[] { 2, 4, 6, 8, 10, 20 }
            };
            yield return new object[]
            {
                new[] { 1, 2, 3 }
            };
        }

        private static int[] ArrayFromTree(BinaryTreeNode<int> root)
        {
            var list = new List<int>();
            ListFromTreeRecursive(root, list);
            return list.ToArray();

            static void ListFromTreeRecursive(BinaryTreeNode<int> node, List<int> values)
            {
                if (node == null)
                {
                    return;
                }

                ListFromTreeRecursive(node.Left, values);
                values.Add(node.Value);
                ListFromTreeRecursive(node.Right, values);
            }
        }

        private static int GetTreeLevelCount(BinaryTreeNode<int> root)
        {
            return GetLevelRecursive(root, 1);

            static int GetLevelRecursive(BinaryTreeNode<int> node, int level)
            {
                if (node == null)
                {
                    return level - 1;
                }

                var leftSubtreeLevels = GetLevelRecursive(node.Left, level + 1);
                var rightSubtreeLevels = GetLevelRecursive(node.Right, level + 1);

                return Math.Max(leftSubtreeLevels, rightSubtreeLevels);
            }
        }

        private static bool IsBalanced(BinaryTreeNode<int> root, int elementCount)
        {
            var levelCount = GetTreeLevelCount(root);

            return
                elementCount <= (int) Math.Pow(2, levelCount) - 1 &&
                elementCount > (int) Math.Pow(2, levelCount - 1) - 1;

        }
    }
}
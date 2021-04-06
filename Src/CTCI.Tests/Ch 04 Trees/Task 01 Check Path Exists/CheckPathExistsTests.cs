using System.Collections.Generic;
using CTCI.Ch_04_Trees;
using CTCI.Ch_04_Trees.Task_01_Check_Path_Exists;
using Xunit;

namespace CTCI.Tests.Ch_04_Trees.Task_01_Check_Path_Exists
{
    public class CheckPathExistsTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void Check(int number1, int number2, bool expected)
        {
            var nodes = CreateNodes();
            var node1 = nodes[number1 - 1];
            var node2 = nodes[number2 - 1];
            var solution = new CheckPathExists();

            var actual = solution.Check(node1, node2);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> GetTestCases()
        {
            yield return new object[] { 1, 12, false };
            yield return new object[] { 12, 1, true };
            yield return new object[] { 11, 7, true };
            yield return new object[] { 8, 13, true };
            yield return new object[] { 10, 8, false };
        }

        private static List<TreeNode<int>> CreateNodes()
        {
            var node1 = new TreeNode<int>(1);
            var node2 = new TreeNode<int>(2);
            var node3 = new TreeNode<int>(3);
            var node4 = new TreeNode<int>(4);
            var node5 = new TreeNode<int>(5);
            var node6 = new TreeNode<int>(6);
            var node7 = new TreeNode<int>(7);
            var node8 = new TreeNode<int>(8);
            var node9 = new TreeNode<int>(9);
            var node10 = new TreeNode<int>(10);
            var node11 = new TreeNode<int>(11);
            var node12 = new TreeNode<int>(12);
            var node13 = new TreeNode<int>(13);
            var node14 = new TreeNode<int>(14);

            node1.Children.Add(node2);

            node2.Children.Add(node1);
            node2.Children.Add(node3);

            node3.Children.Add(node2);
            node3.Children.Add(node4);
            node3.Children.Add(node14);

            node4.Children.Add(node5);

            node5.Children.Add(node6);

            node6.Children.Add(node7);

            node8.Children.Add(node1);
            node8.Children.Add(node7);

            node9.Children.Add(node2);

            node10.Children.Add(node9);
            node10.Children.Add(node11);

            node11.Children.Add(node10);

            node12.Children.Add(node11);
            node12.Children.Add(node13);

            node13.Children.Add(node14);

            node14.Children.Add(node3);
            node14.Children.Add(node13);

            return new List<TreeNode<int>>
            {
                node1,
                node2,
                node3,
                node4,
                node5,
                node6,
                node7,
                node8,
                node9,
                node10,
                node11,
                node12,
                node13,
                node14
            };
        }
    }
}
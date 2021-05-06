namespace CTCI.Ch_04_Trees.Task_05_Check_Binary_Search_Tree
{
    public class CheckBinarySearchTree
    {
        public bool IsBinarySearchTree1(BinaryTreeNode<int> root)
        {
            if (root == null)
            {
                return true;
            }

            var pair = IsBinarySearchTree1Internal(root);

            return pair.IsBinarySearchTree;
        }

        public bool IsBinarySearchTree2(BinaryTreeNode<int> root)
        {
            if (root == null)
            {
                return true;
            }

            return IsBinarySearchTree2Internal(root, int.MinValue, int.MaxValue);
        }

        private readonly struct Pair
        {
            public readonly bool IsBinarySearchTree;
            public readonly BinaryTreeNode<int> LastPrinted;

            public Pair(bool isBinarySearchTree, BinaryTreeNode<int> lastPrinted)
            {
                IsBinarySearchTree = isBinarySearchTree;
                LastPrinted = lastPrinted;
            }
        }

        private static Pair IsBinarySearchTree1Internal(BinaryTreeNode<int> node)
        {
            Pair leftPair;

            if (node.Left != null)
            {
                leftPair = IsBinarySearchTree1Internal(node.Left);

                if (!leftPair.IsBinarySearchTree)
                {
                    return new Pair(false, null);
                }
            }
            else
            {
                leftPair = new Pair(true, null);
            }

            Pair rightPair;

            if (node.Right != null)
            {
                rightPair = IsBinarySearchTree1Internal(node.Right);

                if (!rightPair.IsBinarySearchTree)
                {
                    return new Pair(false, null);
                }
            }
            else
            {
                rightPair = new Pair(true, null);
            }

            if (leftPair.LastPrinted != null && leftPair.LastPrinted.Value > node.Value)
            {
                return new Pair(false, null);
            }

            if (rightPair.LastPrinted != null && rightPair.LastPrinted.Value <= node.Value)
            {
                return new Pair(false, null);
            }

            return new Pair(true, rightPair.LastPrinted ?? node);
        }

        private bool IsBinarySearchTree2Internal(BinaryTreeNode<int> node, int min, int max)
        {
            var left = node.Left;

            if (left != null)
            {
                if (left.Value > node.Value)
                {
                    return false;
                }

                return IsBinarySearchTree2Internal(left, min, left.Value);
            }

            var right = node.Right;

            if (right != null)
            {
                if (right.Value <= node.Value)
                {
                    return false;
                }

                return IsBinarySearchTree2Internal(right, right.Value, max);
            }

            return node.Value > min && node.Value <= max;
        }
    }
}
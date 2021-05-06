namespace CTCI.Ch_04_Trees.Task_06_Find_Next_Node
{
    public class FindNextNode
    {
        public BinaryTreeNodeWithParent<int> Next(BinaryTreeNodeWithParent<int> node)
        {
            // Has right
            if (node.Right != null)
            {
                var nextNode = node.Right;
                var left = nextNode.Left;

                if (left != null)
                {
                    while (left.Left != null)
                    {
                        left = left.Left.Left;
                    }

                    nextNode = left;
                }

                return nextNode;
            }

            // Doesn't have right
            var parent = node.Parent;

            // Left node
            if (parent.Left == node)
            {
                return parent;
            }

            // Right node
            var right = node;

            while (parent != null && parent.Right == right)
            {
                right = parent;
                parent = parent.Parent;
            }

            return parent;
        }
    }
}
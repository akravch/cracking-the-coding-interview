using System.Collections.Generic;

namespace CTCI.Ch_04_Trees
{
    public class TreeNode<T>
    {
        public TreeNode()
        {
        }

        public TreeNode(T value)
        {
            Value = value;
        }

        public TreeNode(IEnumerable<TreeNode<T>> children)
        {
            Children.AddRange(children);
        }

        public TreeNode(T value, IEnumerable<TreeNode<T>> children)
        {
            Value = value;
            Children.AddRange(children);
        }

        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; } = new();
    }
}
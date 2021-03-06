namespace CTCI.Ch_04_Trees
{
    public class BinaryTreeNode<T>
    {
        public BinaryTreeNode()
        {
        }

        public BinaryTreeNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }
    }
}
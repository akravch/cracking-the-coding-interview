namespace CTCI.Ch_04_Trees
{
    public class BinaryTreeNodeWithParent<T>
    {
        private BinaryTreeNodeWithParent(
            BinaryTreeNodeWithParent<T> left,
            BinaryTreeNodeWithParent<T> right,
            BinaryTreeNodeWithParent<T> parent,
            T value)
        {
            Value = value;
            Right = right;
            Parent = parent;
            Left = left;
        }

        public BinaryTreeNodeWithParent(T value)
        {
            Value = value;
        }

        public BinaryTreeNodeWithParent<T> Left { get; private set; }
        public BinaryTreeNodeWithParent<T> Right { get; private set; }
        public BinaryTreeNodeWithParent<T> Parent { get; }
        public T Value { get; }

        public BinaryTreeNodeWithParent<T> CreateLeft(T value)
        {
            Left = new BinaryTreeNodeWithParent<T>(
                left: null,
                right: null,
                parent: this,
                value);
            return Left;
        }

        public BinaryTreeNodeWithParent<T> CreateRight(T value)
        {
            Right = new BinaryTreeNodeWithParent<T>(
                left: null,
                right: null,
                parent: this,
                value);
            return Right;
        }

        public override string ToString()
        {
            return $"Value = {Value}, Left = {Left?.ToString() ?? "null"}, Right = {Right?.ToString() ?? "null"}";
        }
    }
}
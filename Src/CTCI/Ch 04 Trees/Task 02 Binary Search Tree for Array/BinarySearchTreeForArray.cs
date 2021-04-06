namespace CTCI.Ch_04_Trees.Task_02_Binary_Search_Tree_for_Array
{
    public class BinarySearchTreeForArray
    {
        public BinaryTreeNode<int> Create(int[] array)
        {
            return CreateTreeRecursive(array, 0, array.Length - 1);
        }

        private static BinaryTreeNode<int> CreateTreeRecursive(
            int[] array, int startIntervalIndex, int endIntervalIndex)
        {
            if (endIntervalIndex < startIntervalIndex)
            {
                return null;
            }

            var intervalRootIndex = (endIntervalIndex + startIntervalIndex) / 2;

            var leftStartIntervalIndex = startIntervalIndex;
            var leftEndIntervalIndex = intervalRootIndex - 1;

            var rightStartIntervalIndex = intervalRootIndex + 1;
            var rightEndIntervalIndex = endIntervalIndex;

            return new BinaryTreeNode<int>(array[intervalRootIndex])
            {
                Left = CreateTreeRecursive(array, leftStartIntervalIndex, leftEndIntervalIndex),
                Right = CreateTreeRecursive(array, rightStartIntervalIndex, rightEndIntervalIndex)
            };
        }
    }
}
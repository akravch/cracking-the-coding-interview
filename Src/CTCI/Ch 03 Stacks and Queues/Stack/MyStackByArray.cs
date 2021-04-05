namespace CTCI.Ch_03_Stacks_and_Queues.Stack
{
    public class MyStackByArray<T> : IStack<T>
    {
        private readonly T[] _array;

        private int _headIndex;

        public MyStackByArray(int maxCount)
        {
            _array = new T[maxCount];
            _headIndex = -1;
        }

        public int Count => _headIndex + 1;

        public void Push(T item)
        {
            _headIndex++;
            _array[_headIndex] = item;
        }

        public T Pop()
        {
            var item = _array[_headIndex];
            _headIndex--;
            return item;
        }

        public T Peek()
        {
            return _array[_headIndex];
        }
    }
}
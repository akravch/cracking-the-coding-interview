using System;
using CTCI.Ch_02_Stacks_and_Queues.Stack;

namespace CTCI.Ch_02_Stacks_and_Queues.Task_01_Three_Stacks
{
    public class ThreeStacks
    {
        private sealed class InternalStack : IStack<int>
        {
            private readonly int _startIndex;
            private readonly int _maxCount;
            private readonly int[] _array;

            private int _headIndex;

            public InternalStack(int startIndex, int maxCount, int[] array)
            {
                _startIndex = startIndex;
                _maxCount = maxCount;
                _array = array;
                _headIndex = startIndex - 1;
            }

            public int Count => _headIndex - _startIndex + 1;

            public void Push(int item)
            {
                if (Count == _maxCount)
                {
                    throw new InvalidOperationException("No room left");
                }

                _headIndex++;
                _array[_headIndex] = item;
            }

            public int Pop()
            {
                if (Count == 0)
                {
                    throw new InvalidOperationException("Stack is empty");
                }

                var item = _array[_headIndex];
                _headIndex--;
                return item;
            }

            public int Peek()
            {
                if (Count == 0)
                {
                    throw new InvalidOperationException("Stack is empty");
                }

                return _array[_headIndex];
            }
        }

        public ThreeStacks(int maxTotalCount)
        {
            var array = new int[maxTotalCount];

            var firstStart = 0;
            var firstCount = maxTotalCount / 3;

            var secondStart = firstCount + 1;
            var secondCount = maxTotalCount / 3;

            var thirdStart = secondCount + 1;
            var thirdCount = maxTotalCount - secondCount - firstCount;

            First = new InternalStack(firstStart, firstCount, array);
            Second = new InternalStack(secondStart, secondCount, array);
            Third = new InternalStack(thirdStart, thirdCount, array);
        }

        public IStack<int> First { get; }
        public IStack<int> Second { get; }
        public IStack<int> Third { get; }
    }
}
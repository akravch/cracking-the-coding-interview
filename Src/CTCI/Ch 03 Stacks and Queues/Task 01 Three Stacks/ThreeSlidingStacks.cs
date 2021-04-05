using System;
using CTCI.Ch_03_Stacks_and_Queues.Stack;

namespace CTCI.Ch_03_Stacks_and_Queues.Task_01_Three_Stacks
{
    public class ThreeSlidingStacks
    {
        private sealed class InternalStack : IStack<int>
        {
            private readonly int[] _array;
            private readonly Action<InternalStack> _requestResize;

            private int _startIndex;
            private int _headIndex;
            private int _maxCount;

            public InternalStack(int startIndex, int maxCount, int[] array, Action<InternalStack> requestResize)
            {
                _startIndex = startIndex;
                _maxCount = maxCount;
                _array = array;
                _requestResize = requestResize;
                _headIndex = startIndex - 1;
            }

            public int Count => _headIndex - _startIndex + 1;
            public bool IsFull => Count == _maxCount;

            public void Push(int item)
            {
                if (Count == _maxCount)
                {
                    _requestResize(this);
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

            public void MoveForward()
            {
                for (var i = _headIndex; i >= _startIndex; i--)
                {
                    _array[i + 1] = _array[i];
                }

                _startIndex++;
                _headIndex++;
            }

            public void MoveBackward()
            {
                for (var i = 0; i < _headIndex + 1; i++)
                {
                    _array[i - 1] = _array[i];
                }

                _startIndex--;
                _headIndex--;
            }

            public void IncrementMaxCount()
            {
                _maxCount++;
            }

            public void DecrementMaxCount()
            {
                if (Count == _maxCount)
                {
                    throw new InvalidOperationException("Cannot increment max count");
                }

                _maxCount--;
            }
        }

        private readonly int[] _array;
        private readonly InternalStack _first;
        private readonly InternalStack _second;
        private readonly InternalStack _third;

        public ThreeSlidingStacks(int maxTotalCount)
        {
            _array = new int[maxTotalCount];

            var firstStart = 0;
            var firstCount = maxTotalCount / 3;

            var secondStart = firstCount + 1;
            var secondCount = maxTotalCount / 3;

            var thirdStart = secondCount + 1;
            var thirdCount = maxTotalCount - secondCount - firstCount;

            _first = new InternalStack(firstStart, firstCount, _array, OnResizeRequested);
            _second = new InternalStack(secondStart, secondCount, _array, OnResizeRequested);
            _third = new InternalStack(thirdStart, thirdCount, _array, OnResizeRequested);
        }

        public IStack<int> First => _first;
        public IStack<int> Second => _second;
        public IStack<int> Third => _third;

        private void OnResizeRequested(InternalStack stack)
        {
            if (First.Count + Second.Count + Third.Count == _array.Length)
            {
                throw new InvalidOperationException("No more room");
            }

            if (stack == _first)
            {
                if (_second.IsFull)
                {
                    _third.MoveForward();
                    _third.DecrementMaxCount();
                    _second.MoveForward();
                }
                else
                {
                    _second.MoveForward();
                    _second.DecrementMaxCount();
                }

                _first.IncrementMaxCount();
            }
            else if (stack == _second)
            {
                if (_third.IsFull)
                {
                    _first.DecrementMaxCount();
                    _second.MoveBackward();
                }
                else
                {
                    _third.MoveForward();
                    _third.DecrementMaxCount();
                }

                _second.IncrementMaxCount();
            }
            else if (stack == _third)
            {
                if (_second.IsFull)
                {
                    _first.DecrementMaxCount();
                    _second.MoveBackward();
                }
                else
                {
                    _second.DecrementMaxCount();
                }

                _third.MoveBackward();
                _third.IncrementMaxCount();
            }
        }
    }
}
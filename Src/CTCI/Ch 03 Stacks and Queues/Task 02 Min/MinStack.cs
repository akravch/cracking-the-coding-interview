using System.Collections.Generic;

namespace CTCI.Ch_03_Stacks_and_Queues.Task_02_Min
{
    public class MinStack
    {
        private readonly List<int> _items = new();
        private readonly List<int> _minItems = new();

        private int _headIndex = -1;
        private int _minIndex = -1;

        public void Push(int item)
        {
            _items.Add(item);
            _headIndex++;

            if (_minIndex == -1)
            {
                _minItems.Add(item);
                _minIndex = 0;
            }
            else if (item <= _minItems[_minIndex])
            {
                _minItems.Add(item);
                _minIndex++;
            }
        }

        public int Pop()
        {
            var item = _items[_headIndex];

            _items.RemoveAt(_headIndex);
            _headIndex--;

            if (item == _minItems[_minIndex])
            {
                _minItems.RemoveAt(_minIndex);
                _minIndex--;
            }

            return item;
        }

        public int Count => _headIndex + 1;
        public int Min => _minItems[_minIndex];
    }
}
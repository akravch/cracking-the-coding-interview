using System.Collections.Generic;
using System.Linq;

namespace CTCI.Ch_03_Stacks_and_Queues.Task_03_Set_of_Stacks
{
    public class SetOfStacks
    {
        private readonly List<Stack<int>> _stacks;
        private readonly int _stackCapacity;

        public SetOfStacks(int stackCapacity)
        {
            _stacks = new List<Stack<int>>();
            _stackCapacity = stackCapacity;
        }

        public int Count { private set; get; }

        public void Push(int item)
        {
            if (_stacks.Count == 0)
            {
                _stacks.Add(new Stack<int>());
            }

            var stackIndex = _stacks.Count - 1;
            var stack = _stacks[stackIndex];

            if (stack.Count == _stackCapacity)
            {
                stack = new Stack<int>();
                _stacks.Add(stack);
            }

            stack.Push(item);
            Count++;
        }

        public int Pop()
        {
            var stackIndex = _stacks.Count - 1;
            var stack = _stacks.Last();
            var item = stack.Pop();

            if (stack.Count == 0)
            {
                _stacks.RemoveAt(stackIndex);
            }

            Count--;

            return item;
        }

        public int PopAt(int stackIndex)
        {
            if (stackIndex == _stacks.Count - 1)
            {
                return Pop();
            }

            var previousStack = _stacks[stackIndex];
            var bufferStack = new Stack<int>();
            var item = previousStack.Pop();

            for (var i = stackIndex + 1; i < _stacks.Count; i++)
            {
                var currentStack = _stacks[i];

                while (currentStack.Count > 0)
                {
                    bufferStack.Push(currentStack.Pop());
                }

                previousStack.Push(bufferStack.Pop());

                while (bufferStack.Count > 0)
                {
                    currentStack.Push(bufferStack.Pop());
                }
            }

            Count--;

            return item;
        }
    }
}
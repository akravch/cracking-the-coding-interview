using System.Collections.Generic;

namespace CTCI.Ch_03_Stacks_and_Queues.Task_04_Queue_of_Two_Stacks
{
    public class QueueOfTwoStacks
    {
        private readonly Stack<int> _first = new();
        private readonly Stack<int> _second = new();

        public int Count => _first.Count + _second.Count;

        public void Enqueue(int item)
        {
            while (_second.Count > 0)
            {
                _first.Push(_second.Pop());
            }

            _first.Push(item);
        }

        public int Dequeue()
        {
            while (_first.Count > 0)
            {
                _second.Push(_first.Pop());
            }

            return _second.Pop();
        }
    }
}
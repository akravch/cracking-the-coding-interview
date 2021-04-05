using System.Collections.Generic;

namespace CTCI.Ch_03_Stacks_and_Queues.Task_05_Sort_Stack
{
    public class SortStack
    {
        public void Sort1(Stack<int> stack)
        {
            if (stack.Count < 2)
            {
                return;
            }

            var tempStack = new Stack<int>();

            while (true)
            {
                var hadSwaps = false;

                tempStack.Push(stack.Pop());

                while (stack.Count > 0)
                {
                    var first = stack.Pop();
                    var second = tempStack.Pop();

                    if (first >= second)
                    {
                        tempStack.Push(second);
                        tempStack.Push(first);
                    }
                    else
                    {
                        tempStack.Push(first);
                        tempStack.Push(second);
                        hadSwaps = true;
                    }
                }

                // Can do the same backwards
                while (tempStack.Count > 0)
                {
                    stack.Push(tempStack.Pop());
                }

                if (!hadSwaps)
                {
                    break;
                }
            }
        }

        public void Sort2(Stack<int> stack)
        {
            var sortedStack = new Stack<int>();

            while (stack.Count > 0)
            {
                var item = stack.Pop();

                while (sortedStack.Count > 0)
                {
                    var sortedItem = sortedStack.Pop();

                    if (sortedItem <= item)
                    {
                        sortedStack.Push(sortedItem);
                        break;
                    }

                    stack.Push(sortedItem);
                }

                sortedStack.Push(item);
            }

            while (sortedStack.Count > 0)
            {
                stack.Push(sortedStack.Pop());
            }
        }
    }
}
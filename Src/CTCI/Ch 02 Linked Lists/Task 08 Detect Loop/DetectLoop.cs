using System.Collections.Generic;

namespace CTCI.Ch_02_Linked_Lists.Task_08_Detect_Loop
{
    public class DetectLoop
    {
        public LinkedListNode<int> GetLoopStart1(LinkedListNode<int> head)
        {
            var visitedNodes = new HashSet<LinkedListNode<int>>();
            var current = head;

            while (current != null)
            {
                if (!visitedNodes.Add(current))
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        public LinkedListNode<int> GetLoopStart2(LinkedListNode<int> head)
        {
            var currentSlow = head;
            var currentFast = head;

            while (currentFast?.Next != null)
            {
                currentSlow = currentSlow.Next;
                currentFast = currentFast.Next.Next;

                if (currentSlow == currentFast)
                {
                    break;
                }
            }

            if (currentFast?.Next == null)
            {
                return null;
            }

            currentSlow = head;

            while (currentSlow != currentFast)
            {
                currentSlow = currentSlow.Next;
                currentFast = currentFast.Next;
            }

            return currentSlow;
        }
    }
}
using System.Collections.Generic;

namespace CTCI.Ch_04_Trees.Task_01_Check_Path_Exists
{
    public class CheckPathExists
    {
        public bool Check(TreeNode<int> node1, TreeNode<int> node2)
        {
            var visitedNodes = new List<TreeNode<int>>();
            var visitQueue = new Queue<TreeNode<int>>();

            visitQueue.Enqueue(node1);

            while (visitQueue.Count > 0)
            {
                var node = visitQueue.Dequeue();

                if (node == node2)
                {
                    return true;
                }

                visitedNodes.Add(node);

                foreach (var child in node.Children)
                {
                    if (!visitedNodes.Contains(child))
                    {
                        visitQueue.Enqueue(child);
                    }
                }
            }

            return false;
        }
    }
}
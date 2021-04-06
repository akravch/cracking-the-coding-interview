using System.Collections.Generic;

namespace CTCI.Ch_04_Trees.Task_03_Linked_List_for_Levels
{
    public class LinkedListForLevels
    {
        public List<LinkedList<BinaryTreeNode<int>>> Create(BinaryTreeNode<int> root)
        {
            var result = new List<LinkedList<BinaryTreeNode<int>>>();
            var currentLevel = new LinkedList<BinaryTreeNode<int>>();
            currentLevel.AddLast(root);

            while (currentLevel.Count > 0)
            {
                result.Add(currentLevel);
                var parents = currentLevel;
                currentLevel = new LinkedList<BinaryTreeNode<int>>();

                foreach (var parent in parents)
                {
                    if (parent.Left != null)
                    {
                        currentLevel.AddLast(parent.Left);
                    }

                    if (parent.Right != null)
                    {
                        currentLevel.AddLast(parent.Right);
                    }
                }
            }

            return result;
        }
    }
}
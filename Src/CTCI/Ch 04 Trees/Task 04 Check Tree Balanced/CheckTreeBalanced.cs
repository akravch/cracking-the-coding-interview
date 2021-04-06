using System;
using System.Collections.Generic;

namespace CTCI.Ch_04_Trees.Task_04_Check_Tree_Balanced
{
    public class CheckTreeBalanced
    {
        public bool IsBalanced(BinaryTreeNode<int> root)
        {
            var currentLevelNodes = new List<BinaryTreeNode<int>> { root };
            var currentLevel = 0;

            while (currentLevelNodes.Count > 0)
            {
                var parentNodes = currentLevelNodes;
                currentLevelNodes = new List<BinaryTreeNode<int>>();

                foreach (var parentNode in parentNodes)
                {
                    if (parentNode.Left != null)
                    {
                        currentLevelNodes.Add(parentNode.Left);
                    }

                    if (parentNode.Right != null)
                    {
                        currentLevelNodes.Add(parentNode.Right);
                    }
                }

                var parentLevelCapacity = (int) Math.Pow(2, currentLevel);
                var isParentLevelFull = parentNodes.Count == parentLevelCapacity;

                if (!isParentLevelFull)
                {
                    var isLastLevel = currentLevelNodes.Count == 0;

                    if (!isLastLevel)
                    {
                        return false;
                    }
                }

                currentLevel++;
            }

            return true;
        }
    }
}
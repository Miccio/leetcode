using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    class _0222_Count_Complete_Tree_Nodes
    {
        /**
         * Definition for a binary tree node.
         * public class TreeNode {
         *     public int val;
         *     public TreeNode left;
         *     public TreeNode right;
         *     public TreeNode(int x) { val = x; }
         * }
         */
        public class Solution
        {
            public int CountNodes(TreeNode root)
            {
                if (root == null)
                {
                    return 0;
                }
                int left = CountLevel(root.left);
                int right = CountLevel(root.right);
                if (left == right)
                {
                    return CountNodes(root.right) + (1 << left);
                }
                else
                {
                    return CountNodes(root.left) + (1 << right);
                }
            }
            private int CountLevel(TreeNode root)
            {
                int level = 0;
                while (root != null)
                {
                    level++;
                    root = root.left;
                }
                return level;
            }

            public int CountNodes2(TreeNode root)
            {
                var nodeCount = 0;
                VisitTree(root, ref nodeCount, out int _, out bool _, out bool _);
                return nodeCount;
            }

            public void VisitTree(TreeNode root, ref int nodeCount, out int height, out bool isComplete, out bool isNotComplete)
            {
                if (root == null)
                {
                    height = 0;
                    isComplete = true;
                    isNotComplete = false;
                    return;
                }

                int leftH, rightH;
                bool isLeftC, isLeftNotC, isRightC, isRightNotC;
                VisitTree(root.left, ref nodeCount, out leftH, out isLeftC, out isLeftNotC);
                VisitTree(root.right, ref nodeCount, out rightH, out isRightC, out isRightNotC);

                if (isLeftNotC || isRightNotC)
                {
                    height = -1;
                    isComplete = false;
                    isNotComplete = true;
                    return;
                }

                if (isLeftC && isRightC)
                {
                    if (leftH == rightH)
                    {
                        height = leftH + 1;
                        isComplete = true;
                        isNotComplete = false;
                        nodeCount++;
                        return;
                    }
                    else if (leftH == rightH + 1)
                    {
                        height = leftH + 1;
                        isComplete = false;
                        isNotComplete = false;
                        nodeCount++;
                        return;
                    }
                }
                else if (isLeftC && !isRightC)
                {
                    if (leftH == rightH)
                    {
                        height = leftH + 1;
                        isComplete = false;
                        isNotComplete = false;
                        nodeCount++;
                        return;
                    }
                }
                else if (!isLeftC && isRightC)
                {
                    if (leftH == rightH + 1)
                    {
                        height = leftH + 1;
                        isComplete = false;
                        isNotComplete = false;
                        nodeCount++;
                        return;
                    }
                }

                height = -1;
                isComplete = false;
                isNotComplete = true;
            }
        }
    }
}

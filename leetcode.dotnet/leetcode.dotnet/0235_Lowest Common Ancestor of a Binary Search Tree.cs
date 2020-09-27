using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0235_Lowest_Common_Ancestor_of_a_Binary_Search_Tree
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
            public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
            {
                return LowestCommonAncestor(root, p, q, out var nodeCnt);
            }

            public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q, out int nodeCnt)
            {
                if (root == null)
                {
                    nodeCnt = 0;
                    return null;
                }

                var node = LowestCommonAncestor(root.left, p, q, out var leftcnt);
                if (leftcnt == 2)
                {
                    nodeCnt = 2;
                    return node;
                }

                node = LowestCommonAncestor(root.right, p, q, out var rightcnt);
                if (rightcnt == 2)
                {
                    nodeCnt = 2;
                    return node;
                }

                var sumcnt = leftcnt + rightcnt;
                if (sumcnt == 2)
                {
                    nodeCnt = 2;
                    return root;
                }

                if (root == p || root == q)
                {
                    sumcnt++;
                }

                if (sumcnt == 2)
                {
                    nodeCnt = 2;
                    return root;
                }

                nodeCnt = sumcnt;
                return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0617_Merge_Two_Binary_Trees
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
            public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
            {
                if (t1 == null && t2 == null)
                {
                    return null;
                }

                var node = new TreeNode(0);
                node.val = (t1?.val ?? 0) + (t2?.val ?? 0);
                node.left = MergeTrees(t1?.left, t2?.left);
                node.right = MergeTrees(t1?.right, t2?.right);

                return node;
            }
        }
    }
}

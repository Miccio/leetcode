using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0145_Binary_Tree_Postorder_Traversal
    {
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
        public class Solution
        {
            public IList<int> PostorderTraversal(TreeNode root)
            {
                var ret = new List<int>();
                var stack = new Stack<TreeNode>();
                TreeNode prev = null;
                while (root != null || stack.Count > 0)
                {
                    while (root != null)
                    {
                        stack.Push(root);
                        root = root.left;
                    }

                    root = stack.Pop();
                    if (root.right == null || root.right == prev)
                    {
                        ret.Add(root.val);
                        prev = root;
                        root = null;
                    }
                    else
                    {
                        stack.Push(root);
                        root = root.right;
                    }
                }

                return ret;
            }
        }
    }
}

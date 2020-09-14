using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0094_Binary_Tree_Inorder_Traversal
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
            public IList<int> InorderTraversal(TreeNode root)
            {
                IList<int> nums = new List<int>();

                InorderTraversal(root, ref nums);
                return nums;
            }

            public void InorderTraversal(TreeNode root, ref IList<int> nums)
            {
                if (root == null)
                {
                    return;
                }

                if (root.left != null)
                {
                    InorderTraversal(root.left, ref nums);
                }

                nums.Add(root.val);

                if (root.right != null)
                {
                    InorderTraversal(root.right, ref nums);
                }
            }
        }
    }
}
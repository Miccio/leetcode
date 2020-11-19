using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0530_Minimum_Absolute_Difference_in_BST
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
            public int GetMinimumDifference(TreeNode root)
            {
                var nums = new List<int>();
                VisitTree(root, nums);
                nums.Sort();
                var min = int.MaxValue;
                for (var i = 0; i < nums.Count - 1; i++)
                {
                    var diff = nums[i + 1] - nums[i];
                    if (diff < min)
                    {
                        min = diff;
                    }
                }

                return min;
            }

            public void VisitTree(TreeNode root, List<int> nums)
            {
                if (root != null)
                {
                    nums.Add(root.val);
                    VisitTree(root.left, nums);
                    VisitTree(root.right, nums);
                }
            }
        }
    }
}

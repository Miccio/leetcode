using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.dotnet
{
    public class _0113_Path_Sum_II
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
            public IList<IList<int>> PathSum(TreeNode root, int sum)
            {
                IList<IList<int>> ret = new List<IList<int>>();
                if (root == null)
                {
                    return ret;
                }

                var curPath = new List<int>();
                var curSum = 0;
                PathSum(root, ref curPath, curSum, sum, ref ret);

                return ret;
            }

            public void PathSum(TreeNode root, ref List<int> curPath, int curSum, int sum, ref IList<IList<int>> ret)
            {
                var curVal = root.val;
                curSum = curSum + curVal;

                if (root.left == null && root.right == null)
                {
                    if (curSum == sum)
                    {
                        var path = curPath.Select(n => n).ToList();
                        path.Add(curVal);
                        ret.Add(path);
                    }

                    return;
                }

                curPath.Add(curVal);
                if (root.left != null)
                {
                    PathSum(root.left, ref curPath, curSum, sum, ref ret);
                }

                if (root.right != null)
                {
                    PathSum(root.right, ref curPath, curSum, sum, ref ret);
                }

                curPath.RemoveAt(curPath.Count - 1);
                return;
            }
        }
    }
}

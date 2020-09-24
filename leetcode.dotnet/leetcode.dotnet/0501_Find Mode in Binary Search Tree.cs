using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.dotnet
{
    public class _0501_Find_Mode_in_Binary_Search_Tree
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
            public int[] FindMode(TreeNode root)
            {
                var dict = new Dictionary<int, int>();
                FindMode(root, dict);

                if (dict.Count == 0)
                {
                    return new int[] { };
                }

                var maxCount = dict.Values.Max();
                return dict.Where(kv => kv.Value == maxCount).Select(kv => kv.Key).ToArray();
            }

            public void FindMode(TreeNode root, Dictionary<int, int> dict)
            {
                if (root == null)
                {
                    return;
                }

                var val = root.val;
                if (dict.TryGetValue(val, out var count))
                {
                    count++;
                    dict[val] = count;
                }
                else
                {
                    dict.Add(val, 1);
                }

                FindMode(root.left, dict);
                FindMode(root.right, dict);
            }
        }
    }
}

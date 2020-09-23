using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }

        public static TreeNode BuildTree(int?[] vals)
        {
            if (vals == null || vals.Length == 0 || vals[0] == null)
            {
                return null;
            }

            var i = 0;
            var queue = new Queue<TreeNode>();
            var root = new TreeNode(vals[i].Value);
            i++;
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (i < vals.Length && vals[i] != null)
                {
                    var left = new TreeNode(vals[i].Value);
                    node.left = left;
                    queue.Enqueue(left);
                }

                i++;

                if (i < vals.Length && vals[i] != null)
                {
                    var right = new TreeNode(vals[i].Value);
                    node.right = right;
                    queue.Enqueue(right);
                }

                i++;
            }

            return root;
        }
    }
}

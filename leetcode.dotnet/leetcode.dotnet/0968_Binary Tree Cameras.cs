using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0968_Binary_Tree_Cameras
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
            public int MinCameraCover(TreeNode root)
            {
                var state = MinCam(root);
                return state.MiniCovered_1;
            }

            public NodeState MinCam(TreeNode root)
            {
                var state = new NodeState();
                if (root == null)
                {
                    state.Placed_0 = int.MaxValue / 2;
                    state.MiniCovered_1 = 0;
                    state.ChildCovered_2 = 0;

                    return state;
                }

                var left = MinCam(root.left);
                var right = MinCam(root.right);

                state.Placed_0 = 1 + left.ChildCovered_2 + right.ChildCovered_2;
                state.MiniCovered_1 = Math.Min(state.Placed_0, Math.Min(left.Placed_0 + right.MiniCovered_1, left.MiniCovered_1 + right.Placed_0));
                state.ChildCovered_2 = Math.Min(state.Placed_0, left.MiniCovered_1 + right.MiniCovered_1);

                return state;
            }

            // Placed >= MinCovered >= ChildCovered
            public class NodeState
            {
                public int Placed_0;

                public int MiniCovered_1;

                public int ChildCovered_2;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0701_Insert_into_a_Binary_Search_Tree
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
            public TreeNode InsertIntoBST(TreeNode root, int val)
            {
                var newNode = new TreeNode(val);
                if (root == null)
                {
                    return newNode;
                }

                var curRoot = root;
                while (true)
                {
                    if (curRoot.val > val)
                    {
                        if (curRoot.left == null)
                        {
                            curRoot.left = newNode;
                            break;
                        }
                        else
                        {
                            curRoot = curRoot.left;
                        }
                    }
                    else
                    {
                        if (curRoot.right == null)
                        {
                            curRoot.right = newNode;
                            break;
                        }
                        else
                        {
                            curRoot = curRoot.right;
                        }
                    }
                }

                return root;
            }
        }
    }
}

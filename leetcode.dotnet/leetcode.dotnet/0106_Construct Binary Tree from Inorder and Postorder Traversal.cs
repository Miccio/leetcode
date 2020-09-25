namespace leetcode.dotnet
{
    public class _0106_Construct_Binary_Tree_from_Inorder_and_Postorder_Traversal
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
            public TreeNode BuildTree(int[] inorder, int[] postorder)
            {
                if (inorder == null || inorder.Length == 0)
                {
                    return null;
                }

                return BuildTree(inorder, 0, inorder.Length - 1, postorder, 0, postorder.Length - 1);
            }

            public TreeNode BuildTree(int[] inorder, int start1, int end1, int[] postorder, int start2, int end2)
            {
                if (start2 > end2)
                {
                    return null;
                }

                var rootVal = postorder[end2];
                var root = new TreeNode(rootVal);
                if (start2 < end2)
                {
                    int rootInd = -1;
                    for (rootInd = start1; rootInd <= end1; rootInd++)
                    {
                        if (inorder[rootInd] == rootVal)
                        {
                            break;
                        }
                    }

                    if (rootInd > -1)
                    {
                        root.left = BuildTree(inorder, start1, rootInd - 1, postorder, start2, start2 + (rootInd - 1 - start1));
                        root.right = BuildTree(inorder, rootInd + 1, end1, postorder, (end2 - 1 - (end1 - (rootInd + 1))), end2 - 1);
                    }
                }

                return root;
            }
        }
    }
}

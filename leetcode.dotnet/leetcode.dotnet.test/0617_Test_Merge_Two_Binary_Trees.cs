using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet.test
{
    [TestFixture]
    public class _0617_Test_Merge_Two_Binary_Trees
    {
        [Test]
        public void Test()
        {
            var tree1 = TreeNode.BuildTree(new int?[] { 1, 3, 2, 5 });
            var tree2 = TreeNode.BuildTree(new int?[] { 2, 1, 3, null, 4, null, 7 });

            var sol = new _0617_Merge_Two_Binary_Trees.Solution();
            var root = sol.MergeTrees(tree1, tree2);
        }
    }
}

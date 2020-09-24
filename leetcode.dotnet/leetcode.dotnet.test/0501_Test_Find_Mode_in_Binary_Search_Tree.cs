using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet.test
{
    [TestFixture]
    public class _0501_Test_Find_Mode_in_Binary_Search_Tree
    {
        [Test]
        public void Test()
        {
            var tree = TreeNode.BuildTree(new int?[] { 1, null, 2, 2 });
            var sol = new _0501_Find_Mode_in_Binary_Search_Tree.Solution();

            var modes = sol.FindMode(tree);
        }
    }
}

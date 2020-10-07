using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet.test
{
    [TestFixture]
    public class _0075_Test_Sort_Colors
    {
        [Test]
        public void Test()
        {
            var sol = new _0075_Sort_Colors.Solution();
            var nums = new int[] { 2, 0, 2, 1, 1, 0 };
            sol.SortColors(nums);
        }
    }
}

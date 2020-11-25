using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet.test
{
    [TestFixture]
    class _1370_Test_Increasing_Decreasing_String
    {
        [Test]
        public void Test()
        {
            var s = "leetcode";
            var sol = new _1370_Increasing_Decreasing_String.Solution();
            var ret = sol.SortString(s);
        }
    }
}

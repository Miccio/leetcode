using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet.test
{
    [TestFixture]
    public class _Test_0018_4Sum
    {
        [Test]
        public void Test()
        {
            /*
             [-1,0,1,2,-1,-4]
-1
             */
            var sol = new _0018_4Sum.Solution();
            var ret = sol.FourSum(new int[] { -1, 0, 1, 2, -1, -4 }, -1);
        }
    }
}

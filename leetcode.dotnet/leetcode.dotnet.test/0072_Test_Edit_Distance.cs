using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet.test
{
    [TestFixture]
    public class _0072_Test_Edit_Distance
    {
        [Test]
        public void TestMinDistance()
        {
            var word1 = "plasma";
            var word2 = "altruism";
            var sol = new _0072_Edit_Distance.Solution();
            var ret = sol.MinDistance(word1, word2);
        }
    }
}

using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet.test
{
    [TestFixture]
    class _0028_Test_Implement_strStr
    {
        [Test]
        public void Test()
        {
            var sol = new _0028_Implement_strStr.Solution();
            var ret = sol.StrStr("aabaaabaaac", "aabaaac");
        }
    }
}

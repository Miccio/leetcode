using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet.test
{
    [TestFixture]
    public class _0557_Test_Reverse_Words_in_a_String_III
    {
        [Test]
        public void Test()
        {
            var input = "I love u";
            var sol = new _0557_Reverse_Words_in_a_String_III.Solution();
            var ret = sol.ReverseWords(input);
        }
    }
}

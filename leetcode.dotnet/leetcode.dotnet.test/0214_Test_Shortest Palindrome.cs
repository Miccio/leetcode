using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet.test
{
    [TestFixture]
    class _0214_Test_Shortest_Palindrome
    {
        [Test]
        public void Test()
        {
            var input = "aacecaaa";
            var sol = new _0214_Shortest_Palindrome.Solution();
            var str = sol.ShortestPalindrome(input);
        }
    }
}

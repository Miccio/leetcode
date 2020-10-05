using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet.test
{
    [TestFixture]
    public class _0002_Test_Add_Two_Numbers
    {
        [Test]
        public void Test()
        {
            var l1 = new List<int> { 9, 9, 9, 9, 9, 9, 9 };
            var l2 = new List<int> { 9,9,9,9 };

            var sol = new _0002_Add_Two_Numbers.Solution();
            var list = sol.AddTwoNumbers(ListNode.BuildList(l1), ListNode.BuildList(l2));
            var ret = ListNode.Output(list);
        }
    }
}

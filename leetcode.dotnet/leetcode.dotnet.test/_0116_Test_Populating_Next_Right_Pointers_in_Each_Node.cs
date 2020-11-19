using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet.test
{
    [TestFixture]
    public class _0116_Test_Populating_Next_Right_Pointers_in_Each_Node
    {
        [Test]
        public void Test()
        {
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(4);
            var node5 = new Node(5);
            var node6 = new Node(6);
            var node7 = new Node(7);

            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node2.right = node5;
            node3.left = node6;
            node3.right = node7;

            var sol = new _0116_Populating_Next_Right_Pointers_in_Each_Node.Solution();
            var ret = sol.Connect(node1);
        }
    }
}

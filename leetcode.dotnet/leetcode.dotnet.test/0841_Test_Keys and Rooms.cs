using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet.test
{
    [TestFixture]
    class _0841_Test_Keys_and_Rooms
    {
        [Test]
        public void Test()
        {
            var rooms = new List<IList<int>>
            {
                new List<int> { 1 },
                new List<int> { },
                new List<int> { 0, 3 },
                new List<int> { 1 },
            };

            var sol = new _0841_Keys_and_Rooms.Solution();
            var ret = sol.CanVisitAllRooms(rooms);
        }
    }
}

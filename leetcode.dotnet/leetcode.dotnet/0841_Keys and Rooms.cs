using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace leetcode.dotnet
{
    public class _0841_Keys_and_Rooms
    {
        public class Solution
        {
            /// <summary>
            /// Convert the key info into the two directed links.
            /// In this logic, the directed cyclic graph is built.
            /// Then visit the graph starting from 0, and check the visted rooms.
            /// </summary>
            /// <param name="rooms"></param>
            /// <returns></returns>
            public bool CanVisitAllRooms(IList<IList<int>> rooms)
            {
                if (rooms == null || rooms.Count == 0)
                {
                    return false;
                }

                var roomCount = rooms.Count;
                var dict = new Dictionary<int, HashSet<int>>();
                for (var i = 0; i < roomCount; i++)
                {
                    if (rooms[i] != null)
                    {
                        foreach (var key in rooms[i])
                        {
                            if (!dict.TryGetValue(i, out var ends))
                            {
                                ends = new HashSet<int>();
                                dict.Add(i, ends);
                            }

                            if (!ends.Contains(key))
                            {
                                ends.Add(key);
                            }
                        }
                    }
                }

                var visitedRooms = new HashSet<int>();
                VisitRooms(0, dict, ref visitedRooms);
                return visitedRooms.Count == roomCount;
            }

            public void VisitRooms(int startNum, Dictionary<int, HashSet<int>> dict, ref HashSet<int> visitedRooms)
            {
                if (visitedRooms.Contains(startNum))
                {
                    return;
                }
                else
                {
                    visitedRooms.Add(startNum);
                }

                if (!dict.TryGetValue(startNum, out var ends))
                {
                    return;
                }

                foreach (var end in ends)
                {
                    VisitRooms(end, dict, ref visitedRooms);
                }
            }
        }
    }
}

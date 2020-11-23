using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace leetcode.dotnet
{
    class _0452_Minimum_Number_of_Arrows_to_Burst_Balloons
    {
        public class Solution
        {
            public int FindMinArrowShots(int[][] points)
            {
                if (points == null || points.Length == 0)
                {
                    return 0;
                }

                Array.Sort(points, (p1, p2) => p1[1].CompareTo(p2[1]));
                int last = points[0][1];
                var count = 1;
                for (var i = 1; i < points.Length; i++)
                {
                    if (last < points[i][0])
                    {
                        last = points[i][1];
                        count++;
                    }
                }

                return count;
            }
        }
    }
}

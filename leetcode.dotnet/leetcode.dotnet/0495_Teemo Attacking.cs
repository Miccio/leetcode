using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0495_Teemo_Attacking
    {
public class Solution
{
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        int ret = 0;
        if (timeSeries == null || timeSeries.Length == 0)
        {
            return ret;
        }

        int preEnd = 0;
        for (var i = 0; i < timeSeries.Length; i++)
        {
            var start = timeSeries[i];
            var end = start + duration;
            if (start < preEnd)
            {
                start = preEnd;
            }

            ret += (end - start);
            preEnd = end;
        }

        return ret;
    }
}
    }
}

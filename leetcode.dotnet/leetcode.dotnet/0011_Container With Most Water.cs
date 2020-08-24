using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0011_Container_With_Most_Water
    {
public class Solution
{
    public int MaxArea(int[] height)
    {
        if (height == null || height.Length == 0)
        {
            return 0;
        }

        var i = 0;
        var j = height.Length - 1;
        var maxArea = 0;
        while (i < j)
        {
            var curArea = Math.Min(height[i], height[j]) * (j - i);
            maxArea = Math.Max(curArea, maxArea);
            if (height[i] < height[j])
            {
                i++;
            }
            else
            {
                j--;
            }
        }

        return maxArea;
    }
}
    }
}

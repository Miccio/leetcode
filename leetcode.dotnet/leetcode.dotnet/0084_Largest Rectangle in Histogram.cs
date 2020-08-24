using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.dotnet
{
    public class _0084_Largest_Rectangle_in_Histogram
    {
public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        if (heights == null || heights.Length == 0)
        {
            return 0;
        }

        var hs = heights.ToList();
        hs.Add(0);
        var s = new Stack<int>();
        var maxArea = 0;
        for (var i = 0; i < hs.Count; i++)
        {
            while (s.Any() && hs[i] < hs[s.Peek()])
            {
                var j = s.Pop();
                int area = 0;
                if (s.Any())
                {
                    area = hs[j] * (i - 1 - s.Peek());
                }
                else
                {
                    area = hs[j] * i;
                }

                maxArea = Math.Max(area, maxArea);
            }

            s.Push(i);
        }

        return maxArea;
    }
}
    }
}

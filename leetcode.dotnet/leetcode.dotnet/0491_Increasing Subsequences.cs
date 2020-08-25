using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace leetcode.dotnet
{
    class _0491_Increasing_Subsequences
    {
public class Solution
{
    public IList<IList<int>> FindSubsequences(int[] nums)
    {
        IList<IList<int>> retNums = new List<IList<int>>();
        if (nums == null || nums.Length < 2)
        {
            return retNums;
        }

        var set = new HashSet<string>();
        for (var i = 0; i < nums.Length - 1; i++)
        {
            FindSubsequences(nums, i + 1, new List<int> { nums[i] }, retNums, set );
        }

        return retNums;
    }

    public void FindSubsequences(int[] nums, int start, IList<int> subNums, IList<IList<int>> retNums, HashSet<string> set)
    {
        if (start == nums.Length)
        {
            return;
        }

        for (var i = start; i < nums.Length; i++)
        {
            if (nums[i] >= subNums.Last())
            {
                IList<int> curNums = new List<int>(subNums);
                curNums.Add(nums[i]);
                var curStr = string.Join("_", curNums);
                if (!set.Contains(curStr))
                {
                    set.Add(curStr);
                    retNums.Add(curNums);

                    FindSubsequences(nums, i + 1, curNums, retNums, set);
                }
            }
        }
    }
}
    }
}

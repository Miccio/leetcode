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

        var hashSet = new HashSet<long>();
        for (var i = 0; i < nums.Length - 1; i++)
        {
            FindSubsequences(nums, i + 1, new List<int> { nums[i] }, retNums, hashSet);
        }

        return retNums;
    }

    public void FindSubsequences(int[] nums, int start, IList<int> subNums, IList<IList<int>> retNums, HashSet<long> hashSet)
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
                var curHash = GetHash(curNums);
                if (!hashSet.Contains(curHash))
                {
                    hashSet.Add(curHash);
                    retNums.Add(curNums);

                    FindSubsequences(nums, i + 1, curNums, retNums, hashSet);
                }
            }
        }
    }

    public long GetHash(IList<int> nums)
    {
        long hash = 0;
        if (nums == null || nums.Count == 0)
        {
            return -1;
        }

        foreach (var num in nums)
        {
            // num + bias should greater than 0, because if num + bias == 0, hash == 0.
            hash = hash * (1009 % (((long)10E9) + 7)) + (num + 101);
        }

        return hash;
    }
}
    }
}

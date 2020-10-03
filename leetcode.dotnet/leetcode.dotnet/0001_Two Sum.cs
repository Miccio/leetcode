using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0001_Two_Sum
    {
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                var newNums = new int[nums.Length];
                nums.CopyTo(newNums, 0);
                Array.Sort(newNums);

                int i = 0, j = newNums.Length - 1, sum = int.MaxValue;
                while (i < j)
                {
                    sum = newNums[i] + newNums[j];
                    if (target == sum)
                    {
                        for (var m = 0; m < nums.Length; m++)
                        {
                            if (nums[m] == newNums[i])
                            {
                                for (var n = nums.Length - 1; n >= 0; n--)
                                {
                                    if (nums[n] == newNums[j])
                                    {
                                        return new int[] { m, n };
                                    }
                                }
                            }
                        }
                    }
                    else if (target > sum)
                    {
                        i++;
                    }
                    else
                    {
                        j--;
                    }
                }

                return null;
            }
        }
    }
}

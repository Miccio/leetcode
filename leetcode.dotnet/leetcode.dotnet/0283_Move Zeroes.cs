using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0283_Move_Zeroes
    {
        public class Solution
        {
            public void MoveZeroes(int[] nums)
            {
                if (nums == null && nums.Length == 0)
                {
                    return;
                }

                var len = nums.Length;

                int p0 = 0, p1 = 0;
                while (p0 < len && p1 < len)
                {
                    if (p0 < len && nums[p0] != 0)
                    {
                        p0++;
                    }

                    if (p1 < len && nums[p1] == 0)
                    {
                        p1++;
                    }

                    while (p0 < len && p1 < len && nums[p0] == 0 && nums[p1] != 0)
                    {
                        if (p0 < p1)
                        {
                            nums[p0] = nums[p1];
                            nums[p1] = 0;
                            p0++;
                            p1++;
                        }
                        else
                        {
                            p1++;
                        }
                    }
                }
            }
        }
    }
}

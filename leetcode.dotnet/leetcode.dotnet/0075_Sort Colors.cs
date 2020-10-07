using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0075_Sort_Colors
    {
        public class Solution
        {
            public void SortColors(int[] nums)
            {
                var p0 = 0;
                var p2 = nums.Length - 1;
                var i = 0;
                while (i < nums.Length && i <= p2)
                {
                    if (nums[i] == 0)
                    {
                        Swap(nums, p0, i);
                        i++;
                        p0++;
                    }
                    else if (nums[i] == 2)
                    {
                        Swap(nums, p2, i);
                        p2--;
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            public static void Swap(int[] nums, int i, int j)
            {
                var tmp = nums[i];
                nums[i] = nums[j];
                nums[j] = tmp;
            }
        }
    }
}

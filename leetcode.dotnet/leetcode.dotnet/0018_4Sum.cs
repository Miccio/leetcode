using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0018_4Sum
    {
        public class Solution
        {
            public IList<IList<int>> FourSum(int[] nums, int target)
            {
                var ret = new List<IList<int>>();
                Array.Sort(nums);

                for (var a = 0; a <= nums.Length - 4; a++)
                {
                    if (a > 0 && nums[a] == nums[a - 1])
                    {
                        continue;
                    }

                    if (nums[a] + nums[a + 1] + nums[a + 2] + nums[a + 3] > target)
                    {
                        break;
                    }

                    if (nums[a] + nums[nums.Length - 3] + nums[nums.Length - 2] + nums[nums.Length - 1] < target)
                    {
                        continue;
                    }

                    for (var b = a + 1; b <= nums.Length - 3; b++)
                    {
                        if (b > a + 1 && nums[b] == nums[b - 1])
                        {
                            continue;
                        }

                        if (nums[a] + nums[b] + nums[b + 1] + nums[b + 2] > target)
                        {
                            break;
                        }

                        if (nums[a] + nums[b] + nums[nums.Length - 2] + nums[nums.Length - 1] < target)
                        {
                            continue;
                        }

                        var c = b + 1;
                        var d = nums.Length - 1;
                        while (c < d)
                        {
                            var sum = nums[a] + nums[b] + nums[c] + nums[d];
                            if (sum < target)
                            {
                                c++;
                            }
                            else if (sum > target)
                            {
                                d--;
                            }
                            else
                            {
                                var list = new List<int> { nums[a], nums[b], nums[c], nums[d] };
                                ret.Add(list);
                                while (c < d && nums[c] == nums[c + 1])
                                {
                                    c++;
                                }

                                c++;

                                while (c < d && nums[d] == nums[d - 1])
                                {
                                    d--;
                                }

                                d--;
                            }
                        }
                    }
                }

                return ret;
            }
        }
    }
}

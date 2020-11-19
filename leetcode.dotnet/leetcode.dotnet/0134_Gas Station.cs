using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    class _0134_Gas_Station
    {
        public class Solution
        {
            public int CanCompleteCircuit(int[] gas, int[] cost)
            {
                var len = gas.Length;

                /*
                var diff = new int[len];
                var sum = 0;
                for (var i = 0; i < len; i++)
                {
                    diff[i] = gas[i] - cost[i];
                    sum += diff[i];
                }

                if (sum < 0)
                {
                    return -1;
                }
                */

                int sum = 0;
                int start = 0;
                while (start < len)
                {
                    sum = 0;
                    for (var i = 0; i < len; i++)
                    {
                        var j = (start + i) % len;
                        sum += (gas[j] - cost[j]);
                        if (sum < 0)
                        {
                            start = start + i + 1;
                            break;
                        }

                        if (i == len - 1)
                        {
                            return start;
                        }
                    }
                }

                return -1;
            }
        }
    }
}

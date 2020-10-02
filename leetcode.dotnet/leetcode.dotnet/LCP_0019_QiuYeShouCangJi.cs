using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class LCP_0019_QiuYeShouCangJi
    {
        public class Solution
        {
            // "ryr"
            // three state: left r, middle y, right r
            public int MinimumOperations(string leaves)
            {
                var state = new int[leaves.Length, 3];
                state[0, 0] = leaves[0] == 'y' ? 1 : 0;
                state[0, 1] = int.MaxValue;
                state[0, 2] = int.MaxValue;

                for (var i = 1; i < leaves.Length; i++)
                {
                    state[i, 0] = state[i - 1, 0] + (leaves[i] == 'y' ? 1 : 0);
                    state[i, 1] = Math.Min(state[i - 1, 0], state[i - 1, 1]) + (leaves[i] == 'y' ? 0 : 1);
                    if (i == 1)
                    {
                        state[i, 2] = int.MaxValue;
                    }
                    else
                    {
                        state[i, 2] = Math.Min(state[i - 1, 1], state[i - 1, 2]) + (leaves[i] == 'y' ? 1 : 0);
                    }
                }

                return state[leaves.Length - 1, 2];
            }
        }
    }
}

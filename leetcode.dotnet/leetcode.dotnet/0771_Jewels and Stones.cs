using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0771_Jewels_and_Stones
    {
        public class Solution
        {
            public int NumJewelsInStones(string J, string S)
            {
                var set = new HashSet<char>();
                foreach(var c in J.ToCharArray())
                {
                    set.Add(c);
                }

                var cnt = 0;
                foreach (var c in S.ToCharArray())
                {
                    if (set.Contains(c))
                    {
                        cnt++;
                    }
                }

                return cnt;
            }
        }
    }
}

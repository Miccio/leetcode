using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.dotnet
{
    public class _1002_Find_Common_Characters
    {
        public class Solution
        {
            public IList<string> CommonChars(string[] A)
            {
                var len = A.Length;
                var map = new Dictionary<char, int[]>();

                for (var i = 0; i < len; i++)
                {
                    foreach (var ch in A[i])
                    {
                        int[] cnts = null;
                        if (i == 0)
                        {
                            if (!map.TryGetValue(ch, out cnts))
                            {
                                cnts = new int[len];
                                map.Add(ch, cnts);
                            }

                            cnts[i] = cnts[i] + 1;
                        }
                        else
                        {
                            if (map.TryGetValue(ch, out cnts))
                            {
                                cnts[i] = cnts[i] + 1;
                            }
                        }
                    }
                }

                var ret = new List<string>();
                foreach (var key in map.Keys)
                {
                    var cnts = map[key];
                    var minCnt = cnts.Min();
                    for (var i = 1; i <= minCnt; i++)
                    {
                        ret.Add(key.ToString());
                    }
                }

                return ret;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode.dotnet
{
    public class _0332_Reconstruct_Itinerary
    {
        public class Solution
        {
            public IList<string> FindItinerary(IList<IList<string>> tickets)
            {
                var ret = new List<string>();
                var dict = new Dictionary<string, List<DstValue>>();
                foreach (var t in tickets)
                {
                    if (!dict.TryGetValue(t[0], out var dstVal))
                    {
                        dstVal = new List<DstValue>();
                        dict.Add(t[0], dstVal);
                    }

                    dstVal.Add(new DstValue { Dst = t[1] });
                }

                foreach (var value in dict.Values)
                {
                    value.Sort((x, y) => x.Dst.CompareTo(y.Dst));
                }

                var src = "JFK";
                ret.Add(src);

                Dfs(src, ref ret, dict, tickets.Count + 1);
                return ret;
            }

            public void Dfs(string src, ref List<string> ret, Dictionary<string, List<DstValue>> dict, int count)
            {
                if (ret.Count == count)
                {
                    return;
                }

                if (dict.TryGetValue(src, out var dstvals))
                {
                    foreach (var dstval in dstvals)
                    {
                        if (dstval.Visited == false)
                        {
                            ret.Add(dstval.Dst);
                            dstval.Visited = true;
                            Dfs(dstval.Dst, ref ret, dict, count);
                            if (ret.Count == count)
                            {
                                break;
                            }

                            ret.RemoveAt(ret.Count - 1);
                            dstval.Visited = false;
                        }
                    }
                }
            }

            public class DstValue
            {
                public string Dst;

                public bool Visited = false;
            }
        }
    }
}

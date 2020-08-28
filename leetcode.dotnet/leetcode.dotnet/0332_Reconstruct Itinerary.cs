using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.dotnet
{
    class _0332_Reconstruct_Itinerary
    {
        public class Solution
        {
            public IList<string> FindItinerary(IList<IList<string>> tickets)
            {
                var ret = new List<string>();
                var dict = new Dictionary<string, IList<IList<string>>>();

                foreach (var ticket in tickets)
                {
                    var src = ticket[0];
                    if (!dict.ContainsKey(src))
                    {
                        dict.Add(src, new List<IList<string>>());
                    }

                    var ts = dict[src];
                    ts.Add(ticket);
                }

                var dict2 = new Dictionary<string, IList<IList<string>>>();
                foreach (var src in dict.Keys)
                {
                    dict2.Add(src, dict[src].OrderBy(t => t[1]).ToList());
                }

                dict = dict2;

                var preDst = "JFK";
                ret.Add(preDst);
                for (var i = 1; i <= tickets.Count; i++)
                    {
                        var j = 0;
                        var ts = dict[preDst];
                        var t = ts[j++];
                        if (i < tickets.Count)
                        {
                            var dst = t[1];
                            while (!dict.ContainsKey(dst) || dict[dst].Count == 0)
                            {
                                t = ts[j++];
                            }
                        }

                        preDst = t[1];
                        ret.Add(t[1]);
                        ts.Remove(t);
                    }

                return ret;
            }
        }
    }
}

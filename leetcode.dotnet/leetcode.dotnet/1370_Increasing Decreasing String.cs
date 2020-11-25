using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.dotnet
{
    public class _1370_Increasing_Decreasing_String
    {
        public class Solution
        {
            public string SortString3(string s)
            {
                int[] num = new int[26];
                for (int i = 0; i < s.Length; i++)
                {
                    num[s[i] - 'a']++;
                }

                var ret = new StringBuilder();
                while (ret.Length < s.Length)
                {
                    for (int i = 0; i < 26; i++)
                    {
                        if (num[i] > 0)
                        {
                            ret.Append((char)(i + 'a'));
                            num[i]--;
                        }
                    }
                    for (int i = 25; i >= 0; i--)
                    {
                        if (num[i] > 0)
                        {
                            ret.Append((char)(i + 'a'));
                            num[i]--;
                        }
                    }
                }
                return ret.ToString();
            }

            public string SortString(string s)
            {
                var chs = s.ToArray();
                chs = SortString(chs, 0, chs.Length - 1);
                var used = new bool[chs.Length];
                var buf = new StringBuilder();
                while (chs.Length > buf.Length)
                {
                    var set = new HashSet<char>();
                    for (var i = 0; i < chs.Length; i++)
                    {
                        if (used[i] == true || set.Contains(chs[i]))
                        {
                            continue;
                        }

                        buf.Append(chs[i]);
                        set.Add(chs[i]);
                        used[i] = true;
                    }

                    if (chs.Length > buf.Length)
                    {
                        set = new HashSet<char>();
                        for (var i = chs.Length - 1; i >= 0; i--)
                        {
                            if (used[i] == true || set.Contains(chs[i]))
                            {
                                continue;
                            }

                            buf.Append(chs[i]);
                            set.Add(chs[i]);
                            used[i] = true;
                        }
                    }
                }

                return buf.ToString();
            }

            public char[] SortString(char[] chs, int left, int right)
            {
                if (left >= right)
                {
                    return chs;
                }

                var pivot = left;
                var index = left + 1;
                for (var i = index; i <= right; i++)
                {
                    if (chs[i] < chs[pivot])
                    {
                        Swap(chs, i, index);
                        index++;
                    }
                }

                Swap(chs, index - 1, pivot);
                SortString(chs, left, index - 2);
                SortString(chs, index, right);

                return chs;
            }

            public void Swap(char[] chs, int pos1, int pos2)
            {
                var tmp = chs[pos1];
                chs[pos1] = chs[pos2];
                chs[pos2] = tmp;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace leetcode.dotnet
{
    public class _0028_Implement_strStr
    {
        public class Solution
        {
            public int StrStr(string haystack, string needle)
            {
                if (haystack == null || needle == null)
                {
                    return -1;
                }

                var pmt = BuildPartialMatchTable(needle);
                int i, j = 0;

                for (i = 0; i < haystack.Length && j < needle.Length; i++)
                {
                    while (j > 0 && haystack[i] != needle[j])
                    {
                        j = pmt[j];
                    }

                    if (haystack[i] == needle[j])
                    {
                        j++;
                    }
                    else
                    {
                        j = 0;
                    }
                }

                if (j == needle.Length)
                {
                    return i - needle.Length;
                }
                else
                {
                    return -1;
                }
            }

            /// <summary>
            /// In PMT, each i-th value is the length of the longest common prefix/suffix before i-th item.
            /// If i == 0, the prefix/suffix is 0
            /// If i == 1, the common prefix/suffix can't be itself, so it is 0
            /// If i >= 2, if p[i - 1] == p[j] then i-th value is pmt[j] + 1, i++ and j++
            /// If i >= 2, if p[i - 1] != p[j] then i-th value is pmt[j] (0), i++
            /// </summary>
            /// <param name="pattern"></param>
            /// <returns></returns>
            public int[] BuildPartialMatchTable(string pattern)
            {
                var pmt = new int[pattern.Length];
                int i, j = 0;
                for (i = 0; i < pattern.Length; i++)
                {
                    if (i < 2)
                    {
                        pmt[i] = 0;
                        continue;
                    }

                    while (j > 0 && pattern[i - 1] != pattern[j])
                    {
                        j = pmt[j];
                    }

                    if (pattern[i - 1] == pattern[j])
                    {
                        pmt[i] = j + 1; // the prefix length = index + 1
                        j++;
                    }
                    else
                    {
                        pmt[i] = 0;
                    }
                }

                return pmt;
            }
        }
    }
}

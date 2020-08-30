using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0214_Shortest_Palindrome
    {
        public class Solution
        {
            public string ShortestPalindrome(string s)
            {
                if (string.IsNullOrEmpty(s) || s.Length == 1)
                {
                    return s;
                }

                var pmt = BuildPMT(s);
                var chs = s.ToCharArray();
                Array.Reverse(chs);
                var rev = new string(chs);
                var j = 0;
                for (var i = 0; i < rev.Length; i++)
                {
                    while (j > 0 && s[j] != rev[i])
                    {
                        j = pmt[j];
                    }

                    if (s[j] == rev[i])
                    {
                        j++;
                    }
                }

                var substr = rev.Substring(0, rev.Length - j);
                return substr + s;
            }

            public int[] BuildPMT(string s)
            {
                var pmt = new int[s.Length];
                var i = 0;
                var j = 0;
                for (i = 0; i < s.Length; i++)
                {
                    if (i < 2)
                    {
                        pmt[i] = 0;
                        continue;
                    }

                    while (j > 0 && s[i - 1] != s[j])
                    {
                        j = pmt[j];
                    }

                    if (s[i - 1] == s[j])
                    {
                        pmt[i] = j + 1;
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

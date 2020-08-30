using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text;

namespace leetcode.dotnet
{
    public class _0557_Reverse_Words_in_a_String_III
    {
        public class Solution
        {
            public string ReverseWords(string s)
            {
                if (s == null || string.IsNullOrWhiteSpace(s))
                {
                    return s;
                }

                var chs = s.ToCharArray();
                int start = 0, cur = 0;
                while (cur < chs.Length)
                {
                    if (chs[cur] == ' ')
                    {
                        var end = cur - 1;
                        if (start < end && end < chs.Length)
                        {
                            while (start < end)
                            {
                                var tmp = chs[start];
                                chs[start] = chs[end];
                                chs[end] = tmp;
                                start++;
                                end--;
                            }
                        }

                        start = cur + 1;
                    }

                    cur++;
                }

                if (cur == chs.Length)
                {
                    var end = cur - 1;
                    if (start < end && end < chs.Length)
                    {
                        while (start < end)
                        {
                            var tmp = chs[start];
                            chs[start] = chs[end];
                            chs[end] = tmp;
                            start++;
                            end--;
                        }
                    }
                }

                return new string(chs);
            }
        }
    }
}

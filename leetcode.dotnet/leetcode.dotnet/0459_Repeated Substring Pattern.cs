using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    class _0459_Repeated_Substring_Pattern
    {
public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        for (var len = 1; len <= s.Length / 2; len++)
        {
            if (s.Length % len != 0)
            {
                continue;
            }

            var subS = s.Substring(0, len);
            var isRepeated = true;
            for (var start = len; start + len <= s.Length; start += len)
            {
                var tmpS = s.Substring(start, len);
                if (tmpS != subS)
                {
                    isRepeated = false;
                    break;
                }
            }

            if (isRepeated)
            {
                return true;
            }
        }

        return false;
    }
}
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    class _0242_Valid_Anagram
    {
        public class Solution
        {
            public bool IsAnagram(string s, string t)
            {
                if (s == null || t == null)
                {
                    return false;
                }

                var sa = s.ToCharArray();
                var ta = t.ToCharArray();
                Array.Sort(sa);
                Array.Sort(ta);

                return new string(sa) == new string(ta);
            }
        }
    }
}

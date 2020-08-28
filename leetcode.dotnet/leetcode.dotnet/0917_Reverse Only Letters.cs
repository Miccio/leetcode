using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    class _0917_Reverse_Only_Letters
    {
public class Solution
{
    public string ReverseOnlyLetters(string S)
    {
        if (string.IsNullOrEmpty(S))
        {
            return S;
        }

        var chs = S.ToCharArray();
        var i = 0;
        var j = chs.Length - 1;
        while (i < j)
        {
            while (i < j && !CheckCharacter(chs[i]))
            {
                i++;
            }

            while (i < j && !CheckCharacter(chs[j]))
            {
                j--;
            }

            if (i < j)
            {
                var tmp = chs[i];
                chs[i] = chs[j];
                chs[j] = tmp;
                i++;
                j--;
            }
        }

        return new string(chs);
    }

    public bool CheckCharacter(char ch)
    {
        return (ch <= 'z' && ch >= 'a') || (ch <= 'Z' && ch >= 'A');
    }
}
    }
}

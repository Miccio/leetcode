using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    class _0017_Letter_Combinations_of_a_Phone_Number
    {
public class Solution
{
    public static Dictionary<char, string> dict = new Dictionary<char, string>
    {
        { '2', "abc"},
        { '3', "def"},
        { '4', "ghi"},
        { '5', "jkl"},
        { '6', "mno"},
        { '7', "pqrs"},
        { '8', "tuv"},
        { '9', "wxyz"},
    };

    public IList<string> LetterCombinations(string digits)
    {
        var ret = new List<string>();
        if (string.IsNullOrEmpty(digits))
        {
            return ret;
        }

        LetterCombinations(digits, 0, new StringBuilder(), ret);

        return ret;
    }

    public void LetterCombinations(string digits, int start, StringBuilder strBuf, List<string> ret)
    {
        if (start >= digits.Length)
        {
            ret.Add(strBuf.ToString());
            return;
        }

        var curDigit = digits[start];
        var curStr = dict[curDigit];
        for (var i = 0; i < curStr.Length; i++)
        {
            strBuf.Append(curStr[i]);
            LetterCombinations(digits, start + 1, strBuf, ret);
            strBuf.Remove(start, 1);
        }
    }
}
    }
}

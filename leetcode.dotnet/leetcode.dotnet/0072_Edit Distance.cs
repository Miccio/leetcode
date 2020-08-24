using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0072_Edit_Distance
    {
public class Solution
{
    public int MinDistance(string word1, string word2)
    {
        if (string.IsNullOrEmpty(word1))
        {
            return word2?.Length ?? 0;
        }

        if (string.IsNullOrEmpty(word2))
        {
            return word1.Length;
        }

        var matrix = new int[word1.Length + 1][];
        for (var i = 0; i <= word1.Length; i++)
        {
            matrix[i] = new int[word2.Length + 1];
        }

        for (var i = 1; i <= word1.Length; i++)
        {
            matrix[i][0] = i;
        }

        for (var i = 1; i <= word2.Length; i++)
        {
            matrix[0][i] = i;
        }

        var chars1 = word1.ToCharArray();
        var chars2 = word2.ToCharArray();
        for (var i = 1; i <= word1.Length; i++)
        {
            for (var j = 1; j <= word2.Length; j++)
            {
                var tmp = chars1[i - 1] == chars2[j - 1] ? 0 : 1;
                matrix[i][j] = Math.Min(Math.Min(matrix[i - 1][j] + 1, matrix[i][j - 1] + 1), matrix[i - 1][j - 1] + tmp);
            }
        }

        return matrix[word1.Length][word2.Length];
    }
}
    }
}

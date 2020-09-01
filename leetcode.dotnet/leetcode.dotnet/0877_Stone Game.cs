using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    class _0877_Stone_Game
    {
public class Solution
{
    public bool StoneGame(int[] piles)
    {
        if (piles == null || piles.Length < 3)
        {
            return true;
        }

        var len = piles.Length;
        var dp = new int[len][];
        for (var i = 0; i < len; i++)
        {
            dp[i] = new int[len];
            dp[i][i] = piles[i];
        }

        for (var i = len - 1; i >= 0; i--)
        {
            for (var j = i + 1; j < len; j++)
            {
                dp[i][j] = Math.Max(piles[i] - dp[i + 1][j], piles[j] - dp[i][j - 1]);
            }
        }

        return dp[0][len - 1] >= 0;
    }
}
    }
}

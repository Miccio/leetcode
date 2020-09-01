using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.dotnet
{
    class _0486_Predict_the_Winner
    {
public class Solution
{
    /// <summary>
    /// If i == j, delta = nums[i], true
    /// If j - i == 1, delta = Math.Abs(nums[i] - nums[j])
    /// If j - i > 1, delta = Math.Max(nums[i] + matrix[i+1][j], nums[j] + matrix[i][j-1])
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public bool PredictTheWinner(int[] nums)
    {
        if (nums == null || nums.Length < 3)
        {
            return true;
        }

        var dp = new int[nums.Length][];
        for (var i = nums.Length - 1; i >= 0 ; i--)
        {
            dp[i] = new int[nums.Length];
            dp[i][i] = nums[i];

            for (var j = i + 1; j < nums.Length; j++)
            {
                dp[i][j] = Math.Max(nums[i] - dp[i + 1][j], nums[j] - dp[i][j - 1]);
            }
        }

        return dp[0][nums.Length - 1] >= 0;
    }
}
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0054_Spiral_Matrix
    {
public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        var nums = new List<int>();

        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
        {
            return nums;
        }

        int m = matrix.Length;
        int n = matrix[0].Length;

                int left = 0, right = n - 1, up = 0, down = m - 1;
        while (left <= right && up <= down)
        {
            if (left <= right && up <= down)
            {
                for (var i = left; i <= right; i++)
                {
                    nums.Add(matrix[up][i]);
                }

                up++;
            }

            if (left <= right && up <= down)
            {
                for (var i = up; i <= down; i++)
                {
                    nums.Add(matrix[i][right]);
                }

                right--;
            }

            if (left <= right && up <= down)
            {
                for (var i = right; i >= left; i--)
                {
                    nums.Add(matrix[down][i]);
                }

                down--;
            }

            if (left <= right && up <= down)
            {
                for (var i = down; i >= up; i--)
                {
                    nums.Add(matrix[i][left]);
                }

                left++;
            }
        }

        return nums;
    }
}
    }
}

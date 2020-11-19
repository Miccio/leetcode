using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode.dotnet
{
    public class _1030_Matrix_Cells_in_Distance_Order
    {
        public class Solution
        {
            public int[][] AllCellsDistOrder(int R, int C, int r0, int c0)
            {
                var cellWithDist = new List<Tuple<int[], int>>();

                for (var i = 0; i < R; i++)
                {
                    for (var j = 0; j < C; j++)
                    {
                        var cell = new int[2];
                        cell[0] = i;
                        cell[1] = j;

                        cellWithDist.Add(new Tuple<int[], int>(cell, GetDist(i, j, r0, c0)));
                    }
                }

                cellWithDist.Sort((c1, c2) => (c1.Item2.CompareTo(c2.Item2)));
                return cellWithDist.Select(c => c.Item1).ToArray();
            }

            public int GetDist(int m1, int n1, int m2, int n2)
            {
                return Math.Abs(m1 - m2) + Math.Abs(n1 - n2);
            }
        }
    }
}

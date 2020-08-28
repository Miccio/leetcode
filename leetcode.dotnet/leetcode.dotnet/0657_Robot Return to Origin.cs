using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    class _0657_Robot_Return_to_Origin
    {
        public class Solution
        {
            public bool JudgeCircle(string moves)
            {
                int x = 0, y = 0;
                foreach (var ch in moves)
                {
                    switch (ch)
                    {
                        case 'U':
                            y++;
                            break;
                        case 'D':
                            y--;
                            break;
                        case 'L':
                            x--;
                            break;
                        case 'R':
                            x++;
                            break;
                    }    
                }

                return x == 0 && y == 0;
            }
        }
    }
}

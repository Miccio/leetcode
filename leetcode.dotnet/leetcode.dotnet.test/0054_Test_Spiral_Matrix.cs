using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet.test
{
    [TestFixture]
    public class _0054_Test_Spiral_Matrix
    {
        [Test]
        public void TestSpiralOrder()
        {
            var matrix = new int[3][];

            var num = 1;
            for (var i = 0; i <= 2; i++)
            {
                matrix[i] = new int[3];
                for (var j = 0; j <= 2; j++)
                {
                    matrix[i][j] = num++;
                }
            }
            var sol = new _0054_Spiral_Matrix.Solution();
            var ret = sol.SpiralOrder(matrix);
            var retStr = string.Join(",", ret);
        }
    }
}

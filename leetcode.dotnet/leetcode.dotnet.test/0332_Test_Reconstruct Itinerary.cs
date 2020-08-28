namespace leetcode.dotnet.test
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using leetcode.dotnet;

    [TestFixture]
    public class _0332_Test_Reconstruct_Itinerary
    {
        [Test]
        public void Test()
        {
            var input = GetInput();
            var sol = new _0332_Reconstruct_Itinerary.Solution();
            var ret = sol.FindItinerary(input);
        }

        public IList<IList<string>> GetInput()
        {
            var ret = new List<IList<string>>
            {
                new List<string> { "MUC", "LHR" },
                new List<string> { "JFK", "MUC" },
                new List<string> { "SFO", "SJC" },
                new List<string> { "LHR", "SFO" },
            };

            return ret;
        }
    }
}

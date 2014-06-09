using System.Collections.Generic;
using System.Numerics;

namespace EulerProject.Problems
{
    class Problem53 : IProblem
    {
        /// <summary>
        /// http://projecteuler.net/problem=53
        /// </summary>
        public object Solve()
        {
            const int max = 100;
            const int target = 1000000;
            var results = new List<BigInteger>();

            for (int n = 1; n <= max; n++)
            {
                for (int r = 1; r <= max; r++)
                {
                    if (r > n) break;   // r can never be bigger than n; ie, you can't select 5 from 3.
                    var c = Common.CalculateRFromN(r, n);
                    if (c > target) results.Add(c);
                }
            }
            return results.Count; 
        }
    }
}

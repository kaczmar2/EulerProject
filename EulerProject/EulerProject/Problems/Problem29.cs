using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=29
    /// </summary>
    class Problem29 : IProblem
    {
        public object Solve()
        {
            BigInteger maxA = 100;
            const int maxB = 100;
            var termList = new List<BigInteger>();
            for (BigInteger a = 2; a <= maxA; a++)
            {
                for (int b = 2; b <= maxB; b++)
                {
                    var t = BigInteger.Pow(a, b);
                    termList.Add(t);
                }
            }
            var termCount = termList.Distinct().Count();
            return termCount;
        }
    }
}

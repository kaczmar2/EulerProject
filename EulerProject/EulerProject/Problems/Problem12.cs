using System.Collections.Generic;
using System.Diagnostics;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=12
    /// </summary>
    class Problem12 : IProblem
    {
        public object Solve()
        {
            const int target = 500;
            var num = 1;
            long tn;
            List<long> numDivisors;

            do
            {
                tn = Common.GetTriangularNumber(num);
                numDivisors = Common.GetDivisors(tn);
                num++;
            } while (numDivisors.Count <= target);

            Debug.WriteLine(" [num divisors: {0}]", numDivisors.Count);
            return tn;
        }
    }
}

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
            const int min = 23;
            const int max = 100;
            const int target = 1000000;
            int count = 0;
            var f = new BigInteger[max + 1];

            // Precalulate and store factorials
            for (int x = 0; x <= max; x++)
            {
                f[x] = Common.Factorial(x);
            }

            for (int n = min; n <= max; n++)
            {
                for (int r = 1; r <= n; r++)
                {
                    if (f[n] / (f[r] * f[n - r]) > target)
                    {
                        count++;
                    }
                }
            }
            return count; 
        }
    }
}

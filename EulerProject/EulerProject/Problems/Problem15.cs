using System.Numerics;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=15
    /// </summary>
    class Problem15 : IProblem
    {
        public object Solve()
        {
            // (2n)! / n!^2 : central binomial coefficients
            const int n = 20;
            BigInteger result = (Common.Factorial((2 * n))) / (Common.Factorial(n) * Common.Factorial(n));
            return result;
        }
    }
}

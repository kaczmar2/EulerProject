using System.Numerics;

namespace EulerProject.Problems
{
    class Problem56 : IProblem
    {
        /// <summary>
        /// http://projecteuler.net/problem=56
        /// </summary>
        public object Solve()
        {
            const int min = 0;
            const int max = 100;
            int maxSum = 0;

            for (BigInteger a = min; a <= max; a++)
            {
                for (int b = min; b <= max; b++)
                {
                    BigInteger n = BigInteger.Pow(a, b);
                    int sum = Common.DigitalSum(n);
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }
            return maxSum;
        }
    }
}

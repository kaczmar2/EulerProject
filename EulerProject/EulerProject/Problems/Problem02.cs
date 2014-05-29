using System.Numerics;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=2
    /// </summary>
    class Problem02 : IProblem
    {
        public object Solve()
        {
            const int max = 4000000;
            BigInteger sum = 0;
            BigInteger fibNumber;
            int i = 0;

            do
            {
                i++;
                fibNumber = Common.Fibonacci(i);

                // find the sum of only the even-valued terms
                if (fibNumber % 2 == 0)
                {
                    sum += fibNumber;
                }
            } while (fibNumber <= max);

            return sum;
        }
    }
}

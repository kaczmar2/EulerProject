using System.Diagnostics;
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
            const int numTerms = 32;    // the first 32 terms in the sequence do not exceed four million (this was found by running this program and observing output)
            BigInteger sum = 0;

            // print all even terms that don't exceed 4 million
            for (int i = 0; i <= numTerms; i++)
            {
                BigInteger fibNumber = Common.Fibonacci(i);

                // find the sum of only the even-valued terms
                if (fibNumber % 2 == 0)
                {
                    sum += fibNumber;
                    Debug.WriteLine(fibNumber);
                }
            }
            Debug.WriteLine("Total: {0}", sum);

            return sum;
        }
    }
}

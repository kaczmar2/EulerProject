using System;
using System.Diagnostics;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=27
    /// </summary>
    class Problem27 : IProblem
    {
        public object Solve()
        {
            const int min = -1000;
            const int max = 1000;
            int largestCount = 0;
            int a1 = min; 
            int a2 = min;
            for (int a = min; a <= max; a++)
            {
                for (int b = min; b <= max; b++)
                {
                    double n = 0;
                    var count = 0;
                    bool prime;
                    do
                    {
                        // test for primes using the formula n² + an + b, where |a| < 1000 and |b| < 1000
                        var p = Math.Abs(Math.Pow(n, 2) + a * n + b);
                        prime = Common.IsPrime((int)p);
                        if (prime)
                        {
                            count++;
                        }
                        n++;
                    } while (prime);

                    if (count > largestCount)
                    {
                        largestCount = count;
                        a1 = a;
                        a2 = b;
                        //Debug.WriteLine("a={0} b={1}: {2}", a1, a2, count);
                    }
                }
            }
            //Debug.WriteLine("a={0} b={1}: {2}", a1, a2, largestCount);
            return a1 * a2;
        }
    }
}

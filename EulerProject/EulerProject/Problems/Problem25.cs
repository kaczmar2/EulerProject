using System.Numerics;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=25
    /// </summary>
    class Problem25 : IProblem
    {
        public object Solve()
        {
            const int target = 1000;
            BigInteger n = 0;
            int len;
            
            do
            {
                n++;
                var result = Common.Fibonacci(n);
                len = result.ToString().Length;
            } while (len < target);
            
            return n;
        }
    }
}

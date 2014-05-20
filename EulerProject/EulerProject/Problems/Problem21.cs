using System.Diagnostics;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=21
    /// </summary>
    class Problem21 : IProblem
    {
        public object Solve()
        {
            long sum = 0;
            for (long a = 1; a < 10000; a++)
            {
                var b = d(a);
                var t = d(b);

                if (t == a && a != b)
                {
                    //Debug.WriteLine("{0} {1}", a, b);
                    sum += (a + b);
                }
            }
            sum = sum/2;    // remove duplicate pairs
            return sum;
        }

        private static long d(long num)
        {
            long sum = 0;
            for (long i = 1; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}

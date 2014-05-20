using System;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=36
    /// </summary>
    class Problem36 : IProblem
    {
        public object Solve()
        {
            int max = 1000000;
            int sum = 0;

            for (int n = 1; n < max; n++)
            {
                string base2 = Convert.ToString(n, 2);
                if (Common.IsPalindrome(n) && Common.IsPalindrome(base2))
                {
                    sum += n;
                }
            }
            return sum;
        }
    }
}

using System.Diagnostics;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=1
    /// </summary>
    class Problem01 : IProblem
    {
        public object Solve()
        {
            const int i = 1000;
            int total = 0;

            for (int n = 1; n < i; n++)
            {
                if (n % 3 == 0 || n % 5 == 0)
                {
                    total += n;
                }
            }

            Debug.WriteLine("Total: {0}", total);
            return total;
        }
    }
}

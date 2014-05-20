using System.Collections.Generic;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=23
    /// </summary>
    class Problem23 : IProblem
    {
        public object Solve()
        {
            const int max = 28123;
            var totalSum = 0;
            var abundantNums = new List<int>();
            var abundantSums = new List<int>();

            for (int x = 1; x < max; x++)
            {
                if (Common.GetNumberType(x) == NumberType.Abundant)
                {
                    abundantNums.Add(x);
                }
            }

            int end = abundantNums.Count - 1;

            for (int a = 0; a <= end; a++)
            {
                for (int b = 0; b <= end; b++)
                {
                    int aSum = (abundantNums[a] + abundantNums[b]);
                    if (aSum <= max)
                    {
                        // We already know all numbers > 28123 can be written as the sums of 2 abundant numbers.
                        // Find the ones less than that.
                        abundantSums.Add(aSum);
                    }
                }
            }

            // find non-abundant numbers < 28123 and sum them (slooooowwww....)
            for (int n = 1; n <= max; n++)
            {
                if (!abundantSums.Contains(n))
                {
                    totalSum += n;
                }
            }
            return totalSum;
        }
    }
}

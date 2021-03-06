﻿
namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=12
    /// </summary>
    class Problem12 : IProblem
    {
        public object Solve()
        {
            const int target = 500;
            var num = 1;
            long tn;
            long numDivisors;

            do
            {
                tn = (long) Common.GetTriangularNumber(num);
                numDivisors = Common.GetDivisorsCount(tn);
                num++;
            } while (numDivisors <= target);

            return tn;
        }
    }
}

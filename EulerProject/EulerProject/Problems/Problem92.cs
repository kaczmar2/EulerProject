using System;
using System.Globalization;

namespace EulerProject.Problems
{
    class Problem92 : IProblem
    {
        /// <summary>
        /// http://projecteuler.net/problem=92
        /// </summary>
        public object Solve()
        {
            const double max = 10000000;
            var count = 0;

            for (double n = 1; n < max; n++)
            {
                var sqr = Common.GetSquareOfDigits(n);
                do
                {
                    sqr = Common.GetSquareOfDigits(sqr);
                } while (!(sqr.Equals(1) || sqr.Equals(89)));

                if (sqr.Equals(89))
                {
                    count++;
                }
            }
            return count;
        }
    }
}

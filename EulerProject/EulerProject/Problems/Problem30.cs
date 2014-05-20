using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=30
    /// </summary>
    class Problem30 : IProblem
    {
        public object Solve()
        {
            const int exp = 5;
            double upperBound = 0;
            double lowerBound = Math.Pow(2, exp);
            var digitPowers = new List<double>();

            // establish upper bound of loop
            //for (int x = 0; x < 10; x++)
            //{
            //    var res = Math.Pow(x, exp);
            //    upperBound += res;
            //}

            // upper bound is miscalculated by above logic.  See discussion threads for this.
            // I set upper bound to an arbitrarily large number (1000000) and it worked, but it could be:
            upperBound = 6 * Math.Pow(9, 5); // limit for 6 digit numbers, 9 being the max digit value.

            for (double x = lowerBound; x <= upperBound; x++)
            {
                double sum = 0;
                char[] chars = x.ToString(CultureInfo.InvariantCulture).ToCharArray();
                foreach (var c in chars)
                {
                    sum += Math.Pow(double.Parse(c.ToString(CultureInfo.InvariantCulture)), exp);
                }
                if (sum.Equals(x))
                {
                    digitPowers.Add(x);
                }
            }

            double powerDigitSum = digitPowers.Sum();
            return powerDigitSum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=34
    /// </summary>
    class Problem34 : IProblem
    {
        public object Solve()
        {
            BigInteger total = 0;
            const int multiplier = 3;    // arbitrary, but it worked.  I looked at a factorial table and guessed
            const int lowerBound = 3;
            var upperBound = multiplier * Common.Factorial(9);
            var digitFactorials = new List<BigInteger>();

            for (BigInteger x = lowerBound; x <= upperBound; x++)
            {
                BigInteger sum = 0;
                char[] chars = x.ToString(CultureInfo.InvariantCulture).ToCharArray();
                foreach (var c in chars)
                {
                    var d = new BigInteger(int.Parse(c.ToString(CultureInfo.InvariantCulture)));
                    sum += Common.Factorial(d);
                }
                if (sum.Equals(x))
                {
                    digitFactorials.Add(x);
                }
            }

            // sum
            foreach (var digitFactorial in digitFactorials)
            {
                total += digitFactorial;
            }

            return total;
        }
    }
}

using System;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=16
    /// </summary>
    class Problem16 : IProblem
    {
        public object Solve()
        {
            const int power = 1000;
            var sum = 0;
            double digits = Math.Pow(2, power);
            var bi = new BigInteger(digits);
            var arr = bi.ToString().ToArray();

            foreach (var digit in arr)
            {
                sum += int.Parse(digit.ToString(CultureInfo.InvariantCulture));
            }
            return sum;
        }
    }
}

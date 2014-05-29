using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=33
    /// </summary>
    class Problem33 : IProblem
    {
        public object Solve()
        {
            const int min = 10;
            const int max = 99;
            var solutions = new List<Tuple<double, double>>();

            for (double n = min; n <= max; n++)
            {
                for (double d = min; d <= max; d++)
                {
                    // less than 1
                    if (n < d)
                    {
                        string cd;
                        if (HasCancelingDigits(n, d, out cd) && TestFraction(n, d, cd))
                        {
                            solutions.Add(new Tuple<double, double>(n, d));
                        }
                    }
                }
            }

            // get gcd of denominator for product of the fractions for answer
            double prodN = 1;
            double prodD = 1;
            foreach (var solution in solutions)
            {
                prodN *= solution.Item1;
                prodD *= solution.Item2;
            }
            int gcd = Common.Gcd((int)prodN, (int)prodD);
            return prodD / gcd;
        }

        /// <summary>
        /// Test canceling digit fractions
        /// </summary>
        /// <param name="n">Numerator</param>
        /// <param name="d">Denominator</param>
        /// <param name="cd">Common digit that can be canceled</param>
        /// <returns></returns>
        private static bool TestFraction(double n, double d, string cd)
        {
            string ns = n.ToString(CultureInfo.InvariantCulture);
            string ds = d.ToString(CultureInfo.InvariantCulture);
            var re = new Regex(cd);
            ns = re.Replace(ns, "", 1);
            ds = re.Replace(ds, "", 1);

            var res1 = n / d;
            var res2 = double.Parse(ns) / double.Parse(ds);
            
            return res1.Equals(res2);
        }

        /// <summary>
        /// Finds if 2 2-digit numbers (a numerator and a denominator) have a common digit
        /// </summary>
        /// <param name="n">Numerator</param>
        /// <param name="d">Denominator</param>
        /// <param name="cd">The common digit, exclusive of zero</param>
        /// <returns>True if the numerator and denominator have a common digit</returns>
        private static bool HasCancelingDigits(double n, double d, out string cd)
        {
            string ns = n.ToString(CultureInfo.InvariantCulture);
            string ds = d.ToString(CultureInfo.InvariantCulture);
            cd = "";

            foreach (var nc in ns.Where(nc => ds.Any(dc => nc.Equals(dc) && dc != 0)))
            {
                cd = nc.ToString(CultureInfo.InvariantCulture);
                return true && !cd.Equals("0"); // canceling zeros is trival; don't include it
            }
            return false;
        }
    }
}
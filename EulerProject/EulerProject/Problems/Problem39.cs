using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=39
    /// Inner loops code re-used from Problem 9
    /// </summary>
    class Problem39 : IProblem
    {
        public object Solve()
        {
            const double pMax = 1000;
            var solutions = new Dictionary<double, int>();

            for (double p = 1; p <= pMax; p++)
            {
                var sides = new List<Tuple<double, double, double>>();
                for (double a = 1; a < p; a++)
                {
                    for (double b = a + 1; b < p; b++)
                    {
                        double c = p - a - b;
                        if ((a < b && b < c) && (Math.Pow(a, 2) + Math.Pow(b, 2)).Equals(Math.Pow(c, 2)))
                        {
                            sides.Add(new Tuple<double, double, double>(a, b, c));
                        }
                    }
                }
                solutions.Add(p, sides.Count);
            }
            var maxP = (int) solutions.FirstOrDefault(m => m.Value == solutions.Values.Max()).Key;
            return maxP;
        }
    }
}

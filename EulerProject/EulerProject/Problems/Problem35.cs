using System.Collections.Generic;
using System.Globalization;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=35
    /// </summary>
    class Problem35 : IProblem
    {
        public object Solve()
        {
            const int max = 1000000;
            var primes = new List<int>();

            for (int n = 2; n < max; n++)
            {
                if (Common.IsPrime(n))
                {
                    // test this number's rotations
                    var prime = true;
                    var len = n.ToString(CultureInfo.InvariantCulture).Length - 1;
                    var rot = n;
                    for (int r = 0; r < len; r++)
                    {
                        rot = Common.RotateDigits(rot);
                        prime = Common.IsPrime(rot);
                        if (!prime)
                        {
                            break;
                        }
                    }
                    if (prime)
                    {
                        primes.Add(n);
                    }
                }
            }
            int count = primes.Count;
            return count;
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=50
    /// Brute force solution. Takes 5-6 minutes to solve.
    /// </summary>
    class Problem50 : IProblem
    {
        public object Solve()
        {
            const int target = 1000000;
            var primes = new List<int>();
            var counts = new Dictionary<int, int>();

            // collect primes
            for (int p = 0; p < target; p++)
            {
                if (Common.IsPrime(p))
                {
                    primes.Add(p);
                }
            }

            // calculate consective sum counts
            int end = primes.Count - 1;
            foreach (var prime in primes)
            {
                int start = 0;
                int idx = start;
                int sum = 0;
                int c = 0;
                
                do
                {
                    sum += primes[idx];
                    c++;
                    if (sum == prime && c > 1)
                    {
                        // found consecutive sum
                        counts.Add(prime, c);
                        break;
                    }
                    if (sum > prime)
                    {
                        // consecutive sum doesn't equal the target prime
                        // shift the start position of the summation and reset
                        idx = start++;
                        sum = 0;
                        c = 0;
                    }
                    else
                    {
                        idx++;
                    }
                } while (idx <= end);
            }
            var res = counts.Aggregate((p, c) => p.Value > c.Value ? p : c).Key;
            return res;
        }
    }
}

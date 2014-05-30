using System;
using System.Collections.Generic;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=26
    /// http://en.wikipedia.org/wiki/Cyclic_number
    /// Originally this was solved in 3 guesses: from above article, knowing that the digital period of 1/p (where p is prime) is p − 1,
    /// We know repeat cycles are longer the closer d is to 999.  So I tried the three largest primes less than 1000: 997, 991, 983.  983 is correct.
    /// This simple formula yields failed cases (997, 991).  Implementation of correct way (long divsion test) is below.
    /// </summary>
    class Problem26 : IProblem
    {
        public object Solve()
        {
            const int max = 1000;
            const int b = 10;   // Base 10
            var primes = new List<int>();
            int result = 0;
            
            // collect all primes < 1000
            for (int p = max; p > 0; p--)
            {
                if (Common.IsPrime(p) && b % p != 0)
                {
                    // prime that does not divide b
                    primes.Add(p);
                }
            }

            foreach (var prime in primes)
            {
                int t = 0;
                double r = 1;
                double n = 0;
                do
                {
                    double x = r * b;
                    double d = Math.Floor(x / prime);
                    t++;
                    r = x % prime;
                    n = n * b + d;
                } while (!r.Equals(1));

                if (t == prime - 1)
                {
                    result = prime;
                    break;
                }
            }
            return result;
        }
    }
}

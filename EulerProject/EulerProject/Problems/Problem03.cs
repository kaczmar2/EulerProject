using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=3
    /// </summary>
    class Problem03 : IProblem
    {
        public object Solve()
        {
            // brute force solution - see problem thread for more elegant/faster solution
            const long num = 600851475143;
            var primes = new List<long>();
            for (long i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    // it's a factor - check for primeness
                    bool prime = true;
                    for (long j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            // not prime
                            prime = false;
                            break;
                        }
                        
                    }
                    
                    Debug.WriteLine("{0} {1}", i, prime ? "(prime)" : "");
                    if (prime)
                    {
                        primes.Add(i);
                    }
                }
            }
            return primes.Max();
        }
    }
}

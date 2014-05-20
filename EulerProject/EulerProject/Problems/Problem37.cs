using System.Globalization;

namespace EulerProject.Problems
{
    class Problem37 : IProblem
    {
        /// <summary>
        /// http://projecteuler.net/problem=37
        /// </summary>
        public object Solve()
        {
            const int start = 11;   // 2, 3, 5, and 7 are not considered to be truncatable primes.
            var count = 0;
            var n = start;
            var sum = 0;
            do
            {
                bool prime = true;
                if (Common.IsPrime(n))
                {
                    var ns = n.ToString(CultureInfo.InvariantCulture);
                    var len = ns.Length;
                    // check truncations
                    // L-R
                    for (int i = 1; i < len; i++)
                    {
                        string part = ns.Substring(i, ns.Length - i);
                        if (!Common.IsPrime(int.Parse(part)))
                        {
                            prime = false;
                            break;
                        }
                    }

                    // R-L
                    for (int i = len - 1; i > 0; i--)
                    {
                        string part = ns.Substring(0, i);
                        if (!Common.IsPrime(int.Parse(part)))
                        {
                            prime = false;
                            break;
                        }
                    }

                    if (prime)
                    {
                        count++;
                        sum += n;
                    }
                }
                n++;
            } while (count < 11);

            return sum;
        }
    }
}

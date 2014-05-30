using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=32
    /// If multiplier (b) has 4 digits, product has to have at least 4 digits, so just do some very rough loop limiting
    /// Still brute froce and slow (50 secs).
    /// </summary>
    class Problem32 : IProblem
    {
        public object Solve()
        {
            var products = new List<int>();
            const int min = 1;
            const int max = 9876;

            for (int a = min; a <= max; a++)
            {
                for (int b = min; b <= max; b++)
                {
                    var c = a*b;
                    string m = a.ToString(CultureInfo.InvariantCulture);
                    string n = b.ToString(CultureInfo.InvariantCulture);
                    string p = c.ToString(CultureInfo.InvariantCulture);
                    string pd = string.Concat(m, n, p);
                    if (pd.Length == 9 && Common.IsPandigital(int.Parse(pd)))
                    {
                        products.Add(c);
                    }
                }
            }
            return products.Distinct().ToList().Sum();
        }
    }
}

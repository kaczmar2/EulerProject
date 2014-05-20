using System.Globalization;
using System.Numerics;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=20
    /// </summary>
    class Problem20 : IProblem
    {
        public object Solve()
        {
            const int num = 100;
            var f = new BigInteger();
            uint sum = 0;

            f = Common.Factorial(num);
            var arr = f.ToString().ToCharArray();

            foreach (var c in arr)
            {
                var i = uint.Parse(c.ToString(CultureInfo.InvariantCulture));
                sum += i;
            }

            return sum;
        }
    }
}

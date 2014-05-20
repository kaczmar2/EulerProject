using System.Numerics;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=48
    /// </summary>
    class Problem48 : IProblem
    {
        public object Solve()
        {
            BigInteger max = 1000;
            BigInteger result = 0;
            for (BigInteger x = 1; x <= max; x++)
            {
                result += BigInteger.Pow(x, (int)x);
            }
            var disp = result.ToString();
            disp = disp.Substring(disp.Length - 10);
            return disp;
        }
    }
}

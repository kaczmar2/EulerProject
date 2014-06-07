
namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=7
    /// </summary>
    class Problem07 : IProblem
    {
        public object Solve()
        {
            const int max = 10001;
            int terms = 0;
            int n = 2;

            do
            {
                if (!Common.IsPrime(n)) continue;
                terms++;
                n = Common.GetNextPrime(n);
            } while (terms < max);

            return n;
        }
    }
}

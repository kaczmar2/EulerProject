
namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=10
    /// </summary>
    class Problem10 : IProblem
    {
        public object Solve()
        {
            const int num = 2000000;
            long sum = 0;

            for (int i = 2; i < num; i++)
            {
                if (Common.IsPrime(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}

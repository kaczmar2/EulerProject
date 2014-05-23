
namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=31
    /// http://www.geeksforgeeks.org/dynamic-programming-set-7-coin-change/
    /// </summary>
    class Problem31 : IProblem
    {
        public object Solve()
        {
            const int n = 200;
            var s = new int[] {1, 2, 5, 10, 20, 50, 100, 200};
            var m = s.Length;

            var count = Common.CountCoinSums(s, m, n);
            return count;
        }
    }
}

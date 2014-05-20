
namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=6
    /// </summary>
    class Problem06 : IProblem
    {
        public object Solve()
        {
            const int num = 100;
            var result = Common.SquareOfSum(num) - Common.SumOfSquares(num);
            return result;
        }
    }
}


namespace EulerProject.Problems
{
    class Problem45 : IProblem
    {
        /// <summary>
        /// http://projecteuler.net/problem=45
        /// http://en.wikipedia.org/wiki/Hexagonal_number
        /// http://mathworld.wolfram.com/HexagonalNumber.html
        /// </summary>
        public object Solve()
        {
            bool found;
            ulong x;
            var h = 143;
            do
            {
                h++;
                x = Common.GetHexagonalNumber(h);   // Every hexagonal number is a triangular number
                found = Common.IsPentagonalNumber(x);
            } while (!found);
            return x;
        }
    }
}

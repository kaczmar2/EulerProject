using System.Linq;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=14
    /// </summary>
    class Problem14 : IProblem
    {
        public object Solve()
        {
            const int end = 1000000;
            var seq = new uint[end];

            for (uint x = 0; x < end; x++)
            {
                seq[x] = (uint)Common.CollatzSequence(x).Count;
            }
            uint maxValue = seq.Max();
            int maxIndex = seq.ToList().IndexOf(maxValue);
            return maxIndex;
        }
    }
}

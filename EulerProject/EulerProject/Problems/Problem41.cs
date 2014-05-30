
using System.CodeDom;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=41
    /// Brute force - guessed at an arbitrary max of the minimum 9-digit pandigital number and the guess was correct.
    /// </summary>
    class Problem41 : IProblem
    {
        public object Solve()
        {
            const int max = 123456789; // 987654321;
            const int min = 12;
            bool found = false;
            int n = max+1;

            do
            {
                n--;
                if (Common.IsPandigital(n) && Common.IsPrime(n))
                {
                    found = true;
                    break;
                }
            } while (n >= min);

            return found ? n : 0;
        }
    }
}

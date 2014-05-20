
namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=7
    /// </summary>
    class Problem07 : IProblem
    {
        public object Solve()
        {
            int termsFound = 0;
            const int numTerms = 10001;
            int testNumber = 1;

            do
            {
                testNumber++;
                if (Common.IsPrime(testNumber))
                {
                    termsFound++;
                }
            } while (termsFound < numTerms);

            return testNumber;
        }
    }
}

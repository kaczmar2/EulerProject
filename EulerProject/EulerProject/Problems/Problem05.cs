
namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=5
    /// </summary>
    class Problem05 : IProblem
    {
        const int LowMultiple = 1;
        const int HighMultiple = 20;

        public object Solve()
        {
            int num = HighMultiple - 1;
            bool found;

            do
            {
                num++;
                found = TestMultiples(num);
            } while (!found);

            return num;
        }

        private static bool TestMultiples(int num)
        {
            bool found = true;
            for (int i = HighMultiple; i >= LowMultiple; i--)
            {
                if (num % i != 0)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

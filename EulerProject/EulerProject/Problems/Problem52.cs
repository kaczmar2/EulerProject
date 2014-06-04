
namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=52
    /// </summary>
    class Problem52 : IProblem
    {
        public object Solve()
        {
            int a = 0;
            bool found = false;
            do
            {
                a++;
                int b = a*2;
                int c = a*3;
                int d = a*4;
                int e = a*5;
                int f = a*6;
                int[] nums = {a, b, c, d, e, f};
                found = Common.ContainsSameDigits(nums);
            } while (!found);

            return a;
        }
    }
}

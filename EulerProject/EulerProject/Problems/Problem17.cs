using System.Diagnostics;
using System.Text;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=17
    /// </summary>
    class Problem17 : IProblem
    {
        public object Solve()
        {
            const int start = 1;
            const int stop = 1000;
            var sb = new StringBuilder();
            for (int n = start; n <= stop; n++)
            {
                string word = Common.NumberToWords(n);
                sb.Append(word);
            }
            sb.Replace("-", "").Replace(" ", "");   // strip spaces and dashes for this problem's answer to be correct
            //Debug.WriteLine(sb.ToString());
            int result = sb.ToString().Length;
            return result;
        }
    }
}

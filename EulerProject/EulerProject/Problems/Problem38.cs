using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=38
    /// Another brute force by trying varying values of min, max and n, where n=>{2...9} and max are m-digit pandigitals
    /// 918273645
    /// </summary>
    class Problem38 : IProblem
    {
        public object Solve()
        {
            int num = 0;
            const int start = 9321;
            const int end = 9876;
            const int n = 2;
            var pd = new List<int>();
            int p = start - 1;
            
            do
            {
                p++;
                var sb = new StringBuilder();
                for (int i = 1; i <= n; i++)
                {
                    var r = p*i;
                    sb.Append(r);
                }
                if (sb.Length <= 9)
                {
                    num = int.Parse(sb.ToString());
                }
                bool found = Common.IsPandigital(num);
                if (found)
                {
                    pd.Add(num);
                }
            } while (p <= end);
            
            pd.Sort();
            num = pd.Max();
            return num;
        }
    }
}

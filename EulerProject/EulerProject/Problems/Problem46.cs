using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=46
    /// </summary>
    class Problem46 : IProblem
    {
        public object Solve()
        {
            const int max = 10000;

            for (int n = 1; n <= max; n += 2)
            {
                if (Common.IsComposite(n))
                {
                    Debug.WriteLine(n);
                }
            }
            return null;
        }
    }
}

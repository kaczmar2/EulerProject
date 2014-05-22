using System.Globalization;
using System.Text;

namespace EulerProject.Problems
{
    class Problem40 : IProblem
    {
        /// <summary>
        /// http://projecteuler.net/problem=40
        /// </summary>
        public object Solve()
        {
            const int max = 1000000;
            var d = new StringBuilder("."); // shift the index over one for readability
            for (int i = 1; i < max; i++)
            {
                d.Append(i);
            }

            var res = 
                int.Parse(d[1].ToString(CultureInfo.InvariantCulture)) * 
                int.Parse(d[10].ToString(CultureInfo.InvariantCulture)) * 
                int.Parse(d[100].ToString(CultureInfo.InvariantCulture)) * 
                int.Parse(d[1000].ToString(CultureInfo.InvariantCulture)) *
                int.Parse(d[10000].ToString(CultureInfo.InvariantCulture)) * 
                int.Parse(d[100000].ToString(CultureInfo.InvariantCulture)) * 
                int.Parse(d[1000000].ToString(CultureInfo.InvariantCulture));
            return res;
        }
    }
}

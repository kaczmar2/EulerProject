using System.Collections.Generic;
using System.Linq;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=22
    /// </summary>
    class Problem22 : IProblem
    {
        public object Solve()
        {
            const string filePath = @"input\names.txt";
            long total = 0;
            int idx = 0;
            
            var input = Common.GetFileInput(filePath);
            input = input.Replace("\"", "");    // remove quotes
            var arrNames = input.Split(',');    // get into array
            var names = new List<string>(arrNames);

            names.Sort();

            foreach (var name in names)
            {
                idx++;
                int letterSum = Common.GetWordValue(name);
                int nameScore = idx * letterSum;
                total += nameScore;
            }
            return total;
        }
    }
}

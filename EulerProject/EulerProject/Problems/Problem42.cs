using System.Collections.Generic;
using System.Linq;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=42
    /// </summary>
    class Problem42 : IProblem
    {
        public object Solve()
        {
            const string file = @"input\words.txt";
            ulong tn;
            int n = 1;
            var triNumbers = new List<ulong>();

            string input = Common.GetFileInput(file);
            input = input.Replace("\"", "");    // remove quotes
            string[] words = input.Split(',');

            // get all word scores and get largest word score
            var wordScores = words.Select(Common.GetWordValue).ToList();
            int largestWordScore = wordScores.Max();

            // generate triangle numbers only up to max word score
            do
            {
                tn = Common.GetTriangularNumber(n);
                triNumbers.Add(tn);
                n++;
            } while (tn < (decimal) largestWordScore);

            // find any word that matches one of the triangular numbers
            int count = wordScores.Count(i => triNumbers.Contains((ulong) i));
            return count;
        }
    }
}

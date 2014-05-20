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
            var alphabet = new Dictionary<char, int>
            {
                {'A', 1},{'B', 2},{'C', 3},{'D', 4},{'E', 5},{'F', 6},
                {'G', 7},{'H', 8},{'I', 9},{'J', 10},{'K', 11},{'L', 12},
                {'M', 13},{'N', 14},{'O', 15},{'P', 16},{'Q', 17},{'R', 18},
                {'S', 19},{'T', 20},{'U', 21},{'V', 22},{'W', 23},{'X', 24},
                {'Y', 25},{'Z', 26}
            };

            var input = Common.GetFileInput(filePath);
            input = input.Replace("\"", "");    // remove quotes
            var arrNames = input.Split(',');    // get into array
            var names = new List<string>(arrNames);

            names.Sort();

            foreach (var name in names)
            {
                idx++;
                int letterSum = name.Sum(letter => alphabet[letter]);
                int nameScore = idx * letterSum;
                total += nameScore;
            }
            return total;
        }
    }
}

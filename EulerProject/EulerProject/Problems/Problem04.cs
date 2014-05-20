using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=4
    /// </summary>
    class Problem04 : IProblem
    {
        public object Solve()
        {
            var palindromeList = new List<int>();

            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j <= 999; j++)
                {
                    var result = i * j;
                    if (Common.IsPalindrome(result))
                    {
                        palindromeList.Add(result);
                        //Debug.WriteLine("{0} * {1} = {2}", i, j, result);
                    }
                }
            }

            int largest = palindromeList.Max();
            Debug.WriteLine("Largest palindrome of two three-digit numbers: {0}", largest);
            return largest;
        }
    }
}

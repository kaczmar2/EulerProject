using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=9
    /// </summary>
    class Problem09 : IProblem
    {
        public object Solve()
        {
            int product = 0;
            int num = 1000;
            var triplets = new List<Tuple<int, int, int>>();

            int c = 0;
            for (int a = 1; a < num; a++)
            {
                for (int b = a + 1; b < num; b++)
                {
                    c = num - a - b;
                    if (a < b && b < c)
                    {
                        triplets.Add(new Tuple<int, int, int>(a, b, c));
                        //Debug.WriteLine("{0} {1} {2}", a, b, c);
                    }
                }
            }

            foreach (var triplet in triplets)
            {
                bool check = Math.Pow(triplet.Item1, 2) + Math.Pow(triplet.Item2, 2) == Math.Pow(triplet.Item3, 2);
                if (check)
                {
                    
                    product = triplet.Item1 * triplet.Item2 * triplet.Item3;
                    Debug.WriteLine("{0} {1} {2}", triplet.Item1, triplet.Item2, triplet.Item3);
                    break;  // there is only one
                }
            }
            return product;
        }
    }
}
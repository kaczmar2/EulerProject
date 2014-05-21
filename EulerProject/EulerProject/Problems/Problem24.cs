using System.Collections.Generic;
using System.Linq;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=24
    /// </summary>
    class Problem24 : IProblem
    {
        public object Solve()
        {
            // Alternate solution found on forums - much faster by orders of magnitude.  Mine ran for hours, as I recall
            // return Alt();

            var pList = new List<string>(3628800);
            const int bound = 9;
            for (int a = 0; a <= bound; a++)
            {
                for (int b = 0; b <= bound; b++)
                {
                    for (int c = 0; c <= bound; c++)
                    {
                        for (int d = 0; d <= bound; d++)
                        {
                            for (int e = 0; e <= bound; e++)
                            {
                                for (int f = 0; f <= bound; f++)
                                {
                                    for (int g = 0; g <= bound; g++)
                                    {
                                        for (int h = 0; h <= bound; h++)
                                        {
                                            for (int i = 0; i <= bound; i++)
                                            {
                                                for (int j = 0; j <= bound; j++)
                                                {
                                                    var seq = string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", a, b, c, d, e, f, g, h, i, j);
                                                    var test = new List<int>(10) { a, b, c, d, e, f, g, h, i, j };
                                                    if (test.Distinct().Count() == test.Count)
                                                    {
                                                        pList.Add(seq);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            pList.Sort();
           return pList[999999];
        }

        public string Alt()
        {
            string temp = "0123456789";
            int counter = 1;
            const int tail = 9;

            while (counter < 1000000)
            {
                var cArr = temp.ToCharArray();
                var i = tail;

                while (cArr[i - 1] >= cArr[i])
                    i--;

                if (i == 0)
                    break; //all permutations done
                int pivot = cArr[i - 1];

                for (int n = tail; n >= i; n--)
                    if (cArr[n] > pivot) //if greater swap with pivot
                    {
                        char c = cArr[n];
                        cArr[n] = cArr[i - 1];
                        cArr[i - 1] = c;
                        break;
                    }

                temp = null;

                for (int k = 0; k <= i - 1; k++)
                    temp += cArr[k];

                for (int j = tail; j >= i; j--)
                    temp += cArr[j];

                counter++;
            }
            return temp;
        }
    }
}

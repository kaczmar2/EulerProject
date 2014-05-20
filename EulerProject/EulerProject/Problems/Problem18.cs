﻿using System;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=18
    /// </summary>
    class Problem18 : IProblem
    {
        public object Solve()
        {
            int[,] inputTriangle =
            {
                {75, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00},
                {95, 64, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00},
                {17, 47, 82, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00},
                {18, 35, 87, 10, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00},
                {20, 04, 82, 47, 65, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00},
                {19, 01, 23, 75, 03, 34, 00, 00, 00, 00, 00, 00, 00, 00, 00},
                {88, 02, 77, 73, 07, 63, 67, 00, 00, 00, 00, 00, 00, 00, 00},
                {99, 65, 04, 28, 06, 16, 70, 92, 00, 00, 00, 00, 00, 00, 00},
                {41, 41, 26, 56, 83, 40, 80, 70, 33, 00, 00, 00, 00, 00, 00},
                {41, 48, 72, 33, 47, 32, 37, 16, 94, 29, 00, 00, 00, 00, 00},
                {53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14, 00, 00, 00, 00},
                {70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57, 00, 00, 00},
                {91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48, 00, 00},
                {63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31, 00},
                {04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23}
            };

            var posSolutions = (int)Math.Pow(2, inputTriangle.GetLength(0) - 1);
            int largestSum = 0;

            for (int i = 0; i <= posSolutions; i++)
            {
                int tempSum = inputTriangle[0, 0];
                int index = 0;
                for (int j = 0; j < inputTriangle.GetLength(0) - 1; j++)
                {
                    index = index + (i >> j & 1);
                    tempSum += inputTriangle[j + 1, index];
                }
                if (tempSum > largestSum)
                {
                    largestSum = tempSum;
                }
            }
            return largestSum;
        }
    }
}

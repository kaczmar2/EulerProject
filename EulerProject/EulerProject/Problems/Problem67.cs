using System;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=67
    /// 
    /// See discussion thread for technique by user: mather
    /// http://projecteuler.net/thread=18
    /// </summary>
    class Problem67 : IProblem
    {
        public object Solve()
        {
            const string file = @"input\triangle.txt";
            var triangle = Common.GetFileInput(file);

            int[][] map = Common.ConvertInputToMap(triangle);

            int[] prevRow = map[map.Length - 1];
            for (int i = map.Length - 2; i >= 0; i--)
            {
                for (int j = 0; j < map[i].Length; j++)
                {
                    // pick the max of either of the two adjacent numbers in the previous row
                    map[i][j] = (Math.Max(map[i][j] + prevRow[j], map[i][j] + prevRow[j + 1]));
                }
                prevRow = map[i];
            }
            return map[0][0];
        }
    }
}

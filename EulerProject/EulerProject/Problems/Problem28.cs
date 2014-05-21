using System.Diagnostics;
using System.Globalization;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=28
    /// </summary>
    class Problem28 : IProblem
    {
        private const int Dim = 1001;   // must be odd!;
        static int total = 1;
        static readonly int[,] grid = new int[Dim, Dim];
        static readonly Coords coords = new Coords();

        public object Solve()
        {
            const int maxSeries = Dim;
            var m = 1;

            // build grid
            coords.X = coords.Y = (Dim - 1) / 2;
            grid[coords.X, coords.Y] = total;
            total++;
            do
            {
                MoveRight(m, coords.X, coords.Y);
                MoveDown(m, coords.X, coords.Y);
                m++;
                MoveLeft(m, coords.X, coords.Y);
                MoveUp(m, coords.X, coords.Y);
                m++;
            } while (m < maxSeries);
            MoveRight(m - 1, coords.X, coords.Y);
            // end build grid

            //PrintGrid();

            var result = CalculateDiagonalSum();
            return result;
        }

        private static void MoveRight(int m, int pX, int pY)
        {
            for (int i = 1; i <= m; i++)
            {
                coords.X = pX;
                coords.Y = pY + i;
                grid[coords.X, coords.Y] = total;
                total++;
            }
        }

        private static void MoveDown(int m, int pX, int pY)
        {
            for (int i = 1; i <= m; i++)
            {
                coords.X = pX + i;
                coords.Y = pY;
                grid[coords.X, coords.Y] = total;
                total++;
            }
        }

        private static void MoveLeft(int m, int pX, int pY)
        {
            for (int i = 1; i <= m; i++)
            {
                coords.X = pX;
                coords.Y = pY - i;
                grid[coords.X, coords.Y] = total;
                total++;
            }
        }

        private static void MoveUp(int m, int pX, int pY)
        {
            for (int i = 1; i <= m; i++)
            {
                coords.X = pX - i;
                coords.Y = pY;
                grid[coords.X, coords.Y] = total;
                total++;
            }
        }

        private static int CalculateDiagonalSum()
        {
            var sum = 0;
            for (int i = 0; i < Dim; i++)
            {
                sum += grid[i, i];
            }

            for (int j = 0; j < Dim; j++)
            {
                sum += grid[Dim - 1 - j, j];
            }
            return sum - 1; // don't count "1" twice
        }

        private static void PrintGrid()
        {
            int padding = total.ToString(CultureInfo.InvariantCulture).Length;
            for (int i = 0; i < Dim; i++)
            {
                for (int j = 0; j < Dim; j++)
                {
                    int val = grid[i, j];
                    string disp = val.ToString(CultureInfo.InvariantCulture).PadLeft(padding);
                    Trace.Write(string.Format("{0} ", disp));
                }
                Trace.WriteLine("");
            }
        }

        private class Coords
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}

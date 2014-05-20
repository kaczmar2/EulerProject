using System;

namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problem=19
    /// </summary>
    class Problem19 : IProblem
    {
        public object Solve()
        {
            var startDate = new DateTime(1901, 1, 1);
            var endDate = new DateTime(2000, 12, 31);
            int count = 0;

            DateTime currentDate = startDate;
            do
            {
                if (currentDate.Day == 1 && currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    // Sunday that falls on first day of the month
                    count++;
                }
                currentDate = currentDate.AddDays(1);
            } while (currentDate <= endDate);

            return count;
        }
    }
}

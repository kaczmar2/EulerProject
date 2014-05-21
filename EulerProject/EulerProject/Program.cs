using System.Diagnostics;
using EulerProject.Problems;

namespace EulerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IProblem problem = new Problem27();
            Debug.WriteLine(string.Format("\n====================\nSolving {0}...\n====================", problem.GetType().Name));
            object answer = problem.Solve();

            Debug.WriteLine("\n=== ANSWER ===");
            Debug.WriteLine(answer);
            Debug.WriteLine("==============\n");
        }
    }
}

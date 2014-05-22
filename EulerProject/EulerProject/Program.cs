using System.Globalization;
using EulerProject.Problems;
using System.Diagnostics;
using System.Reflection;

namespace EulerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // SOLVE A SINGLE PROBLEM
            const int pNumber = 67;
            var sw = new Stopwatch();
            string pFullName = string.Concat("EulerProject.Problems.Problem", pNumber.ToString(CultureInfo.InvariantCulture));
            var pDisplayName = pFullName.Substring(pFullName.LastIndexOf('.') + 1, pFullName.Length - 1 - pFullName.LastIndexOf('.'));
            var problem = (IProblem)Assembly.GetEntryAssembly().CreateInstance(pFullName);
            Trace.Write(string.Format("Solving {0}... ", pDisplayName));
            if (problem != null)
            {
                sw.Start();
                object answer = problem.Solve();
                sw.Stop();
                Trace.WriteLine(string.Format("Answer: {0}. Solved in {1}ms.", answer, sw.ElapsedMilliseconds));
            }
            else
            {
                Trace.WriteLine("Problem not yet solved.");
            }
            Trace.Flush();

            //// SOLVE A RANGE OF PROBLEMS
            //const int problemStartNum = 1;
            //const int problemEndNum = 15;
            //var sw = new Stopwatch();
            //for (int n = problemStartNum; n <= problemEndNum; n++)
            //{
            //    string pn = n.ToString("D2");
            //    string fn = string.Concat("EulerProject.Problems.Problem", pn);
            //    var dn = fn.Substring(fn.LastIndexOf('.') + 1, fn.Length - 1 - fn.LastIndexOf('.'));
            //    var p = (IProblem)Assembly.GetEntryAssembly().CreateInstance(fn);
            //    Trace.Write(string.Format("Solving {0}... ", dn));
            //    if (p != null)
            //    {
            //        sw.Start();
            //        object answer = p.Solve();
            //        sw.Stop();
            //        Trace.WriteLine(string.Format("Answer: {0}. Solved in {1}ms.", answer, sw.ElapsedMilliseconds));
            //        sw.Reset();
            //    }
            //    else
            //    {
            //        Trace.WriteLine("Problem not yet solved.");
            //    }
            //    Trace.Flush();
            //}
        }
    }
}

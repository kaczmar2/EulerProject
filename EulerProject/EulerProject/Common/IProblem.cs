
namespace EulerProject.Problems
{
    /// <summary>
    /// http://projecteuler.net/problems
    /// </summary>
    public interface IProblem
    {
        /// <summary>
        /// Contains all logic that solves the problem.
        /// </summary>
        /// <returns>A <see cref="System.Object"/> containing the answer.</returns>
        object Solve();
    }
}

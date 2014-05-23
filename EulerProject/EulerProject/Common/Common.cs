using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;

namespace EulerProject
{
    public class Common
    {
        public static double Phi = (1 + Math.Sqrt(5)) / 2.0;
        public static BigInteger Fibonacci(BigInteger n)
        {
            var previous = new BigInteger(-1);
            var result = new BigInteger(1);
            for (BigInteger i = 0; i <= n; ++i)
            {
                BigInteger sum = result + previous;
                previous = result;
                result = sum;
            }
            return result;
        }

        public static bool IsPalindrome(int num)
        {
            var forward = num.ToString(CultureInfo.InvariantCulture);
            var temp = forward.Reverse().ToArray();
            var reverse = new string(temp);

            return forward.Equals(reverse);
        }

        public static bool IsPalindrome(string num)
        {
            var temp = num.Reverse().ToArray();
            var reverse = new string(temp);

            return num.Equals(reverse);
        }

        public static double SumOfSquares(int maxNumber)
        {
            double result = 0;
            for (int i = 1; i <= maxNumber; i++)
            {
                result += Math.Pow(i, 2);
            }
            return result;
        }

        public static double SquareOfSum(int maxNumber)
        {
            double result = 0;
            for (int i = 1; i <= maxNumber; i++)
            {
                result += i;
            }
            return Math.Pow(result, 2);
        }

        public static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)   // i < num
            {
                if (num % i == 0)
                {
                    // divisable - not prime
                    return false;
                }
            }
            return true;
        }

        public static List<uint> CollatzSequence(uint num)
        {
            var seq = new List<uint>();
            while (true)
            {
                if (num <= 1)
                {
                    seq.Add(num);
                    return seq;
                }

                if (num % 2 == 0)
                {
                    // even
                    num = num / 2;
                }
                else
                {
                    // odd
                    num = 3 * num + 1;
                }
                seq.Add(num);
            }
        }

        public static BigInteger Factorial(BigInteger n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        /// <summary>
        /// http://stackoverflow.com/questions/2729752/converting-numbers-in-to-words-c-sharp
        /// </summary>
        /// <param name="number">A <see cref="System.Int32"/>to convert to words </param>
        /// <returns>The number in words</returns>
        public static string NumberToWords(int number)
        {
            string words = "";

            if (number == 0)
            {
                return "zero";
            }

            if (number < 0)
            {
                return "minus " + NumberToWords(Math.Abs(number));
            }

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                {
                    words += "and ";
                }

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                {
                    words += unitsMap[number];
                }
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                    {
                        words += "-" + unitsMap[number % 10];
                    }
                }
            }
            return words;
        }

        public static string GetFileInput(string filePath)
        {
            string input = File.ReadAllText(filePath);
            return input;
        }

        public static long GetTriangularNumber(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static List<long> GetDivisors(long num)
        {
            var divisors = new List<long> {1, num};
            for (int d = 2; d <= num / 2; d++)
            {
                if (num % d == 0)
                {
                    divisors.Add(d);
                }
            }
            return divisors;
        }

        public static long GetDivisorsCount(long num)
        {
            var count = 0;
            var sqrt = Math.Round(Math.Sqrt(num));
            for (int d = 1; d < sqrt; d++)
            {
                if (num % d == 0)
                {
                    count += 2;
                }
            }
            return count;
        }

        public static NumberType GetNumberType(int num)
        {
            var sum = GetDivisors(num).Sum();
            if (sum == num)
            {
                return NumberType.Perfect;
            }
            return sum > num ? NumberType.Abundant : NumberType.Deficient;
        }

        public static int RotateDigits(int num)
        {
            var str = num.ToString(CultureInfo.InvariantCulture);
            var first = str.Substring(str.Length - 1, 1);
            var sub = str.Substring(0, str.Length - 1);
            return int.Parse(first + sub);
        }

        public static int DigitalSum(BigInteger n)
        {
            int sum = 0;

            foreach (var c in n.ToString().ToCharArray())
            {
                var d = int.Parse(c.ToString(CultureInfo.InvariantCulture));
                sum += d;
            }
            return sum;
        }

        public static double GetSquareOfDigits(double n)
        {
            double sum = 0;
            var chars = n.ToString(CultureInfo.InvariantCulture).ToCharArray();
            foreach (var c in chars)
            {
                sum += Math.Pow(double.Parse(c.ToString(CultureInfo.InvariantCulture)), 2);
            }
            return sum;
        }

        /// <summary>
        /// Used in problems 18 and 67. Convert input data to Jagged array for processing
        /// </summary>
        /// <param name="input">input data</param>
        /// <returns>Jagged array containing the data for processing</returns>
        public static int[][] ConvertInputToMap(string input)
        {
            string[] levels = input.Split('\n');
            var map = new int[levels.Length][];
            for (int i = 0; i < levels.Length; i++)
            {
                map[i] = levels[i].Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            }
            return map;
        }

        /// <summary>
        /// Gets total word value sum where A=1, B=2, etc.
        /// Only works for uppercase letters (they are converted)
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static int GetWordValue(string word)
        {
            int val = word.ToUpper().Sum(c => (int)c - 64);
            return val;
        }

        /// <summary>
        /// Returns the count of ways we can sum  s[0...m-1] coins to get sum n
        /// http://www.geeksforgeeks.org/dynamic-programming-set-7-coin-change/
        /// </summary>
        /// <param name="s">Coin set</param>
        /// <param name="m">Length of coin set 's'</param>
        /// <param name="n">Amount we need to make change for</param>
        /// <returns>Count of all possible coin sums</returns>
        public static int CountCoinSums(int[] s, int m, int n)
        {
            // If n is 0 then there is 1 solution (do not include any coin)
            if (n == 0)
                return 1;

            // If n is less than 0 then no solution exists
            if (n < 0)
                return 0;

            // If there are no coins and n is greater than 0, then no solution exist
            if (m <= 0 && n >= 1)
                return 0;

            // count is sum of solutions (i) including S[m-1] (ii) excluding S[m-1]
            return CountCoinSums(s, m - 1, n) + CountCoinSums(s, m, n - s[m - 1]);
        }
    }
}

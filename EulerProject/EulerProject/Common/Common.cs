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
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

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
                    words += "and ";

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
            var divisors = new List<long>();// {1, num}; // prob 12, 23
            for (int d = 2; d <= num / 2; d++)
            {
                if (num % d == 0)
                {
                    divisors.Add(d);
                }
            }
            return divisors;
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_06_14
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            numbers = ResolveDelimiters(numbers);

            return SumNumbers(numbers);
        }

        private static int SumNumbers(string numbers)
        {
            if (numbers.Contains(","))
            {
                var split = numbers.Split(',', '\n');
                ResolveNegatives(split);
                var preferredNumbers = ResolvePreferredNumbers(split);
                return preferredNumbers.Sum(x => int.Parse(x));
            }
            return int.Parse(numbers);
        }

        private static string[] ResolvePreferredNumbers(string[] split)
        {
            return split.Where(x => int.Parse(x) <= 1000).ToArray();
        }

        private static void ResolveNegatives(string[] split)
        {
            var negatives = split.Where(x => int.Parse(x) < 0);
            if (negatives.Any())
            {
                var message = "negatives not allowed: " + string.Join(",", negatives.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static string ResolveDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var split = numbers.Split('\n');
                var numbersInSplit = split[1];
                var delimitersInSplit = split[0].Replace("//", "");
                var trimmings = new[] { '[', ']' };
                var delimiters = delimitersInSplit.Split(trimmings, StringSplitOptions.RemoveEmptyEntries);

                foreach (var delimiter in delimiters)
                {
                    numbersInSplit = numbersInSplit.Replace(delimiter, ",");
                }
                return numbersInSplit;
            }
            return numbers;
        }
    }
}
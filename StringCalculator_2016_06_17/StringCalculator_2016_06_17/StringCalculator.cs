using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_06_17
{
    internal class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            numbers = ResolveDelimiters(numbers);

            if (numbers.Contains(","))
            {
                var defaultDelimiters = new[] { ',', '\n' };
                var split = numbers.Split(defaultDelimiters);
                CheckForNegatives(split);
                return FilterSplitNumbers(split).Sum(x => int.Parse(x));
            }

            return int.Parse(numbers);
        }

        private static IEnumerable<string> FilterSplitNumbers(string[] split)
        {
            return split.Where(x => int.Parse(x) <= 1000);
        }

        private static void CheckForNegatives(string[] split)
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
                var trimmmings = new[] { '[', ']' };
                var delimiters = split[0].Replace("//", "").Split(trimmmings, StringSplitOptions.RemoveEmptyEntries);
                var numbersToReplace = split[1];
                foreach (var delimiter in delimiters)
                {
                    numbersToReplace = numbersToReplace.Replace(delimiter, ",");
                }
                return numbersToReplace;
            }
            return numbers;
        }
    }
}
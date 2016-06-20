using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_06_20
{
    public class StringCalculator
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
                return GetNumbersBelow1000(split).Sum(x => int.Parse(x));
            }

            return int.Parse(numbers);
        }

        private static string ResolveDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var split = numbers.Split('\n');
                var trimmings = new[] { '[', ']' };
                var delimiters = split[0].Replace("//", "").Split(trimmings, StringSplitOptions.RemoveEmptyEntries);
                var numbersPart = split[1];
                foreach (var delimiter in delimiters)
                {
                    numbersPart = numbersPart.Replace(delimiter, ",");
                }
                return numbersPart;
            }
            return numbers;
        }

        private static IEnumerable<string> GetNumbersBelow1000(string[] split)
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
    }
}
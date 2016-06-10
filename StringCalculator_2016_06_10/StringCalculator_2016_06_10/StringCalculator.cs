using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_06_10
{
    internal class StringCalculator
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
            if (!numbers.Contains(","))
                return int.Parse(numbers);

            var split = numbers.Split(',', '\n');
            CheckForNegatives(split);
            return FilterNumbers(split).Sum(x => int.Parse(x));
        }

        private static IEnumerable<string> FilterNumbers(string[] split)
        {
            return split.Where(x => int.Parse(x) <= 1000);
        }

        private static string ResolveDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var split = numbers.Split('\n');
                var delimiterList = GetDelimiterList(split);
                var newNumbers = delimiterList.Aggregate(split[1], (current, delimiter) => current.Replace(delimiter, ","));
                return newNumbers;
            }
            return numbers;
        }

        private static string[] GetDelimiterList(string[] split)
        {
            return split[0].Replace("//", "").Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private static void CheckForNegatives(string[] split)
        {
            var negatives = split.Where(x => int.Parse(x) < 0);
            if (negatives.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negatives.ToArray()));
        }
    }
}
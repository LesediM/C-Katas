using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_06_09
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
                var split = numbers.Split(',', '\n');
                CheckForNegatives(split);
                var filteredNumbers = FilterNumbers(split);
                return filteredNumbers.Sum(x => int.Parse(x));
            }

            return int.Parse(numbers);
        }

        private static IEnumerable<string> FilterNumbers(string[] split)
        {
            return split.Where(x=>int.Parse(x)<=1000);
        }

        private static void CheckForNegatives(string[] split)
        {
            var negatives = split.Where(x => int.Parse(x) < 0);
            if (negatives.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negatives.ToArray()));
        }

        private static string ResolveDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var split = numbers.Split('\n');
                var delimiterList = split[0].Replace("//","").Split(new []{'[',']'},StringSplitOptions.RemoveEmptyEntries);
                var numbersPart = split[1];
                foreach (var delimiter in delimiterList)
                {
                    numbersPart = numbersPart.Replace(delimiter, ",");
                }
                return numbersPart;
            }
            return numbers;
        }
    }
}
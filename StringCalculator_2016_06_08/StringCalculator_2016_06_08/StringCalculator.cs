using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculator_2016_06_08
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
                var split = ResolveSplitNumbers(numbers);
                ResolveNegatives(split);
                var resolvedNumbers = ResolveNumbers(split);
                return resolvedNumbers.Sum(x => int.Parse(x));
            }

            return int.Parse(numbers);
        }

        private static string[] ResolveNumbers(string[] split)
        {
            return split.Where(x => int.Parse(x) <= 1000).ToArray();
        }

        private static string[] ResolveSplitNumbers(string numbers)
        {
            var separatorList = new[] { ',', '\n' };
            var split = numbers.Split(separatorList);
            return split;
        }

        private static void ResolveNegatives(string[] split)
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
                var delimiterList = split[0].Replace("//", "").Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                var numberSection = split[1];
                foreach (var delimiter in delimiterList)
                {
                    numberSection = numberSection.Replace(delimiter, ",");
                }
                return numberSection;
            }
            return numbers;
        }
    }
}
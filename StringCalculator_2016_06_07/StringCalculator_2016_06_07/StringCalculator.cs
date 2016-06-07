using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_06_07
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
                var separatorList = new[] { ',', '\n' };
                var split = ResolveSplitNumbers(numbers, separatorList);
                CheckForNegativeNumbers(split);
                return split.Sum(x => int.Parse(x));
            }

            return int.Parse(numbers);
        }

        private static string[] ResolveSplitNumbers(string numbers, char[] separatorList)
        {
            return numbers.Split(separatorList).Where(x => int.Parse(x) <= 1000).ToArray();
        }

        private static void CheckForNegativeNumbers(string[] split)
        {
            var negativeNumbers = split.Where(x => int.Parse(x) < 0);
            if (negativeNumbers.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativeNumbers.ToArray()));
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
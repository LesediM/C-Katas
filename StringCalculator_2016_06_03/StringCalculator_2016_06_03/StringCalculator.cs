using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_06_03
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
                var split = SplitNumbers(numbers);
                CheckForNegatives(split);
                return split.Sum(x => int.Parse(x));
            }

            return int.Parse(numbers);
        }

        private static string ResolveDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var split = numbers.Split('\n');
                var delimiterPart = split[0].Replace("//", "");
                var numberPart = split[1];

                var delimiterList = GetDelimiterList(delimiterPart);
                foreach (var delimiter in delimiterList)
                {
                    numberPart = numberPart.Replace(delimiter, ",");
                }
                return numberPart;
            }
            return numbers;
        }

        private static string[] GetDelimiterList(string delimiterPart)
        {
            return delimiterPart.Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private static void CheckForNegatives(string[] split)
        {
            var negativeNumbers = split.Where(x => int.Parse(x) < 0);
            if (negativeNumbers.Any())
            {
                var negativeNumbersJoined = string.Join(",", negativeNumbers.ToArray());
                throw new ArgumentException("negatives not allowed: " + negativeNumbersJoined);
            }
        }

        private static string[] SplitNumbers(string numbers)
        {
            return numbers.Split(new[] { ',', '\n' }).Where(x => int.Parse(x) <= 1000).ToArray();
        }
    }
}
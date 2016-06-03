using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_06_02
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
                var split = SplitNumberString(numbers);
                CheckForNegatives(split);
                var sum = split.Sum(x => int.Parse(x));
                return sum;
            }

            return int.Parse(numbers);
        }

        private static string ResolveDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var split = numbers.Split('\n');
                var trimmings = new []{'[',']'};
                var delimiters = split[0].Replace("//","").Split(trimmings,StringSplitOptions.RemoveEmptyEntries);
                var numberSect = split[1];

                foreach (var delimiter in delimiters)
                {
                    numberSect = numberSect.Replace(delimiter, ",");
                }
                return numberSect;
            }
            return numbers;
        }

        private static void CheckForNegatives(string[] split)
        {
            var negativeNumbers = split.Where(x => int.Parse(x) < 0);
            if (negativeNumbers.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativeNumbers.ToArray()));
        }

        private static string[] SplitNumberString(string numbers)
        {
            var separatorList = new[] { ',', '\n' };
            var split = numbers.Split(separatorList).Where(x => int.Parse(x) <= 1000).ToArray();
            return split;
        }
    }
}
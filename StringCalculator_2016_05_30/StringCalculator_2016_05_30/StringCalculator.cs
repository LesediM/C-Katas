using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_05_30
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            if (numbers.StartsWith("//"))
            {
                numbers = ResolveDelimiters(numbers);
            }

            if (numbers.Contains(","))
            {
                var separatorList = new[] { ',', '\n' };
                var split = numbers.Split(separatorList);
                CheckForNegatives(split);
                var sum = split.Where(x => int.Parse(x) <= 1000).Sum(x => int.Parse(x));
                return sum;
            }

            return int.Parse(numbers);
        }

        private static string ResolveDelimiters(string numbers)
        {
            var split = numbers.Split('\n');
            var delimiterParts = split[0].Replace("//", "").Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
            var numberPart = split[1];
            foreach (var delimiter in delimiterParts)
            {
                numberPart = numberPart.Replace(delimiter, ",");
            }
            return numberPart;
        }

        private static void CheckForNegatives(string[] split)
        {
            var negativeList = split.Where(x => int.Parse(x) < 0);
            if (negativeList.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativeList.ToArray()));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace StringCalculator_2016_05_24
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

            if (numbers.Contains(",") || numbers.Contains("\n"))
            {
                return SumNumbers(numbers);
            }
            return int.Parse(numbers);
        }

        private static string ResolveDelimiters(string numbers)
        {
            var split = numbers.Split('\n');
            var delimiterList = split[0].Replace("//", "").Split(new[] { '[', ']' },StringSplitOptions.RemoveEmptyEntries);
            var numberPart = split[1];
            foreach (var delimiter in delimiterList)
            {
                numberPart = numberPart.Replace(delimiter, ",");
            }
            return numberPart;
        }

        private static int SumNumbers(string numbers)
        {
            var splitNumbers = numbers.Split(',', '\n').Where(x => int.Parse(x) <= 1000).ToArray();
            ResolveNegatives(splitNumbers);
            var sum = splitNumbers.Sum(x => int.Parse(x));
            return sum;
        }

        private static void ResolveNegatives(string[] splitNumbers)
        {
            var negativeNumbers = splitNumbers.Where(x => int.Parse(x) <= 0);
            if (negativeNumbers.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativeNumbers.ToArray()));
        }
    }
}
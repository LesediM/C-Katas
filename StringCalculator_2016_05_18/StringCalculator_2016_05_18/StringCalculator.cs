using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_05_18
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var separatorList = new[] { ',', '\n' };

            numbers = ResolveDelimiters(numbers);

            var splitNumbers = SplitNumbers(numbers, separatorList);

            NegativeNumberCheck(splitNumbers);

            var sumOfNumbers = splitNumbers.Sum(x => int.Parse(x));
            return sumOfNumbers;
        }

        private static string[] SplitNumbers(string numbers, char[] separatorList)
        {
            return numbers.Split(separatorList).Where(x => int.Parse(x) <= 1000).ToArray();
        }

        private static void NegativeNumberCheck(string[] splitNumbers)
        {
            var negativeNumbers = splitNumbers.Where(x => int.Parse(x) < 0);
            if (negativeNumbers.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativeNumbers.ToArray()));
        }

        private static string ResolveDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var split = numbers.Split('\n');
                var delimiterPart = split[0];
                var numberPart = split[1];
                var delimiterList = delimiterPart.Replace("//", "").Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var delimiter in delimiterList)
                {
                    numberPart = numberPart.Replace(delimiter, ",");
                }
                numbers = numberPart;
            }
            return numbers;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_05_16
{
    public class StringCalculator

    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var delimiters = new[] { ',', '\n' };
            numbers = ResolveDelimiters(numbers);
            var splitNumbers = SplitNumbers(numbers, delimiters);

            NegativeCheck(splitNumbers);

            var sum = splitNumbers.Sum(x => int.Parse(x));
            return sum;
        }

        private static string ResolveDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var split = numbers.Split('\n');
                var delimiterList = split[0].Replace("//", "").Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                var numberPart = split[1];
                foreach (var delimiter in delimiterList)
                {
                    numberPart = numberPart.Replace(delimiter, ",");
                }
                numbers = numberPart;
            }
            return numbers;
        }

        private static void NegativeCheck(string[] splitNumbers)
        {
            var negativeList = splitNumbers.Where(x => int.Parse(x) < 0);
            if (negativeList.Any())
                throw new ArgumentException("negative numbers not allowed: " + string.Join(",", negativeList.ToArray()));
        }

        private static string[] SplitNumbers(string numbers, char[] delimiters)
        {
            return numbers.Split(delimiters).Where(x => int.Parse(x) <= 1000).ToArray();
        }
    }
}
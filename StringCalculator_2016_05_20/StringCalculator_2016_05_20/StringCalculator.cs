using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_05_20
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var separators = new[] { ',', '\n' };
            numbers = ResolveDelimiters(numbers);

            var splitNumbers = SplitNumbers(numbers, separators);
            NegativeCheck(splitNumbers);
            var sum = splitNumbers.Sum(x => int.Parse(x));

            return sum;
        }

        private static string ResolveDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var split = numbers.Split('\n');
                var delimterSec = split[0];
                var numberSec = split[1];
                var delimiterList = delimterSec.Replace("//", "").Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var delimiter in delimiterList)
                {
                    numberSec = numberSec.Replace(delimiter, ",");
                }
                numbers = numberSec;
            }
            return numbers;
        }

        private static void NegativeCheck(string[] splitNumbers)
        {
            var negativeList = splitNumbers.Where(x => int.Parse(x) < 0);
            if (negativeList.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativeList.ToArray()));
        }

        private static string[] SplitNumbers(string numbers, char[] separators)
        {
            return numbers.Split(separators).Where(x => int.Parse(x) <= 1000).ToArray();
        }
    }
}
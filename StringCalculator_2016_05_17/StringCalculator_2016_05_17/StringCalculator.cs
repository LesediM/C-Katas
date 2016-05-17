using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_05_17
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var delimiters = new[] { ',', '\n' };
            numbers = ResolveDeilimters(numbers);
            var split = SplitNumbers(numbers, delimiters);

            NegativeExceptionCheck(split);

            var sum = split.Sum(x => int.Parse(x));

            return sum;
        }

        private static string ResolveDeilimters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var splitSections = numbers.Split('\n');
                var delimiterPart = splitSections[0];
                var numberPart = splitSections[1];
                var delimiterList = delimiterPart.Replace("//", "").Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var delimiter in delimiterList)
                {
                    numberPart = numberPart.Replace(delimiter, ",");
                }
                numbers = numberPart;
            }
            return numbers;
        }

        private static string[] SplitNumbers(string numbers, char[] delimiters)
        {
            return numbers.Split(delimiters).Where(x => int.Parse(x) <= 1000).ToArray();
        }

        private static void NegativeExceptionCheck(string[] split)
        {
            var negativeList = split.Where(x => int.Parse(x) < 0);
            if (negativeList.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativeList.ToArray()));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_05_10
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var delimiters = new[] { ',', '\n' };

            if (numbers.StartsWith("//"))
            {
                numbers = GetDelimiters(numbers);
            }

            var splitNumbers = SplitNumbers(numbers, delimiters);
            NegativeCheck(splitNumbers);
            var sum = splitNumbers.Sum(x => int.Parse(x));
            return sum;
        }

        private string GetDelimiters(string numbers)
        {
            var split = numbers.Split('\n');
            var delimiterList = split[0].Replace("//", "").Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
            var numberPart = split[1];
            foreach (var delimiter in delimiterList)
            {
                numberPart = numberPart.Replace(delimiter, ",");
            }
            numbers = numberPart;
            return numbers;
        }

        private void NegativeCheck(string[] splitNumbers)
        {
            var negativeList = splitNumbers.Where(x => int.Parse(x) < 0);
            if (negativeList.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativeList.ToArray()));
        }

        private string[] SplitNumbers(string numbers, char[] delimiters)
        {
            return numbers.Split(delimiters).Where(x => int.Parse(x) <= 1000).ToArray();
        }
    }
}
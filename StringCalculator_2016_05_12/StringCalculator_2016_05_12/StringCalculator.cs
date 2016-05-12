using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_05_12
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var delimiters = new[] { ',', '\n' };
            numbers = ResovleDeilimters(numbers);

            var numberSplit = NumberSplit(numbers, delimiters);
            NegativeNumberCheck(numberSplit);
            var sum = numberSplit.Sum(x => int.Parse(x.ToString()));
            return sum;
        }

        private  string ResovleDeilimters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var split = numbers.Split('\n');
                var delimiterList = split[0].Replace("//", "").Split(new[] {'[', ']'}, StringSplitOptions.RemoveEmptyEntries);
                var numberStr = split[1];
                foreach (var delimiter in delimiterList)
                {
                    numberStr = numberStr.Replace(delimiter, ",");
                }
                numbers = numberStr;
            }
            return numbers;
        }

        private string[] NumberSplit(string numbers, char[] delimiters)
        {
            return numbers.Split(delimiters).Where(x => int.Parse(x) <= 1000).ToArray();
        }

        private void NegativeNumberCheck(string[] numberSplit)
        {
            var negativeNumbers = numberSplit.Where(x => int.Parse(x) < 0);
            if (negativeNumbers.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativeNumbers.ToArray()));
        }
    }
}
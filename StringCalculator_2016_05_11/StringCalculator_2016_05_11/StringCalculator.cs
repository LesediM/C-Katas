using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_05_11
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            var delimiterList = new[] { ',', '\n' };
            numbers = ResolveDelimiters(numbers);
            var splitNumbers = SplitNumbers(numbers, delimiterList);
            NegativeNumbers(splitNumbers);
            var sum = splitNumbers.Sum(x => int.Parse(x));

            return sum;
        }

        private  string ResolveDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var splitNumberString = numbers.Split('\n');
                var delimiters = splitNumberString[0].Replace("//", "")
                    .Split(new[] {'[', ']'}, StringSplitOptions.RemoveEmptyEntries);
                var numberString = splitNumberString[1];
                foreach (var delimiter in delimiters)
                {
                    numberString = numberString.Replace(delimiter, ",");
                }
                numbers = numberString;
            }
            return numbers;
        }

        private string[] SplitNumbers(string numbers, char[] delimiterList)
        {
            return numbers.Split(delimiterList).Where(x => int.Parse(x) <= 1000).ToArray();
        }

        private void NegativeNumbers(string[] splitNumbers)
        {
            var negativeNumbers = splitNumbers.Where(x => int.Parse(x) < 0);
            if (negativeNumbers.Any())
                throw new ArgumentException("negative numbers not allowed: " + string.Join(",", negativeNumbers.ToArray()));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_05_06
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;
            var delimiters = new[] { ',', '\n' };

            numbers = ResolveDelimiterss(numbers);
            var splitNumbers = SplitNumbers(numbers, delimiters);

            NegativeExceptionCheck(splitNumbers);
            return splitNumbers.Sum(x => int.Parse(x));
        }

        private string ResolveDelimiterss(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var splitNumberString = numbers.Split('\n');
                var delimiterList = splitNumberString[0].Replace("//", "").Split(new []{'[',']'},StringSplitOptions.RemoveEmptyEntries);
                var numberPart = splitNumberString[1];
                foreach (var delimiter in delimiterList)
                {
                    numberPart = numberPart.Replace(delimiter, ",");
                }
                numbers = numberPart;
                Console.Write(numbers);
            }
            return numbers;
        }

        private void NegativeExceptionCheck(string[] splitNumbers)
        {
            var negatives = splitNumbers.Where(x => int.Parse(x) < 0);
            if (negatives.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negatives.ToArray()));
        }

        private string[] SplitNumbers(string numbers, char[] delimiters)
        {
            return numbers.Split(delimiters).Where(x => int.Parse(x) <= 1000).ToArray();
        }
    }
}
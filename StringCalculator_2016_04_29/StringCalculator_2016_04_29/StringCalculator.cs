using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_04_29
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            
            numbers = ResolveDelimiters(numbers);
            var splitNumbers = SplitNumbers(numbers);
            NegativeNumberCheck(splitNumbers);
            var sum = splitNumbers.Sum(x => int.Parse(x));
            return sum;
        }

        private string ResolveDelimiters(string numbers)
        {
            var numberString = numbers;
            if (numbers.StartsWith("//"))
            {
                var splitOfNumberStringByNewline = numbers.Split('\n');
                var delimiters = splitOfNumberStringByNewline[0].Replace("//", "").Split(new [] {'[',']'},StringSplitOptions.RemoveEmptyEntries);
                var numberPart = splitOfNumberStringByNewline[1];
                foreach (var delimiter in delimiters)
                {
                    numberPart = numberPart.Replace(delimiter, ",");
                }
                numberString = numberPart;
            }
            return numberString;
        }

        private void NegativeNumberCheck(string[] splitNumbers)
        {
            var negativeNumbers = splitNumbers.Where(x => int.Parse(x) < 0);
            if (negativeNumbers.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativeNumbers.ToArray()));
        }

        private string[] SplitNumbers(string numbers)
        {
            return numbers.Split(new[] { ',', '\n' }).Where(x => int.Parse(x) <= 1000).ToArray();
        }
    }
}